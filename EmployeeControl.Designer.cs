namespace InventoryApp
{
    partial class EmployeeControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnAdd, btnEdit, btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvEmployees = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtTimKiem = new TextBox();
            label1 = new Label();
            btnTimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.Location = new Point(13, 132);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(833, 410);
            dgvEmployees.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkGreen;
            btnAdd.Font = new Font("Segoe UI", 9.75F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(13, 92);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.HotTrack;
            btnEdit.Font = new Font("Segoe UI", 9.75F);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(99, 92);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(80, 34);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 9.75F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(185, 92);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 34);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(13, 44);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 29);
            txtTimKiem.TabIndex = 6;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(188, 25);
            label1.TabIndex = 7;
            label1.Text = "Tìm Kiếm Nhân Viên";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.OrangeRed;
            btnTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(314, 45);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(80, 29);
            btnTimKiem.TabIndex = 8;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // EmployeeControl
            // 
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnTimKiem);
            Controls.Add(label1);
            Controls.Add(txtTimKiem);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dgvEmployees);
            Name = "EmployeeControl";
            Size = new Size(860, 557);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox txtTimKiem;
        private Label label1;
        private Button btnTimKiem;
    }
}
