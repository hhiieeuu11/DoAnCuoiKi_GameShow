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
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {
            InitializeComponent();
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HowToPlay_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
