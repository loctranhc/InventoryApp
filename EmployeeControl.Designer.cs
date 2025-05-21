namespace InventoryApp
{
    partial class EmployeeControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnAdd, btnEdit, btnDelete;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();

            // panelButtons
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Height = 40;
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.panelButtons.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);

            // btnAdd
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Width = 80;
            this.btnAdd.Click += btnAdd_Click;

            // btnEdit
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Width = 80;
            this.btnEdit.Click += btnEdit_Click;

            // btnDelete
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Width = 80;
            this.btnDelete.Click += btnDelete_Click;

            // panelButtons Add
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnEdit);
            this.panelButtons.Controls.Add(this.btnDelete);

            // dgvEmployees
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.ReadOnly = true;

            // EmployeeControl
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.panelButtons);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(600, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
