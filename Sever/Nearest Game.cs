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
    public partial class Nearest_Game : Form
    {
        #region DEFINE
        string filePath = Host.fileSchedulePath;
        int OrigTime;
        public static bool mcHasStarted = false;
        #endregion
        public Nearest_Game()
        {
            InitializeComponent();
            GameShow nearestGame = Utils.findNearestGame(Host.listGameShow);
            nearestGame = Utils.findNearestGame(Host.listGameShow);
            setInforNearestGame(nearestGame);

        }

        #region FUNCTION
        /// <summary>
        /// Calculate the time distance with the nearest game
        /// </summary>
        /// <param name="nearestGame"></param>
        /// <returns></returns>
        public int calcWaitingTime(GameShow nearestGame)
        {
            return (int)(nearestGame.StartTime.Subtract(DateTime.Now).TotalSeconds);

        }

        public void setInforNearestGame(GameShow game)
        {
            if (game == null)
            {
                lblGameID.Text = "There are no future games";
                lblGameID.ForeColor = Color.Red;
                lblStartTime.Text = "";
                lblCountDown.Text = "";
                lblGameName.Text = "";
            }
            else
            {
                //Set countdown time when game show != null
                OrigTime = calcWaitingTime(game);

                //Turn on Timer Countdown
                tmrCountDown.Enabled = true;
                lblGameID.Text = game.ID;
                lblGameName.Text = game.Name;
                lblStartTime.Text = game.StartTime.ToString();
            }

        }

        /// <summary>
        /// Reset information for the nearest game when the previous game has started
        /// </summary>
        public void resetInforNearestGame()
        {
            GameShow nearestGame = Utils.findNearestGame(Host.listGameShow);
            setInforNearestGame(nearestGame);
        }
        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            OrigTime--;
            lblCountDown.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            if (OrigTime <= 10)
            {
                lblCountDown.ForeColor = Color.Red;
                if (OrigTime <= 0)
                {
                    tmrCountDown.Enabled = false;

                    if (!mcHasStarted)  //If Form MC_UI has started, program won't start one more MC_UI
                    {
                        Host.startMC();
                    }
                    resetInforNearestGame();
                }
            }
        }
        #endregion
    }
}
