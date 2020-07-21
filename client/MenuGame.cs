using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string filePath = "../../../Schedule_Game.txt";
        //string fileSchedulePath = Host.fileSchedulePath;
        private Form currentChildForm;
        int numColumSort = 0;
        int currentColum = -1, currentRow = -1;
        int rowEdit = -1;

        public MenuGame()
        {
            InitializeComponent();
            Utils.getScheduleFromFile(filePath, ref listGameShow);
            grvListGame.DataSource = listGameShow;
            setInforNearestGame();
            lblTitle.Height = (int)(this.Height * 0.1);
            grvListGame.Height = (int)(this.Height * 0.5);
            pnlNearestGame.Height = (int)(this.Height * 0.4);
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
        private void OpenChildForm(Form childForm)
        {
            ////open only form
            //if (currentChildForm != null)
            //{
            //    currentChildForm.Close();
            //}
            //currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Location = new Point(278, 94);
            childForm.Opacity = 0.1;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MenuGame_SizeChanged(object sender, EventArgs e)
        {
            lblTitle.Height = (int)(this.Height * 0.1);
            grvListGame.Height = (int)(this.Height * 0.5);
            pnlNearestGame.Height = (int)(this.Height * 0.4);
        }


        private void btnHow_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HowToPlay());
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
