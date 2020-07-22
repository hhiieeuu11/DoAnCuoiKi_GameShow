﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DTOProject.DTO;
using MyLib;


namespace client
{
    public partial class MenuGame : Form
    {
        List<GameShow> listGameShow = new List<GameShow>();
        string filePath = "../../../Schedule_Game.txt";

        int numColumSort = 0;
        int currentColum = -1, currentRow = -1;
        int countDownTime;

        public MenuGame()
        {
            InitializeComponent();
            Utils.getScheduleFromFile(filePath, ref listGameShow);
            grvListGame.DataSource = listGameShow;
            setInforNearestGame();
            reponsive();
        }
        public List<GameShow> getScheduleFromFile(string pathFile, int numColumSort)
        {
            StreamReader sr = new StreamReader(pathFile);
            List<GameShow> listGameShow = new List<GameShow>();
            string line = null;
            GameShow game = null;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("!"))
                {
                    game = new GameShow();
                    game.ID = line.Substring(1);
                }
                else if (line.StartsWith("@"))
                {
                    game.Name = line.Substring(1);
                }
                else if (line.StartsWith("#"))
                {
                    game.StartTime = DateTime.Parse(line.Substring(1));
                }
                else if (line.StartsWith("$"))
                {
                    game.EndTime = DateTime.Parse(line.Substring(1));
                }
                else if (line.StartsWith("%"))
                {
                    game.NumberPlayer = int.Parse(line.Substring(1));
                    listGameShow.Add(game);
                }
            }
            Utils.sortSchedule(listGameShow, numColumSort);
            grvListGame.DataSource = listGameShow;
            sr.Close();
            return listGameShow;


        }
        public void setInforNearestGame()
        {
            GameShow nearestGame = Utils.findNearestGame(listGameShow);
            if (nearestGame == null)
            {
                lblGameID.Text = "Hiện không có game nào phát sóng trong thời gian tới";
                lblStartTime.Text = "";
                lblCountDown.Text = "";
                lblGameName.Text = "";
            }
            else
            {
                lblGameID.Text = nearestGame.ID;
                lblStartTime.Text = nearestGame.StartTime.ToString();
                lblGameName.Text = nearestGame.Name;
                countDownTime = Utils.calcWaitingTime(nearestGame);// get countdown time
                tmrCountDown.Enabled = true;

            }
        }
        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Width = this.Width;
            childForm.Height = this.Height;
            childForm.Location = new Point(0, 0);
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void reponsive()
        {
            lblTitle.Height = (int)(this.Height * 0.1);
            grvListGame.Height = (int)(this.Height * 0.48);
            pnlNearestGame.Height = (int)(this.Height * 0.42);
            pnlMenu.Width = (int)(this.Width * 0.42);
            pnlLeft.Width = (int)(this.Width * 0.48);
            pnlMenuControls.Location = new Point((pnlMenu.Width - pnlMenuControls.Width) / 2, (pnlMenu.Height - pnlMenuControls.Height) / 2);
        }

        private void MenuGame_SizeChanged(object sender, EventArgs e)
        {
            reponsive();
        }


        private void btnHow_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HowToPlay());
        }

        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            countDownTime--;
            lblTimeEnterGame.Text = lblCountDown.Text = countDownTime / 60 + ":" + ((countDownTime % 60) >= 10 ? (countDownTime % 60).ToString() : "0" + countDownTime % 60);
            
            if (countDownTime <= 10)
            {
                lblTimeEnterGame.ForeColor = lblCountDown.ForeColor = Color.Red;
                if (countDownTime <= 0)
                {
                    tmrCountDown.Enabled = false;
                }
            }
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AboutUs());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Playgame());
        }

        private void grvListGame_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            //
            currentColum = e.ColumnIndex;
            currentRow = e.RowIndex;
            // click the first cell of the ID column
            if (currentRow == -1 && currentColum == 0)
            {
                numColumSort = 0;
                getScheduleFromFile(filePath, numColumSort);
            }
            // click the first cell of the Name column
            else if (currentRow == -1 && currentColum == 1)
            {
                numColumSort = 1;
                getScheduleFromFile(filePath, numColumSort);
            }
            // click the first cell of the StartTime column
            else if (currentRow == -1 && currentColum == 2)
            {
                numColumSort = 2;
                getScheduleFromFile(filePath, numColumSort);
            }
            // click the first cell of the EndTime column
            else if (currentRow == -1 && currentColum == 3)
            {
                numColumSort = 3;
                getScheduleFromFile(filePath, numColumSort);
            }
            // click the first cell of the NumberPlayer column
            else if (currentRow == -1 && currentColum == 4)
            {
                numColumSort = 4;
                getScheduleFromFile(filePath, numColumSort);
            }


        }
    }
}
