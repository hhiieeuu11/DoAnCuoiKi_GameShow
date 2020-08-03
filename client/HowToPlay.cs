﻿using System;
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
        #region EVENT
        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HowToPlay_SizeChanged(object sender, EventArgs e)
        {
            pnlHow.Location = new Point((this.Width - pnlHow.Width) / 2, (this.Height - pnlHow.Height) / 2);
        }
        #endregion
        public HowToPlay()
        {
            InitializeComponent();
        }
    }
}
