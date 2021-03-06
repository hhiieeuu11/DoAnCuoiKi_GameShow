﻿using System;
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
    public partial class Scores : Form
    {
        #region FUNCTION
        public Scores(Dictionary<string, int> listScores)
        {
            InitializeComponent();
            foreach (var player in listScores)
            {
                ListViewItem item = new ListViewItem();
                item.Text = player.Key;
                item.SubItems.Add(player.Value.ToString());
                lvScores.Items.Add(item);
            }
        }
        #endregion
        #region EVENT
        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        public Scores()
        {
            InitializeComponent();
        }
    }
}
