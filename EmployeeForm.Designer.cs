using System.Windows.Forms;

namespace InventoryApp
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtFullName, txtUsername, txtEmail;
        private ComboBox cbRole;
        private Button btnSave, btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFullName = new TextBox();
            this.txtUsername = new TextBox();
            this.txtEmail = new TextBox();
            this.cbRole = new ComboBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();

            this.SuspendLayout();

            // Label và textbox cho Họ tên
            CreateLabel("Họ và tên:", 20, 20);
            txtFullName.Location = new System.Drawing.Point(120, 20);
            txtFullName.Width = 200;

            // Username
            CreateLabel("Tên đăng nhập:", 20, 60);
            txtUsername.Location = new System.Drawing.Point(120, 60);
            txtUsername.Width = 200;

            // Email
            CreateLabel("Email:", 20, 100);
            txtEmail.Location = new System.Drawing.Point(120, 100);
            txtEmail.Width = 200;

            // Vai trò
            CreateLabel("Vai trò:", 20, 140);
            cbRole.Location = new System.Drawing.Point(120, 140);
            cbRole.Width = 200;
            cbRole.Items.AddRange(new object[] { "Quản trị", "Nhân viên" });
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;

            // Nút Lưu
            btnSave.Text = "Lưu";
            btnSave.Location = new System.Drawing.Point(120, 190);
            btnSave.Click += btnSave_Click;

            // Nút Hủy
            btnCancel.Text = "Hủy";
            btnCancel.Location = new System.Drawing.Point(210, 190);
            btnCancel.Click += btnCancel_Click;

            // Form
            this.ClientSize = new System.Drawing.Size(360, 250);
            this.Controls.AddRange(new Control[]
            {
                txtFullName, txtUsername, txtEmail, cbRole, btnSave, btnCancel
            });
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.Text = "Thêm / Sửa Nhân Viên";

            this.ResumeLayout(false);
        }

        private void CreateLabel(string text, int x, int y)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Location = new System.Drawing.Point(x, y + 5);
            lbl.AutoSize = true;
            this.Controls.Add(lbl);
        }
    }
}
