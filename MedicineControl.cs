using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using MigrateDatabase;
using MigrateDatabase.Models;

namespace InventoryApp
{
    public partial class MedicineControl : UserControl
    {
        private InventoryAppDbContext dbContext;

        public MedicineControl(InventoryAppDbContext context)
        {
            InitializeComponent();
            dbContext = context;

            LoadSanPham(context.Medicines.ToList());

            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(dbContext.Medicines.Select(X => X.MaThuoc).ToArray());
            autoCompleteStringCollection.AddRange(dbContext.Medicines.Select(X => X.TenThuoc).ToArray());
            txtTimKiemThuoc.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void LoadSanPham(List<Medicine> inventoryList)
        {
            gridViewMedicine.DataSource = inventoryList;
            gridViewMedicine.Columns["Id"].Visible = false;
            gridViewMedicine.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
            gridViewMedicine.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
            gridViewMedicine.Columns["SoDangKy"].HeaderText = "Số Đăng Ký";
            gridViewMedicine.Columns["HoatChatChinh"].HeaderText = "Hoạt Chất";
            gridViewMedicine.Columns["HamLuong"].HeaderText = "Hàm Lượng";
            gridViewMedicine.Columns["HangSanXuat"].HeaderText = "Hãng Sản Xuất";
            gridViewMedicine.Columns["NuocSanXuat"].HeaderText = "Nước Sản Xuất";
            gridViewMedicine.Columns["QuyCachDongGoi"].HeaderText = "Đóng Gói";
            gridViewMedicine.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";


            gridViewMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewMedicine.AllowUserToAddRows = false;
            gridViewMedicine.AutoGenerateColumns = true;
            gridViewMedicine.ReadOnly = true;
            gridViewMedicine.EnableHeadersVisualStyles = false;
            gridViewMedicine.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            gridViewMedicine.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewMedicine.EnableHeadersVisualStyles = false;
            gridViewMedicine.RowHeadersVisible = false;
            gridViewMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewMedicine.SelectionMode = DataGridViewSelectionMode.CellSelect;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, gridViewMedicine, new object[] { true });

            gridViewMedicine.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gridViewMedicine.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridViewMedicine.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            gridViewMedicine.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            gridViewMedicine.DefaultCellStyle.SelectionForeColor = Color.Black;
            gridViewMedicine.GridColor = Color.LightGray;
            gridViewMedicine.BackgroundColor = Color.White;
        }

        private void btnDownFileMau_Click(object sender, EventArgs e)
        {
            string sourcePath = Path.Combine(Application.StartupPath, "MauNhapThuoc.xlsx");

            if (!File.Exists(sourcePath))
            {
                MessageBox.Show("Không tìm thấy file mẫu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Lưu file mẫu nhập thuốc";
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDialog.FileName = "MauNhapThuoc.xlsx";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Copy(sourcePath, saveDialog.FileName, true);
                        MessageBox.Show("Lưu file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            MedicineForm frm = new MedicineForm(dbContext);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadSanPham(dbContext.Medicines.ToList());
            }
        }

        private void txtTimKiemThuoc_TextChanged(object sender, EventArgs e)
        {
            string query = txtTimKiemThuoc.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(query) == false)
            {
                var medicines = dbContext.Medicines.Where(x => x.MaThuoc.ToLower().Contains(query) || x.TenThuoc.ToLower().Contains(query));
                LoadSanPham(medicines.ToList());
            }
        }

        private async void btnNhapThuoc_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var progressForm = new ProgressForm();
                progressForm.Show();

                try
                {
                    await Task.Run(() =>
                    {
                        ExcelSync.SyncThuocWithProcess(ofd.FileName, dbContext, progressForm.UpdateProgress);
                    });

                    MessageBox.Show("Nhập thuốc thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    progressForm.Close();
                }
            }
        }
    }
}
