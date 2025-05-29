namespace InventoryApp
{
    public partial class RevenueReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnViewReport = new Button();
            lblFrom = new Label();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            SuspendLayout();
            // 
            // btnViewReport
            // 
            btnViewReport.BackColor = Color.OrangeRed;
            btnViewReport.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnViewReport.ForeColor = SystemColors.Control;
            btnViewReport.Location = new Point(256, 164);
            btnViewReport.Name = "btnViewReport";
            btnViewReport.Size = new Size(221, 57);
            btnViewReport.TabIndex = 4;
            btnViewReport.Text = "XUẤT EXCEL";
            btnViewReport.UseVisualStyleBackColor = false;
            btnViewReport.Click += btnViewReport_Click;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lblFrom.Location = new Point(75, 60);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(100, 24);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "TỪ NGÀY";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lblTo.Location = new Point(60, 103);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(116, 24);
            lblTo.TabIndex = 1;
            lblTo.Text = "ĐẾN NGÀY";
            // 
            // dtpTo
            // 
            dtpTo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Location = new Point(181, 103);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(296, 29);
            dtpTo.TabIndex = 3;
            // 
            // dtpFrom
            // 
            dtpFrom.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Location = new Point(181, 55);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(296, 29);
            dtpFrom.TabIndex = 5;
            // 
            // RevenueReportForm
            // 
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(553, 260);
            Controls.Add(dtpFrom);
            Controls.Add(lblFrom);
            Controls.Add(lblTo);
            Controls.Add(dtpTo);
            Controls.Add(btnViewReport);
            Name = "RevenueReportForm";
            Text = "Báo cáo";
            ResumeLayout(false);
            PerformLayout();
        }
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
    }
}
