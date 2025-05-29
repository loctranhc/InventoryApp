using System.Windows.Forms;

namespace InventoryApp
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtFullName, txtUsername, txtEmail;
        private Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            txtPhone = new TextBox();
            txtMatKhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cbxGioiTinh = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11.25F);
            txtFullName.Location = new Point(31, 39);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(422, 27);
            txtFullName.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11.25F);
            txtUsername.Location = new Point(31, 336);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(422, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.Location = new Point(31, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(422, 27);
            txtEmail.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = Color.OrangeRed;
            this.btnSave.Font = new Font("Segoe UI", 11.25F);
            this.btnSave.ForeColor = SystemColors.InactiveBorder;
            this.btnSave.Location = new Point(279, 456);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(174, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += this.btnSave_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 11.25F);
            txtDiaChi.Location = new Point(31, 157);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(422, 27);
            txtDiaChi.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11.25F);
            txtPhone.Location = new Point(31, 272);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(422, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 11.25F);
            txtMatKhau.Location = new Point(31, 395);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(422, 27);
            txtMatKhau.TabIndex = 8;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(31, 374);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 9;
            label1.Text = "Mật Khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(31, 316);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 10;
            label2.Text = "UserName";
            // 
            // cbxGioiTinh
            // 
            cbxGioiTinh.Font = new Font("Segoe UI", 11.25F);
            cbxGioiTinh.FormattingEnabled = true;
            cbxGioiTinh.Location = new Point(31, 98);
            cbxGioiTinh.Name = "cbxGioiTinh";
            cbxGioiTinh.Size = new Size(110, 28);
            cbxGioiTinh.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(31, 20);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 12;
            label3.Text = "Họ Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(31, 78);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 13;
            label4.Text = "Giới Tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(31, 137);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 14;
            label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(31, 192);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 15;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(31, 252);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 16;
            label7.Text = "Phone";
            // 
            // EmployeeForm
            // 
            ClientSize = new Size(484, 521);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbxGioiTinh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMatKhau);
            Controls.Add(txtPhone);
            Controls.Add(txtDiaChi);
            Controls.Add(txtFullName);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm / Sửa Nhân Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        private void CreateLabel(string text, int x, int y)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Location = new System.Drawing.Point(x, y + 5);
            lbl.AutoSize = true;
            this.Controls.Add(lbl);
        }
        private TextBox txtDiaChi;
        private TextBox txtPhone;
        private TextBox txtMatKhau;
        private Label label1;
        private Label label2;
        private ComboBox cbxGioiTinh;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
