using DTOProject.DTO;
using Guna.UI2.WinForms;
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

namespace client
{
    public partial class Playgame : Form
    {

        const int COUNTDOWN_TIME = 15;

        int OrigTime = COUNTDOWN_TIME; // count down time
        string nameClient;
        NetComm.Client client; //The client object used for the communication


        public Playgame(string name)
        {
            InitializeComponent();
            pnlLeft.Width = this.Width - pnlRight.Width;
            //Connecting to the host
            pnlInforQuestion.Hide();
            nameClient = name;
        }
        #region
        public Playgame()
        {
            InitializeComponent();
            pnlLeft.Width = this.Width - pnlRight.Width;
           
        }

   

        private void Playgame_ClientSizeChanged(object sender, EventArgs e)
        {
            pnlLeft.Width = this.Width - pnlRight.Width;
            pnlInforQuestion.Location = new Point((pnlLeft.Width - pnlInforQuestion.Width) / 2, pnlLeft.Height - pnlInforQuestion.Height-30);
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
#endregion

        private void Playgame_Load(object sender, EventArgs e)
        {
            client = new NetComm.Client(); //Initialize the client object
            //Adding event handling methods for the client
            client.Connected += new NetComm.Client.ConnectedEventHandler(client_Connected);
            client.Disconnected += new NetComm.Client.DisconnectedEventHandler(client_Disconnected);
            client.DataReceived += new NetComm.Client.DataReceivedEventHandler(client_DataReceived);
            client.Connect("localhost", 5000, nameClient); //Connecting to the host (on the same machine) with port 5000 and ID is variable name in contrustor function
        }

        private void Playgame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client.isConnected) client.Disconnect(); //Disconnects if the 
                                                         //client is connected, closing the communication thread
        }

        #region Function

        void client_Connected()
        {
            //MessageBox.Show("Connected successfully!");
            
        }
        void client_Disconnected()
        {
            MessageBox.Show("Disconnected from host!");

            //this.Close();

        }

        void client_DataReceived(byte[] Data, string ID)
        {
            pnlInforQuestion.Show();
            Question question =  (Question)Utils.ByteArrayToObject(Data);
            setQuestion(question);
            enableButtonAnswer();
            resetClock();
            tmrCountDown.Enabled = true;
        }


        /// <summary>
        /// Set infor of question into controls
        /// </summary>
        /// <param name="question"></param>
        public void setQuestion(Question question)
        {
            int i = 0;
            lblQuestion.Text = question.Content;
            foreach(Control ctl in pnlAnwserGroup.Controls)
            {
                
                Guna2Button btn = (Guna2Button)ctl;
                btn.Click += new System.EventHandler(this.btn_Click);
                btn.Text = question.listAnswer[i++];
            }
        }
        public void resetClock()
        {
            OrigTime = COUNTDOWN_TIME;
            proCountDown.Value = 0;
            lblCountDown.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
        }

        public void unableButtonAnswer()
        {
            foreach (var ctl in pnlAnwserGroup.Controls)
            {
                Guna2Button btn = (Guna2Button)ctl;
                btn.Enabled = false;
            }
        }
        public void enableButtonAnswer()
        {
            foreach (var ctl in pnlAnwserGroup.Controls)
            {
                Guna2Button btn = (Guna2Button)ctl;
                btn.Enabled = true;
            }
        }


        private void btn_Click(object sender, EventArgs e)
        {
           // Guna2Button btn = (Guna2Button)sender;
            unableButtonAnswer();
            client.SendData(Utils.ObjectToByteArray(((Guna2Button)sender).Text));
        }



        #endregion

        private void Playgame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client.isConnected)
                client.Disconnect(); //Disconnects if the 
                                                         //client is connected, closing the communication thread
        }



        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            OrigTime--;
            lblCountDown.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            proCountDown.Value++;
            if (OrigTime <= 0)
            {
                tmrCountDown.Enabled = false;
                unableButtonAnswer();
            }
        }


    }
}
