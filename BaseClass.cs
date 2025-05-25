using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    public class BaseForm : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Text = "Inventory App";
            this.CenterToScreen();
        }
    }
}
