using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MigrateDatabase;

namespace InventoryApp
{
    public partial class MedicineForm : BaseForm
    {
        private InventoryAppDbContext dbContext;

        public MedicineForm(InventoryAppDbContext context)
        {
            InitializeComponent();
            dbContext = context;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtTenThuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Thuốc.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenThuoc.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoDangKy.Text))
            {
                MessageBox.Show("Vui lòng nhập Số Đăng Ký.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDangKy.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoatChatChinh.Text))
            {
                MessageBox.Show("Vui lòng nhập Hoạt Chất Chính.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoatChatChinh.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHamLuong.Text))
            {
                MessageBox.Show("Vui lòng chọn Hàm Lượng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHamLuong.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHangSanXuat.Text))
            {
                MessageBox.Show("Vui lòng nhập Hãng Sản Xuất.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHangSanXuat.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNuocSanXuat.Text))
            {
                MessageBox.Show("Vui lòng nhập Nước Sản Xuất.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNuocSanXuat.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtQuyCachDongGoi.Text))
            {
                MessageBox.Show("Vui lòng nhập Quy Cách Đóng Gói.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuyCachDongGoi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDonViTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập Đơn Vị Tính.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonViTinh.Focus();
                return false;
            }

            // Nếu tất cả đều hợp lệ
            return true;
        }

        private string GenerateMaThuoc()
        {
            var count = dbContext.Medicines.Count() + 1;
            return $"ME{count:D5}"; // VD: SP00001
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var medicine = new Medicine
                {
                    MaThuoc = GenerateMaThuoc(),
                    TenThuoc = txtTenThuoc.Text.Trim(),
                    SoDangKy = txtSoDangKy.Text.Trim(),
                    HoatChatChinh = txtHoatChatChinh.Text.Trim(),
                    HamLuong = txtHamLuong.Text.Trim(),
                    HangSanXuat = txtHangSanXuat.Text.Trim(),
                    NuocSanXuat = txtNuocSanXuat.Text.Trim(),
                    QuyCachDongGoi = txtQuyCachDongGoi.Text.Trim(),
                    DonViTinh = txtDonViTinh.Text.Trim()
                };

                try
                {
                    dbContext.Medicines.Add(medicine);
                    dbContext.SaveChanges();

                    MessageBox.Show("Lưu thuốc thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi lưu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
