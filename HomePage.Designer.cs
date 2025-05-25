namespace InventoryApp
{
    partial class HomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            label2 = new Label();
            label1 = new Label();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            cuiChartLine1 = new CuoreUI.Controls.Charts.cuiChartLine();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            cuiPanel1.SuspendLayout();
            cuiPanel2.SuspendLayout();
            cuiPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Location = new Point(21, 22);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(255, 106, 0);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(255, 106, 0);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(290, 106);
            cuiPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(14, 52);
            label2.Name = "label2";
            label2.Size = new Size(241, 37);
            label2.TabIndex = 1;
            label2.Text = "100,000,000 VNĐ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(14, 10);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 0;
            label1.Text = "Tổng Doanh Thu";
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(label3);
            cuiPanel2.Controls.Add(label5);
            cuiPanel2.Location = new Point(327, 22);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(255, 106, 0);
            cuiPanel2.PanelOutlineColor = Color.FromArgb(255, 106, 0);
            cuiPanel2.Rounding = new Padding(8);
            cuiPanel2.Size = new Size(225, 106);
            cuiPanel2.TabIndex = 1;
            // 
            // cuiPanel3
            // 
            cuiPanel3.Controls.Add(label4);
            cuiPanel3.Controls.Add(label6);
            cuiPanel3.Location = new Point(571, 22);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.FromArgb(255, 106, 0);
            cuiPanel3.PanelOutlineColor = Color.FromArgb(255, 106, 0);
            cuiPanel3.Rounding = new Padding(8);
            cuiPanel3.Size = new Size(236, 106);
            cuiPanel3.TabIndex = 2;
            // 
            // cuiChartLine1
            // 
            cuiChartLine1.AutoMaxValue = false;
            cuiChartLine1.AxisColor = Color.Gray;
            cuiChartLine1.ChartLineColor = Color.FromArgb(255, 106, 0);
            cuiChartLine1.ChartPadding = 40;
            cuiChartLine1.DataPoints = new float[]
    {
    100F,
    90F,
    80F,
    75F,
    70F,
    65F,
    60F
    };
            cuiChartLine1.DayColor = Color.DarkGray;
            cuiChartLine1.Font = new Font("Microsoft YaHei UI", 8.25F);
            cuiChartLine1.GradientBackground = true;
            cuiChartLine1.Location = new Point(21, 148);
            cuiChartLine1.Margin = new Padding(4, 3, 4, 3);
            cuiChartLine1.MaxValue = 100F;
            cuiChartLine1.Name = "cuiChartLine1";
            cuiChartLine1.PointColor = Color.FromArgb(255, 106, 0);
            cuiChartLine1.ShortDates = true;
            cuiChartLine1.Size = new Size(764, 411);
            cuiChartLine1.TabIndex = 3;
            cuiChartLine1.UseBezier = false;
            cuiChartLine1.UsePercent = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(15, 10);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 2;
            label5.Text = "Tổng Đơn Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(15, 52);
            label3.Name = "label3";
            label3.Size = new Size(97, 37);
            label3.TabIndex = 2;
            label3.Text = "43534";
            label3.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(20, 10);
            label6.Name = "label6";
            label6.Size = new Size(173, 25);
            label6.TabIndex = 3;
            label6.Text = "Tổng Lượng Khách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(20, 52);
            label4.Name = "label4";
            label4.Size = new Size(97, 37);
            label4.TabIndex = 3;
            label4.Text = "98865";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(cuiChartLine1);
            Controls.Add(cuiPanel3);
            Controls.Add(cuiPanel2);
            Controls.Add(cuiPanel1);
            Name = "HomePage";
            Size = new Size(979, 589);
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            cuiPanel2.ResumeLayout(false);
            cuiPanel2.PerformLayout();
            cuiPanel3.ResumeLayout(false);
            cuiPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private Label label2;
        private Label label1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private CuoreUI.Controls.Charts.cuiChartLine cuiChartLine1;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
    }
}
