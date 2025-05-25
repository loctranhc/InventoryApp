namespace InventoryApp
{
    partial class ProgressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar1 = new ProgressBar();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 11);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(267, 23);
            progressBar1.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(11, 38);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(86, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Đang đọc file...";
            // 
            // ProgressForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 68);
            Controls.Add(lblStatus);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProgressForm";
            Text = "Đang Nhập Hàng";
            Load += ProgressForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label lblStatus;
    }
}