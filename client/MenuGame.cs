using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOProject.DTO;
using MyLib;


namespace client
{
    public partial class MenuGame : Form
    {
        List<GameShow> listGameShow = new List<GameShow>();
        string path = "../../../Schedule_Game.txt";
        public MenuGame()
        {
            InitializeComponent();
            Utils.getScheduleFromFile(path,ref listGameShow);
            grvListGame.DataSource = listGameShow;
            setInforNearestGame();
            lblTitle.Height = (int)(this.Height * 0.1);
            grvListGame.Height = (int)(this.Height * 0.5);
            pnlNearestGame.Height = (int)(this.Height * 0.4);
        }

        public void setInforNearestGame()
        {
            GameShow nearestGame = Utils.findNearestGame(listGameShow);
            if (nearestGame == null)
            {
                lblGameID.Text = "Hiện không có game nào phát sóng trong thời gian tới";
                lblGameTime.Text = "";
                lblCountDown.Text = "";
                lblGameName.Text = "";
            }
            else
            {
                lblGameID.Text = nearestGame.ID;
                lblGameTime.Text = nearestGame.StartTime.ToString();
                lblGameName.Text = nearestGame.Name;
            }
        }

        private void MenuGame_SizeChanged(object sender, EventArgs e)
        {
            lblTitle.Height = (int)(this.Height * 0.1);
            grvListGame.Height = (int)(this.Height * 0.5);
            pnlNearestGame.Height = (int)(this.Height * 0.4);
        }
    }
}
