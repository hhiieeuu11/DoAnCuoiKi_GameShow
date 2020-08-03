using DTOProject.DTO;
using MyLib;
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

    public partial class Home : Form
    {
        #region FUNCTION
        public Home()
        {

            InitializeComponent();
            Utils.getScheduleFromFile(filePath, ref Host.listGameShow);
            //grvSchedule.DataSource = listGameShow;
            cboFillGame.SelectedIndex = 0;
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlFillGame.Controls.Add(childForm);
            pnlFillGame.Tag = childForm;
            childForm.Location = new Point(0, 0);
            childForm.BringToFront();
            childForm.Show();

        }

        #endregion

        #region EVENT

        private void cboFillGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFillGame.SelectedIndex == 0)
            {
                OpenChildForm(new Nearest_Game());
            }
            else OpenChildForm(new IsBroadcasting());
        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
            pnlFillGame.Location = new Point((pnlBottom.Width - pnlFillGame.Width) / 2, (pnlBottom.Height - pnlFillGame.Height) / 2);
        }
        #endregion

        // List<GameShow> listGameShow = new List<GameShow>();
        string filePath = "../../../Schedule_Game.txt";
        private Form currentChildForm;


    }
}
