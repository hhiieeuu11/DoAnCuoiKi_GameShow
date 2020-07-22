using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sever
{
    public partial class AboutUsSV : Form
    {
        public AboutUsSV()
        {
            InitializeComponent();
        }
        private void AboutUsSV_SizeChanged(object sender, EventArgs e)
        {
            pnlGrCard.Location = new Point((pnlContent.Width - pnlGrCard.Width) / 2, pnlGrCard.Location.Y);
        }
    }
}
