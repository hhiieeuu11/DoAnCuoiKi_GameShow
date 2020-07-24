using DTOProject.DTO;
using MyLib;
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

namespace Sever
{
    public partial class MC_UI : Form
    {
        int OrigTime = 15;

        NetComm.Host server; //Creates the host variable object
        


        Color colorAnswerCorrect = Color.FromArgb(0, 192, 0);
        List <Question> listQuestion = new List<Question>();
        string filePath = "../../question.txt";

        public MC_UI()
        {
            InitializeComponent();
            reponsive();
            listQuestion = getListQuestionFromFile();
            setupQuestion(listQuestion[Host.indexCurrentQuestion]);
            Nearest_Game.mcHasStarted = true;
        }

        #region Code Old

        /// <summary>
        /// Get Data question from file question.txt
        /// </summary>
        /// <returns></returns>
        public List<Question> getListQuestionFromFile() 
        {
            List<Question> listQuestion = new List<Question>();
            StreamReader sr = new StreamReader(filePath);
            string line = null;
            Question question = null;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("!"))
                {
                    question = new Question();
                    question.Id = line.Substring(1);
                }
                else if (line.StartsWith("@"))
                {
                    question.Content = line.Substring(1);
                }
                else if (line.StartsWith("&"))
                {
                    question.listAnswer.Add(line.Substring(1));
                }
                else if (line.StartsWith("#"))
                {
                    question.AnswerCorrect = line.Substring(1);
                }
                else if (line.StartsWith("$"))
                {
                    question.TopicInfor = line.Substring(1);
                    listQuestion.Add(question);
                }
            }

            grvListQuestion.DataSource = listQuestion;
            sr.Close();
            return listQuestion;
        }

        /// <summary>
        /// Reponsive screen
        /// </summary>
        public void reponsive()
        {
            //panel Parent
            pnlRight.Width = (int)(this.Width * 0.3); 
            pnlLeft.Width = this.Width - pnlRight.Width;

            //panel chirld 1
            pnlRightTop.Height = (int)(this.Height * 0.48); //panel list question
            pnlRightBottom.Height = (int)(this.Height * 0.52);  //panel Rank

            pnlLeftTop.Height = (int)(this.Height * 0.44); //Camera and Topic information of question
            pnlCamera.Width = (int)(pnlLeftTop.Width * 0.5);

            //Setup localtion of pnlContainsQuestion
            int newLocalX = pnlLeft.Width - pnlContainsQuestion.Width;
            pnlContainsQuestion.Location = new Point(newLocalX / 2, pnlContainsQuestion.Location.Y);
            
            
        }

        /// <summary>
        /// Set up question into controls
        /// </summary>
        /// <param name="question"></param>
        public void setupQuestion(Question question)
        {
            int indexAnswer = 0;
            lblQuestion.Text = "Question " + question.Id + ": " + question.Content;
            lblTopicInfor.Text = question.TopicInfor;
            for(int i = 0; i < 4; i++)
            {
                Label lbl = (Label)pnlAnswerGroup.Controls[i+4];
                lbl.Text = question.listAnswer[indexAnswer++];
            }
        }

        public void showAnswerCorrect(Question question)
        {
            foreach(Control ctl in pnlAnswerGroup.Controls)
            {
                Label lbl = (Label)ctl; 
                if(lbl.Text == question.AnswerCorrect)
                {
                    lbl.BackColor = colorAnswerCorrect;
                    
                }
            }
        }

        public void resetClock()
        {
            OrigTime = 15;
            proCountDown.Value = 0;
            lblCountDown.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
        }

        public void resetColorAnswers()
        {
            foreach (Control ctl in pnlAnswerGroup.Controls)
            {
                Label lbl = (Label)ctl;
                lbl.BackColor = Color.FromArgb(0, 192, 192);
            }
        }


        private void MC_UI_SizeChanged(object sender, EventArgs e)
        {
            reponsive();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            resetClock();
            resetColorAnswers();
            if (Host.indexCurrentQuestion < listQuestion.Count-1)
            {
                Host.indexCurrentQuestion++;
                setupQuestion(listQuestion[Host.indexCurrentQuestion]);
            }
            else
                MessageBox.Show("You have run out of questions!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnNext.Enabled = false;
            btnSend.Enabled = true;
        }

        private void CountDown_Tick(object sender, EventArgs e)
        {            
            OrigTime--;
            lblCountDown.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            proCountDown.Value++;
            if (OrigTime <= 0)
            {
                tmrCountDown.Enabled = false;
                showAnswerCorrect(listQuestion[Host.indexCurrentQuestion]);
                btnNext.Enabled = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            tmrCountDown.Enabled = true;
            btnSend.Enabled = false;
            btnNext.Enabled = false;
            server.Brodcast(Utils.ObjectToByteArray(listQuestion[Host.indexCurrentQuestion]));
        }


        #endregion
        private void MC_UI_Load(object sender, EventArgs e)
        {
            server = new NetComm.Host(5000);    //Initialize the Server object, 
                                                //connection will use the 2020 port number
            server.StartConnection(); 		//Starts listening for incoming clients

            server.onConnection += new NetComm.Host.onConnectionEventHandler(server_onConnection);
            server.lostConnection += new NetComm.Host.lostConnectionEventHandler(Server_lostConnection);
            server.DataReceived += new NetComm.Host.DataReceivedEventHandler(Server_DataReceived);


            //Speeding up the connection
            server.SendBufferSize = 400;
            server.ReceiveBufferSize = 50;
            server.NoDelay = true;
        }

        public void server_onConnection(string id)
        {
            //listIdPlayer.Add(id);
            // MessageBox.Show(id + " connected!");
           // listIdPlayer = server.Users;
            lvListPlayer.Items.Add(id);
        }

        public static int findPlayer(string id)
        {
            for (int i = 0; i < Host.listIdPlayer.Count; i++)
            {
                if (Host.listIdPlayer[i] == id) return i;
            }
            return -1;
        }
        void Server_lostConnection(string id)
        {
            //lvListPlayer.Items.Remove(lvListPlayer.Items[findPlayer(id)]);
        }

        void Server_DataReceived(string ID, byte[] Data)
        {
            lvListPlayer.Items.Add(ID + (string)Utils.ByteArrayToObject(Data));
        }

        private void MC_UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Nearest_Game.mcHasStarted = false;
            server.CloseConnection(); //Closes all of the opened connections and stops listening

        }
    }
}
