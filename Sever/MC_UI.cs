using client;
using DTOProject.DTO;
using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sever
{
    public partial class MC_UI : Form
    {

        const int TIME_COUNT_DOWN = 15;
        const int NUMBER_QUESTION = 2;

        int OrigTime = TIME_COUNT_DOWN;  //Time countdown
        int numQuestionPlayed;  //Count of question played
        NetComm.Host server; //Creates the host variable object
        Color colorAnswerCorrect = Color.FromArgb(0, 192, 0);
        List <Question> listQuestion = new List<Question>();
        int indexCurrentQuestion = 0;
        Question currentQuestion;
        string filePath = "../../question.txt";
        DataChart statisticalData;  //Statistical data of the player's answer to each question
        Dictionary<string, int> listScores = new Dictionary<string, int>();

        Form currentChildForm = null;


        public MC_UI()
        {
          
            InitializeComponent();
            reponsive();
            numQuestionPlayed = 0;
            Nearest_Game.mcHasStarted = true; 
            listQuestion = getListQuestionFromFile();
            currentQuestion = listQuestion[indexCurrentQuestion];
            setupQuestion(currentQuestion);
            statisticalData = new DataChart();
            updateChart(statisticalData);
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

            if (currentChildForm != null) currentChildForm.Size = this.Size;


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
            if (indexCurrentQuestion < NUMBER_QUESTION - 1)
            {
                indexCurrentQuestion++;
                currentQuestion = listQuestion[indexCurrentQuestion];
                setupQuestion(currentQuestion);
            }
            else
            {
                MessageBox.Show("You have run out of questions!Do you want show final results", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showWinner(listScores);
                server.Brodcast(Utils.ObjectToByteArray("EndGame"));
                btnSendQuestion.Enabled = false;
            }
            btnNext.Enabled = false;
            btnSendQuestion.Enabled = true;
        }

        public void showWinner(Dictionary<string, int> listScores)
        {
            if (listScores.Count < 1)
                OpenChildForm(new Winner("", "", ""));
            if (listScores.Count == 1)
                OpenChildForm(new Winner(listScores.Keys.ElementAt(0),"", ""));
            if (listScores.Count == 2)
                OpenChildForm(new Winner(listScores.Keys.ElementAt(0), listScores.Keys.ElementAt(1), ""));
            if (listScores.Count > 2)
                OpenChildForm(new Winner(listScores.Keys.ElementAt(0), listScores.Keys.ElementAt(1), listScores.Keys.ElementAt(2)));
        }

        private void CountDown_Tick(object sender, EventArgs e)
        {            
            OrigTime--;
            lblCountDown.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            proCountDown.Value++;
            if (OrigTime <= 0)
            {
                tmrCountDown.Enabled = false;
                sendCorrectAnswer(indexCurrentQuestion);
                showAnswerCorrect(currentQuestion);
                btnNext.Enabled = true;
                sendListScores(listScores);
            }
        }

        private void btnSendQuestion_Click(object sender, EventArgs e)
        {
            if (server.Users.Count == 0)
            {
                MessageBox.Show("Haven't player at present!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                numQuestionPlayed++;
                statisticalData.refesh();
                updateChart(statisticalData);

                btnSendQuestion.Enabled = false;
                btnNext.Enabled = false;
            
                tmrCountDown.Enabled = true;
                Question question = new Question
                {
                    Id = currentQuestion.Id,
                    listAnswer = currentQuestion.listAnswer,
                    Content = currentQuestion.Content
                }; //Create new question with Correct answer is null;
                server.Brodcast(Utils.ObjectToByteArray(question));
                server.Brodcast(Utils.ObjectToByteArray(statisticalData));
            }
            
        }


        #endregion
        private void MC_UI_Load(object sender, EventArgs e)
        {


            axVideoChatSender1.VideoDevice = 0;
            axVideoChatSender1.AudioDevice = 0;
            axVideoChatSender1.VideoFormat = 0;
            axVideoChatSender1.FrameRate = 15;
            axVideoChatSender1.VideoBitrate = 128000;
            axVideoChatSender1.AudioComplexity = 0;
            axVideoChatSender1.AudioQuality = 8;
            axVideoChatSender1.SendAudioStream = true;
            axVideoChatSender1.SendVideoStream = true;

            axVideoChatSender1.Connect("localhost", 1333);
            axVideoChatSender1.ConferenceNumber = 50;
            axVideoChatSender1.ConferenceUserID = 3000;

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
            listScores.Add(id, 0);
            sendListScores(listScores);
            npwBox.Number = server.Users.Count;
            sendNumberPlayer(server.Users.Count);
            //lvScores.up
        }



        void Server_lostConnection(string id)
        {
            listScores.Remove(id);
            npwBox.Number = server.Users.Count;
            sendNumberPlayer(server.Users.Count);
        }

        void Server_DataReceived(string ID, byte[] Data)
        {
            var data = (string)Utils.ByteArrayToObject(Data);
            updateDataChart(data, statisticalData);
            updateChart(statisticalData);
            server.Brodcast(Utils.ObjectToByteArray(statisticalData)); //Send Statistical data of the player's 
                                                                       //answer to each question 
            Utils.updateListScores(data, ID, currentQuestion, listScores);
            listScores = Utils.Rank(listScores);
        }



        private void MC_UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Nearest_Game.mcHasStarted = false;
            server.CloseConnection(); //Closes all of the opened connections and stops listening

        }



        public void sendNumberPlayer(int count)
        {
            server.Brodcast(Utils.ObjectToByteArray(count.ToString()));
        }
        private void sendListScores(Dictionary<string, int> listScores)
        {
            listScores = Utils.Rank(listScores);
            server.Brodcast(Utils.ObjectToByteArray(listScores));
        }
        public void updateDataChart(string vote, DataChart dataChart)
        {
            switch (vote)
            {
                case "A":
                    dataChart.CountA++;
                    break;
                case "B":
                    dataChart.CountB++;
                    break;
                case "C":
                    dataChart.CountC++;
                    break;
                default:
                    dataChart.CountD++;
                    break;
            }
        }

        /// <summary>
        /// Update data chart 
        /// </summary>
        /// <param name="countA">Number of people choosing answers A</param>
        /// <param name="countB">Number of people choosing answers B</param>
        /// <param name="countC">Number of people choosing answers C</param>
        /// <param name="countD">Number of people choosing answers D</param>
        public void updateChart(DataChart dataChart)
        {
            if (chartCountPlayerAnswer.Series["numberOfPlayerChoose"].Points.Count != 0)
            {
                chartCountPlayerAnswer.Series["numberOfPlayerChoose"].Points.Clear();
            }
            chartCountPlayerAnswer.Series["numberOfPlayerChoose"].Points.AddXY("A", dataChart.CountA);
            chartCountPlayerAnswer.Series["numberOfPlayerChoose"].Points.AddXY("B", dataChart.CountB);
            chartCountPlayerAnswer.Series["numberOfPlayerChoose"].Points.AddXY("C", dataChart.CountC);
            chartCountPlayerAnswer.Series["numberOfPlayerChoose"].Points.AddXY("D", dataChart.CountD);
        }

        public void sendCorrectAnswer(int indexQuestion)
        {
            AnswerCorrect answerCorrect = new AnswerCorrect();
            answerCorrect.Content = listQuestion[indexQuestion].AnswerCorrect;
            server.Brodcast(Utils.ObjectToByteArray(answerCorrect));
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
            childForm.Width = this.Width;
            childForm.Height = this.Height;
            childForm.Location = new Point(0, 0);
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            listScores = Utils.Rank(listScores);
            Form frmScores = new Scores(listScores);
            frmScores.ShowDialog();
        }


    }
}
