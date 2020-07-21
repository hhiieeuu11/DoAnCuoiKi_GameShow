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

namespace Sever
{
    public partial class QuestionManagement : Form
    {
        string filePath = Host.fileQuestionPath;
        int rowEdit = -1;
        int currentRow = -1;
        int currentColum= -1;
        int numColumSort = 0;

        #region Function

        /// <summary>
        /// Get information question from form input
        /// </summary>
        /// <returns></returns>
        public Question getQuestionFromForm()
        {
            if (checkInputQuestion())
            {
                Question question = new Question();
                question.Id = txtId.Text;
                question.Content = txtContent.Text;
                foreach (Control ctl in pnlAnswerGroup.Controls)    //get data answers from 4 UCAnswerBox in pnlAnswerGroup
                {
                    UCAnswerBox uc = (UCAnswerBox)ctl;
                    if (uc.isAnswerCorrect) question.AnswerCorrect = uc.Content;
                    question.listAnswer.Add(uc.Content);
                }
                question.TopicInfor = txtTopicInfor.Text;
                return question;
            }
            return null;
        }

        /// <summary>
        /// Get information question EDIT from form input
        /// </summary>
        /// <returns></returns>
        public Question getQuestionEdit()
        {
            if (checkInputEdit())
            {
                Question question = new Question();
                question.Id = txtId.Text;
                question.Content = txtContent.Text;
                foreach (Control ctl in pnlAnswerGroup.Controls)    //get data answers from 4 UCAnswerBox in pnlAnswerGroup
                {
                    UCAnswerBox uc = (UCAnswerBox)ctl;
                    if (uc.isAnswerCorrect) question.AnswerCorrect = uc.Content;
                    question.listAnswer.Add(uc.Content);
                }
                question.TopicInfor = txtTopicInfor.Text;
                return question;
            }
            return null;
        }

        public List<Question> getScheduleFromFile(string filePath, int numColumSort)
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
            Utils.sortQuestion(listQuestion, numColumSort);
            sr.Close();
            return listQuestion;
        }

        /// <summary>
        /// Save quetion to file question.txt
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        private bool saveQuestion(Question question)
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine("!" + question.Id);
            sw.WriteLine("@" + question.Content);
            foreach (string answer in question.listAnswer)
            {
                sw.WriteLine("&" + answer);
            }
            sw.WriteLine("#" + question.AnswerCorrect);
            sw.WriteLine("$" + question.TopicInfor);
            sw.Close();
            return true;
        }


        /// <summary>
        /// Reset textboxs in form input question
        /// </summary>
        public void refreshForm()
        {
            txtId.Text = "";
            txtContent.Text = "";
            txtTopicInfor.Text = "";
            ucAnswerBoxA.isAnswerCorrect = false;
            ucAnswerBoxA.Content = "";
            ucAnswerBoxB.isAnswerCorrect = false;
            ucAnswerBoxB.Content = "";
            ucAnswerBoxC.isAnswerCorrect = false;
            ucAnswerBoxC.Content = "";
            ucAnswerBoxD.isAnswerCorrect = false;
            ucAnswerBoxD.Content = "";
            txtTopicInfor.Text = "";
        }
        public bool checkIdNotExists(string id)
        {
            foreach(var question in Host.listQuestion)
            {
                if (String.Equals(id,question.Id)) return false;
            }
            return true;
        }
        public bool checkHasAnswerCorrect()
        {
            foreach( Control ctl in pnlAnswerGroup.Controls)
            {
                UCAnswerBox uc = (UCAnswerBox)ctl;
                if (uc.isAnswerCorrect) return true;
            }
            return false;
        }
        public bool checkOnlyOneAnswerCorrect()
        {
            int count = 0;
            foreach (Control ctl in pnlAnswerGroup.Controls)
            {
                UCAnswerBox uc = (UCAnswerBox)ctl;
                if (uc.isAnswerCorrect) count++; 
            }
            return count == 1;
        }
        public bool noEmptyAnswer()
        {
            foreach (Control ctl in pnlAnswerGroup.Controls)
            {
                UCAnswerBox uc = (UCAnswerBox)ctl;
                if (string.IsNullOrEmpty(uc.Content)) return false;
            }
            return true;
        }

        /// <summary>
        /// Check whether the question information has been entered sufficiently
        /// </summary>
        /// <returns></returns>
        public bool checkInputQuestion()
        {
            // ID empty
            if (string.IsNullOrEmpty(txtId.Text))    
            {
                MessageBox.Show("You forgot to enter the ID for the question!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return false;
            }

            //ID already exists
            else if (!checkIdNotExists(txtId.Text)) 
            {
                MessageBox.Show("ID already exists!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return false;
            }

            //Content question empty
            else if (string.IsNullOrEmpty(txtContent.Text))
            {
                MessageBox.Show("You forgot to enter content question!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContent.Focus();
                return false;
            }

            //Don't have enough 4 answers
            else if (!noEmptyAnswer()) 
            {
                MessageBox.Show("You don't have enough 4 answers!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Don't have the answer correct
            else if (!checkHasAnswerCorrect()) 
            {
                MessageBox.Show(" You don't have the answer correct!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Cannot have more than 2 answers
            else if (!checkOnlyOneAnswerCorrect())
            {
                MessageBox.Show("You have more than 2 answers correct!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Don't have topic information for question
            else if (string.IsNullOrEmpty(txtTopicInfor.Text))
            {
                MessageBox.Show("You forgot to enter topic information for question!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTopicInfor.Focus();
                return false;
            }

            return true;
        }


        /// <summary>
        /// Check input question, but don't check case ID already exists.
        /// </summary>
        /// <returns></returns>
        public bool checkInputEdit() 
        {
            // ID empty
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("You forgot to enter the ID for the question!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return false;
            }

            //Content question empty
            else if (string.IsNullOrEmpty(txtContent.Text))
            {
                MessageBox.Show("You forgot to enter content question!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContent.Focus();
                return false;
            }

            //Don't have enough 4 answers
            else if (!noEmptyAnswer())
            {
                MessageBox.Show("You don't have enough 4 answers!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Don't have the answer correct
            else if (!checkHasAnswerCorrect())
            {
                MessageBox.Show(" You don't have the answer correct!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Cannot have more than 2 answers
            else if (!checkOnlyOneAnswerCorrect())
            {
                MessageBox.Show("You have more than 2 answers correct!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Don't have topic information for question
            else if (string.IsNullOrEmpty(txtTopicInfor.Text))
            {
                MessageBox.Show("You forgot to enter topic information for question!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTopicInfor.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Save ListQuestion to file, simultaneously update dataGridView Schedule
        /// </summary>
        /// <param name="filePath"></param>
        public void saveListGameShow(string filePath)
        {
            File.WriteAllText(filePath, String.Empty);  //Reset data in file
            Host.listQuestion.ForEach(game =>    //Re-Save current listGameShow
            {
                saveQuestion(game);
            });
            Host.listQuestion = getScheduleFromFile(filePath, numColumSort); //update ListGameShow from the file
            grvListQuestion.DataSource = Host.listQuestion;
        }

        #endregion



        public QuestionManagement()
        {
            InitializeComponent();
            Host.listQuestion = getScheduleFromFile(filePath,numColumSort);
            pnlRight.Width = this.Width - pnlForm.Width;
            btnSave.Hide();
        }


        #region Event
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshForm();
        }
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            Question question = getQuestionFromForm();

            if (question != null)
            {
                bool saveFinish = saveQuestion(question);
                if (saveFinish)
                {
                    refreshForm();
                    Host.listQuestion = getScheduleFromFile(filePath, numColumSort);
                }
            }
        }
        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Remove all", "Do you want remove all question??", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                File.WriteAllText(filePath, String.Empty);
                Host.listQuestion = getScheduleFromFile(filePath, numColumSort);
                grvListQuestion.DataSource = Host.listQuestion;

            }
        }
        private void QuestionManagement_ClientSizeChanged(object sender, EventArgs e)
        {
            pnlRight.Width = this.Width - pnlForm.Width;
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Edit question", "Do you want edit question??", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                btnAdd.Show();
                btnSave.Hide();
                Host.listQuestion[rowEdit] = getQuestionEdit();   //Change data gameshow selected in list
                saveListGameShow(filePath); //Backup list game show
                grvListQuestion.DataSource = Host.listQuestion;
            }
        }

        public void setDataToForm(Question question)
        {
            txtId.Text = question.Id;
            txtContent.Text = question.Content;
            int i = 0;
            foreach (Control ctl in pnlAnswerGroup.Controls)    //get data answers from 4 UCAnswerBox in pnlAnswerGroup
            {
                UCAnswerBox uc = (UCAnswerBox)ctl;
                uc.Content = question.listAnswer[i++];
                if (uc.Content == question.AnswerCorrect) uc.isAnswerCorrect = true;
               
            }
            txtTopicInfor.Text = question.TopicInfor;
        }

        private void grvListQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshForm();
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0) setDataToForm(Host.listQuestion[rowIndex]);

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
            //Click on the data cells of the table
            if (currentRow > -1)
            {
                btnEdit.Enabled = true;
                setDataToForm(Host.listQuestion[currentRow]);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            btnAdd.Hide();//Ẩn
            btnSave.Show();
            rowEdit = currentRow;
        }


        #endregion
    }
}
