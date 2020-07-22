using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_SizeChanged(object sender, EventArgs e)
        {
            pnlMain.Location = new Point((this.Width - pnlMain.Width) / 2, (this.Height - pnlMain.Height) / 2);
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
