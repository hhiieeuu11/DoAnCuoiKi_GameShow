using DTOProject.DTO;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NetComm;
using MyLib;

namespace Sever
{
    public partial class Host : Form
    {
       // List<NetComm.Client> listClient = new List<NetComm.Client>();
        public static List<string> listIdPlayer = new List<string>();
        //List<string> usersList = null;

        #region Define
        public static string fileQuestionPath = "../../question.txt";
        public static string fileSchedulePath = "../../../Schedule_Game.txt";
        public static List<Question> listQuestion = new List<Question>();
        public static List<GameShow> listGameShow = new List<GameShow>();


        public static int indexCurrentQuestion = 0;
        public IconButton currentBtn;
        public Panel leftBorderBtn;
        private Form currentChildForm;


        
        public Color activeColor = Color.Cyan;
        //public Color activeColor = Color.FromArgb(199, 0, 57);
        #endregion

        public Host()
        {
            indexCurrentQuestion = 0;

            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 76);
            pnlBtnGroup.Controls.Add(leftBorderBtn);
            activateButton(btnHome, activeColor);
            OpenChildForm(new Home());
        }

        #region Function
        public void activateButton(object sender, Color color)
        {
            if(sender != null)
            {
                disableButton();

                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(28, 28, 28);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = color;
                currentBtn.Padding = new Padding(18, 0, 0, 0);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.BringToFront();
            }
        }

        public void disableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(14,15,28);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.Padding = new Padding(10, 0, 0, 0);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
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
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            disableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        #endregion

        #region Event
        private void btnLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            activateButton(sender, activeColor);
            OpenChildForm(new Home());
        }

        private void btnScheduleMGMT_Click(object sender, EventArgs e)
        {
            activateButton(sender, activeColor);
            OpenChildForm(new ScheduleManagement());
        }

        private void btnQuestionMGMT_Click(object sender, EventArgs e)
        {
            activateButton(sender, activeColor);
            OpenChildForm(new QuestionManagement());
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            activateButton(sender, activeColor);
            OpenChildForm(new AboutUsSV());
        }
        private void btnMC_Click(object sender, EventArgs e)
        {

            activateButton(sender, activeColor);
            Form frmMC = new MC_UI();
            frmMC.Show();
            this.WindowState = FormWindowState.Minimized;
            
        }
        #endregion


        public static void startMC()
        {
            Form frmMC = new MC_UI();
            frmMC.Show();
        }

        public static int findPlayer(string id)
        {
            for(int i = 0; i < Host.listIdPlayer.Count; i++)
            {
                if (Host.listIdPlayer[i] == id) return i;
            }
            return -1;
        }


      // public static void Sen
        



        /// <summary>
        /// Remove player when player outgame
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public  bool playerDisconnect(string id)
        {
            int indexPlayer = Host.findPlayer(id);
            if (indexPlayer > -1)
            {
                //lvListPlayer.Items[indexPlayer].Remove();
                return true;
            }
            return false;
        }

    }
}
