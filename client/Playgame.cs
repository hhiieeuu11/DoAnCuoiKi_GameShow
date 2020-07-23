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

        private void btnAnswerA_Click(object sender, EventArgs e)
        {

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
            MessageBox.Show("Connected successfully!");
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

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            client.SendData(Utils.ObjectToByteArray(btn.Text));
        }



        #endregion

        private void Playgame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client.isConnected) client.Disconnect(); //Disconnects if the 
                                                         //client is connected, closing the communication thread
        }
    }
}
