namespace InventoryApp
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblName = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            cbxGioiTinh = new ComboBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(49, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(46, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Họ tên:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(16, 79);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(79, 15);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Số điện thoại:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(49, 115);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(46, 15);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Địa chỉ:";
            // 
            // txtName
            // 
            txtName.Location = new Point(101, 18);
            txtName.Name = "txtName";
            txtName.Size = new Size(573, 23);
            txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(101, 76);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(573, 23);
            txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(101, 112);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(573, 23);
            txtAddress.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(508, 153);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(599, 153);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 50);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 10;
            label1.Text = "Giới tính:";
            // 
            // cbxGioiTinh
            // 
            cbxGioiTinh.FormattingEnabled = true;
            cbxGioiTinh.Location = new Point(101, 47);
            cbxGioiTinh.Name = "cbxGioiTinh";
            cbxGioiTinh.Size = new Size(573, 23);
            cbxGioiTinh.TabIndex = 11;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 199);
            Controls.Add(cbxGioiTinh);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm / Sửa Khách hàng";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private ComboBox cbxGioiTinh;
    }
}
