using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Winner : Form
    {


        #region EVENT
        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Winner_SizeChanged(object sender, EventArgs e)
        {
            pnlRank.Location = new Point((this.Width - pnlRank.Width) / 2, (this.Height - pnlRank.Height) / 2);
        }
        #endregion
        public Winner()
        {
            InitializeComponent();
        }
        #region FUNCTION
        public Winner(string top1, string top2, string top3)
        {
            InitializeComponent();
            lblTop1.Text = top1;
            lblTop2.Text = top2;
            lblTop3.Text = top3;
        }
        #endregion

    }
}
