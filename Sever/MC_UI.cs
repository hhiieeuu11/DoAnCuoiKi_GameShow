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
using System.Threading;
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
        DataChart statisticalData;  //Statistical data of the player's answer to each question



        public MC_UI()
        {
            InitializeComponent();
            reponsive();
            listQuestion = getListQuestionFromFile();
            setupQuestion(listQuestion[Host.indexCurrentQuestion]);
            Nearest_Game.mcHasStarted = true;
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
            btnSendQuestion.Enabled = true;
        }

        private void CountDown_Tick(object sender, EventArgs e)
        {            
            OrigTime--;
            lblCountDown.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            proCountDown.Value++;
            if (OrigTime <= 0)
            {
                tmrCountDown.Enabled = false;
                sendCorrectAnswer(Host.indexCurrentQuestion);
                showAnswerCorrect(listQuestion[Host.indexCurrentQuestion]);
                btnNext.Enabled = true;
            }
        }

        private void btnSendQuestion_Click(object sender, EventArgs e)
        {
            tmrCountDown.Enabled = true;
            btnSendQuestion.Enabled = false;
            btnNext.Enabled = false;

            statisticalData.refesh();
            updateChart(statisticalData);

            Question question = new Question
            {
                Id = listQuestion[Host.indexCurrentQuestion].Id,
                listAnswer = listQuestion[Host.indexCurrentQuestion].listAnswer,
                Content = listQuestion[Host.indexCurrentQuestion].Content
            }; //Create new question with Correct answer is null;
            server.Brodcast(Utils.ObjectToByteArray(question));
            server.Brodcast(Utils.ObjectToByteArray(statisticalData));
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
            lvListPlayer.Items.Remove(lvListPlayer.FindItemWithText(id));            
        }

        void Server_DataReceived(string ID, byte[] Data)
        {
            var data = (string)Utils.ByteArrayToObject(Data);
            lvListPlayer.Items.Add(ID + (string)Utils.ByteArrayToObject(Data));
            updateDataChart(data, statisticalData);
            updateChart(statisticalData);
            server.Brodcast(Utils.ObjectToByteArray(statisticalData)); //Send Statistical data of the player's 
                                                                        //answer to each question 
        }

        private void MC_UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Nearest_Game.mcHasStarted = false;
            server.CloseConnection(); //Closes all of the opened connections and stops listening

        }

        private void btnSendAnswer_Click(object sender, EventArgs e)
        {
            sendCorrectAnswer(Host.indexCurrentQuestion);
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
    }
}
