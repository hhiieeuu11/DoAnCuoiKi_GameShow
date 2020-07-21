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
    public partial class Playgame : Form
    {
        public Playgame()
        {
            InitializeComponent();
            pnlLeft.Width = this.Width - pnlRight.Width;
        }

        private void Playgame_ClientSizeChanged(object sender, EventArgs e)
        {
            pnlLeft.Width = this.Width - pnlRight.Width;
        }

        private void btnAnswerA_Click(object sender, EventArgs e)
        {

        }
    }
}
