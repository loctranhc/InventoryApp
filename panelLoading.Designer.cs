﻿namespace InventoryApp
{
    partial class panelLoading
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.loading;
            pictureBox1.Location = new Point(213, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 41);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelLoading
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(pictureBox1);
            Name = "panelLoading";
            Size = new Size(582, 433);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiCircleProgressBar cuiCircleProgressBar1;
        private PictureBox pictureBox1;
    }
}
