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
    public partial class IsBroadcasting : Form
    {
        #region DEFINE
        int OrigTime;
        #endregion

        public IsBroadcasting()
        {
            InitializeComponent();
            GameShow gameIsBroadcasting = Utils.findGameIsBroadcasting(Host.listGameShow);
            setInforNearestGame(gameIsBroadcasting);
        }

        #region FUNCTION
        /// <summary>
        /// Calculate the time distance with the nearest game
        /// </summary>
        /// <param name="game">The game is broadcasting</param>
        /// <returns></returns>
        public int calcEndTime(GameShow game)
        {
            return (int)(game.EndTime.Subtract(DateTime.Now).TotalSeconds);

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
                OrigTime = calcEndTime(game);

                //Turn on Timer Countdown
                tmrCountDown.Enabled = true;
                lblGameID.Text = game.ID;
                lblGameName.Text = game.Name;
                lblStartTime.Text = game.StartTime.ToString();
            }

        }
        #endregion

        #region EVENT
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
                }
            }
        }
        #endregion
    }
}
