namespace InventoryApp
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up resources.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.rbImport = new System.Windows.Forms.RadioButton();
            this.rbExport = new System.Windows.Forms.RadioButton();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.groupBoxTransactionType = new System.Windows.Forms.GroupBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.lblHistory = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.groupBoxTransactionType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();

            // cbProduct
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(130, 20);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(250, 24);

            // lblProduct
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(20, 23);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(72, 17);
            this.lblProduct.Text = "Sản phẩm:";

            // nudQuantity
            this.nudQuantity.Location = new System.Drawing.Point(130, 60);
            this.nudQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 22);
            this.nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(20, 62);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(96, 17);
            this.lblQuantity.Text = "Số lượng thay đổi:";

            // groupBoxTransactionType
            this.groupBoxTransactionType.Controls.Add(this.rbImport);
            this.groupBoxTransactionType.Controls.Add(this.rbExport);
            this.groupBoxTransactionType.Location = new System.Drawing.Point(20, 100);
            this.groupBoxTransactionType.Name = "groupBoxTransactionType";
            this.groupBoxTransactionType.Size = new System.Drawing.Size(360, 60);
            this.groupBoxTransactionType.Text = "Loại giao dịch";

            // rbImport
            this.rbImport.AutoSize = true;
            this.rbImport.Checked = true;
            this.rbImport.Location = new System.Drawing.Point(20, 25);
            this.rbImport.Name = "rbImport";
            this.rbImport.Size = new System.Drawing.Size(84, 21);
            this.rbImport.Text = "Nhập kho";
            this.rbImport.UseVisualStyleBackColor = true;

            // rbExport
            this.rbExport.AutoSize = true;
            this.rbExport.Location = new System.Drawing.Point(150, 25);
            this.rbExport.Name = "rbExport";
            this.rbExport.Size = new System.Drawing.Size(81, 21);
            this.rbExport.Text = "Xuất kho";
            this.rbExport.UseVisualStyleBackColor = true;

            // lblNote
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(20, 180);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(58, 17);
            this.lblNote.Text = "Ghi chú:";

            // txtNote
            this.txtNote.Location = new System.Drawing.Point(130, 180);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(250, 60);

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(150, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;

            // lblHistory
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(20, 310);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(121, 17);
            this.lblHistory.Text = "Lịch sử giao dịch:";

            // dgvHistory
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(20, 330);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.Size = new System.Drawing.Size(500, 200);

            // InventoryForm
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.groupBoxTransactionType);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.dgvHistory);
            this.Name = "InventoryForm";
            this.Text = "Quản lý Tồn kho";

            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.groupBoxTransactionType.ResumeLayout(false);
            this.groupBoxTransactionType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.RadioButton rbImport;
        private System.Windows.Forms.RadioButton rbExport;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.GroupBox groupBoxTransactionType;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label lblHistory;
    }
}