using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryApp
{
    public partial class ProgressForm : BaseForm
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        public void UpdateProgress(int current, int total)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateProgress(current, total)));
                return;
            }

            progressBar1.Maximum = total;
            progressBar1.Value = current;
            lblStatus.Text = $"Đang xử lý {current}/{total}";
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
