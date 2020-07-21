namespace Sever
{
    partial class QuestionManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlGrv = new System.Windows.Forms.Panel();
            this.grvListQuestion = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlBtnGroup = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtTopicInfor = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlAnswerGroup = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveAll = new Guna.UI2.WinForms.Guna2Button();
            this.ucAnswerBoxC = new Sever.UCAnswerBox();
            this.ucAnswerBoxD = new Sever.UCAnswerBox();
            this.ucAnswerBoxA = new Sever.UCAnswerBox();
            this.ucAnswerBoxB = new Sever.UCAnswerBox();
            this.pnlRight.SuspendLayout();
            this.pnlGrv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListQuestion)).BeginInit();
            this.pnlBtnGroup.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlAnswerGroup.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 603);
            this.panel3.TabIndex = 17;
            // 
            // pnlRight
            // 
            this.pnlRight.AutoScroll = true;
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlRight.Controls.Add(this.pnlGrv);
            this.pnlRight.Controls.Add(this.pnlBtnGroup);
            this.pnlRight.Controls.Add(this.pnlTitle);
            this.pnlRight.Controls.Add(this.panel3);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(477, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(500, 603);
            this.pnlRight.TabIndex = 10;
            // 
            // pnlGrv
            // 
            this.pnlGrv.Controls.Add(this.grvListQuestion);
            this.pnlGrv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrv.Location = new System.Drawing.Point(2, 62);
            this.pnlGrv.Name = "pnlGrv";
            this.pnlGrv.Size = new System.Drawing.Size(498, 462);
            this.pnlGrv.TabIndex = 33;
            // 
            // grvListQuestion
            // 
            this.grvListQuestion.AllowUserToAddRows = false;
            this.grvListQuestion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grvListQuestion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvListQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvListQuestion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvListQuestion.BackgroundColor = System.Drawing.Color.White;
            this.grvListQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvListQuestion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grvListQuestion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvListQuestion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvListQuestion.ColumnHeadersHeight = 30;
            this.grvListQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvListQuestion.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvListQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvListQuestion.EnableHeadersVisualStyles = false;
            this.grvListQuestion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grvListQuestion.Location = new System.Drawing.Point(0, 0);
            this.grvListQuestion.Name = "grvListQuestion";
            this.grvListQuestion.ReadOnly = true;
            this.grvListQuestion.RowHeadersVisible = false;
            this.grvListQuestion.RowHeadersWidth = 51;
            this.grvListQuestion.RowTemplate.Height = 24;
            this.grvListQuestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvListQuestion.Size = new System.Drawing.Size(498, 462);
            this.grvListQuestion.TabIndex = 31;
            this.grvListQuestion.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.grvListQuestion.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grvListQuestion.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grvListQuestion.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grvListQuestion.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grvListQuestion.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grvListQuestion.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grvListQuestion.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grvListQuestion.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grvListQuestion.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvListQuestion.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grvListQuestion.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grvListQuestion.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grvListQuestion.ThemeStyle.HeaderStyle.Height = 30;
            this.grvListQuestion.ThemeStyle.ReadOnly = true;
            this.grvListQuestion.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grvListQuestion.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grvListQuestion.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grvListQuestion.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grvListQuestion.ThemeStyle.RowsStyle.Height = 24;
            this.grvListQuestion.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grvListQuestion.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grvListQuestion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvListQuestion_CellClick);
            // 
            // pnlBtnGroup
            // 
            this.pnlBtnGroup.Controls.Add(this.btnEdit);
            this.pnlBtnGroup.Controls.Add(this.btnRemove);
            this.pnlBtnGroup.Controls.Add(this.btnRemoveAll);
            this.pnlBtnGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtnGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBtnGroup.Location = new System.Drawing.Point(2, 524);
            this.pnlBtnGroup.Name = "pnlBtnGroup";
            this.pnlBtnGroup.Size = new System.Drawing.Size(498, 79);
            this.pnlBtnGroup.TabIndex = 32;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(2, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(498, 62);
            this.pnlTitle.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 80);
            this.label1.TabIndex = 14;
            this.label1.Text = "LIST QUESTION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.panel9);
            this.pnlForm.Controls.Add(this.panel8);
            this.pnlForm.Controls.Add(this.pnlAnswerGroup);
            this.pnlForm.Controls.Add(this.panel7);
            this.pnlForm.Controls.Add(this.panel5);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(476, 603);
            this.pnlForm.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.btnRefresh);
            this.panel9.Controls.Add(this.btnAdd);
            this.panel9.Controls.Add(this.btnSave);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 504);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(476, 99);
            this.panel9.TabIndex = 57;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtTopicInfor);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 406);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(476, 102);
            this.panel8.TabIndex = 56;
            // 
            // txtTopicInfor
            // 
            this.txtTopicInfor.BorderColor = System.Drawing.Color.Aqua;
            this.txtTopicInfor.BorderRadius = 20;
            this.txtTopicInfor.BorderThickness = 2;
            this.txtTopicInfor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTopicInfor.DefaultText = "";
            this.txtTopicInfor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTopicInfor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTopicInfor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTopicInfor.DisabledState.Parent = this.txtTopicInfor;
            this.txtTopicInfor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTopicInfor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtTopicInfor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTopicInfor.FocusedState.Parent = this.txtTopicInfor;
            this.txtTopicInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopicInfor.ForeColor = System.Drawing.Color.White;
            this.txtTopicInfor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTopicInfor.HoverState.Parent = this.txtTopicInfor;
            this.txtTopicInfor.Location = new System.Drawing.Point(11, 11);
            this.txtTopicInfor.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtTopicInfor.Multiline = true;
            this.txtTopicInfor.Name = "txtTopicInfor";
            this.txtTopicInfor.PasswordChar = '\0';
            this.txtTopicInfor.PlaceholderText = "Type topic information of the question...";
            this.txtTopicInfor.SelectedText = "";
            this.txtTopicInfor.ShadowDecoration.Parent = this.txtTopicInfor;
            this.txtTopicInfor.Size = new System.Drawing.Size(459, 84);
            this.txtTopicInfor.TabIndex = 27;
            // 
            // pnlAnswerGroup
            // 
            this.pnlAnswerGroup.Controls.Add(this.ucAnswerBoxC);
            this.pnlAnswerGroup.Controls.Add(this.ucAnswerBoxD);
            this.pnlAnswerGroup.Controls.Add(this.ucAnswerBoxA);
            this.pnlAnswerGroup.Controls.Add(this.ucAnswerBoxB);
            this.pnlAnswerGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnswerGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAnswerGroup.Location = new System.Drawing.Point(0, 168);
            this.pnlAnswerGroup.Name = "pnlAnswerGroup";
            this.pnlAnswerGroup.Size = new System.Drawing.Size(476, 238);
            this.pnlAnswerGroup.TabIndex = 55;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.txtContent);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 78);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(476, 90);
            this.panel7.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 90);
            this.panel1.TabIndex = 23;
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.Aqua;
            this.txtId.BorderRadius = 20;
            this.txtId.BorderThickness = 2;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.Parent = this.txtId;
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.FocusedState.Parent = this.txtId;
            this.txtId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.HoverState.Parent = this.txtId;
            this.txtId.Location = new System.Drawing.Point(8, 10);
            this.txtId.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PlaceholderText = "Type ID";
            this.txtId.SelectedText = "";
            this.txtId.ShadowDecoration.Parent = this.txtId;
            this.txtId.Size = new System.Drawing.Size(85, 57);
            this.txtId.TabIndex = 0;
            // 
            // txtContent
            // 
            this.txtContent.BorderColor = System.Drawing.Color.Aqua;
            this.txtContent.BorderRadius = 20;
            this.txtContent.BorderThickness = 2;
            this.txtContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContent.DefaultText = "";
            this.txtContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContent.DisabledState.Parent = this.txtContent;
            this.txtContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContent.FocusedState.Parent = this.txtContent;
            this.txtContent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.ForeColor = System.Drawing.Color.White;
            this.txtContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContent.HoverState.Parent = this.txtContent;
            this.txtContent.Location = new System.Drawing.Point(100, 0);
            this.txtContent.Margin = new System.Windows.Forms.Padding(0);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.PasswordChar = '\0';
            this.txtContent.PlaceholderText = "Type your question...";
            this.txtContent.SelectedText = "";
            this.txtContent.ShadowDecoration.Parent = this.txtContent;
            this.txtContent.Size = new System.Drawing.Size(374, 90);
            this.txtContent.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(476, 78);
            this.panel5.TabIndex = 53;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Aqua;
            this.panel6.Location = new System.Drawing.Point(116, 59);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(246, 5);
            this.panel6.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 60);
            this.label2.TabIndex = 26;
            this.label2.Text = "CREATE QUESTION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Animated = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnRefresh.BorderRadius = 20;
            this.btnRefresh.BorderThickness = 2;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnRefresh.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRefresh.HoverState.ForeColor = System.Drawing.Color.Cyan;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(285, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(139, 51);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseTransparentBackground = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderThickness = 2;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnAdd.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.Cyan;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(62, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(139, 51);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderThickness = 2;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.Cyan;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(52, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(139, 51);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.BorderThickness = 2;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.Enabled = false;
            this.btnEdit.FillColor = System.Drawing.Color.Transparent;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnEdit.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnEdit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEdit.HoverState.ForeColor = System.Drawing.Color.Cyan;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(20, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(139, 51);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnRemove.BorderRadius = 20;
            this.btnRemove.BorderThickness = 2;
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.btnRemove.FillColor = System.Drawing.Color.Transparent;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnRemove.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnRemove.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRemove.HoverState.ForeColor = System.Drawing.Color.Cyan;
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(180, 24);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(139, 51);
            this.btnRemove.TabIndex = 37;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnRemoveAll.BorderRadius = 20;
            this.btnRemoveAll.BorderThickness = 2;
            this.btnRemoveAll.CheckedState.Parent = this.btnRemoveAll;
            this.btnRemoveAll.CustomImages.Parent = this.btnRemoveAll;
            this.btnRemoveAll.FillColor = System.Drawing.Color.Transparent;
            this.btnRemoveAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnRemoveAll.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnRemoveAll.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRemoveAll.HoverState.ForeColor = System.Drawing.Color.Cyan;
            this.btnRemoveAll.HoverState.Parent = this.btnRemoveAll;
            this.btnRemoveAll.Location = new System.Drawing.Point(335, 24);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.ShadowDecoration.Parent = this.btnRemoveAll;
            this.btnRemoveAll.Size = new System.Drawing.Size(139, 51);
            this.btnRemoveAll.TabIndex = 36;
            this.btnRemoveAll.Text = "REMOVE ALL";
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // ucAnswerBoxC
            // 
            this.ucAnswerBoxC.BackColor = System.Drawing.Color.Transparent;
            this.ucAnswerBoxC.Content = "";
            this.ucAnswerBoxC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAnswerBoxC.isAnswerCorrect = false;
            this.ucAnswerBoxC.Location = new System.Drawing.Point(3, 118);
            this.ucAnswerBoxC.Name = "ucAnswerBoxC";
            this.ucAnswerBoxC.Size = new System.Drawing.Size(439, 51);
            this.ucAnswerBoxC.TabIndex = 9;
            // 
            // ucAnswerBoxD
            // 
            this.ucAnswerBoxD.BackColor = System.Drawing.Color.Transparent;
            this.ucAnswerBoxD.Content = "";
            this.ucAnswerBoxD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAnswerBoxD.isAnswerCorrect = false;
            this.ucAnswerBoxD.Location = new System.Drawing.Point(3, 175);
            this.ucAnswerBoxD.Name = "ucAnswerBoxD";
            this.ucAnswerBoxD.Size = new System.Drawing.Size(439, 53);
            this.ucAnswerBoxD.TabIndex = 8;
            // 
            // ucAnswerBoxA
            // 
            this.ucAnswerBoxA.BackColor = System.Drawing.Color.Transparent;
            this.ucAnswerBoxA.Content = "";
            this.ucAnswerBoxA.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAnswerBoxA.isAnswerCorrect = false;
            this.ucAnswerBoxA.Location = new System.Drawing.Point(5, 6);
            this.ucAnswerBoxA.Name = "ucAnswerBoxA";
            this.ucAnswerBoxA.Size = new System.Drawing.Size(437, 50);
            this.ucAnswerBoxA.TabIndex = 7;
            // 
            // ucAnswerBoxB
            // 
            this.ucAnswerBoxB.BackColor = System.Drawing.Color.Transparent;
            this.ucAnswerBoxB.Content = "";
            this.ucAnswerBoxB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAnswerBoxB.isAnswerCorrect = false;
            this.ucAnswerBoxB.Location = new System.Drawing.Point(3, 62);
            this.ucAnswerBoxB.Name = "ucAnswerBoxB";
            this.ucAnswerBoxB.Size = new System.Drawing.Size(439, 50);
            this.ucAnswerBoxB.TabIndex = 6;
            // 
            // QuestionManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(977, 603);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlForm);
            this.Name = "QuestionManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question Management";
            this.ClientSizeChanged += new System.EventHandler(this.QuestionManagement_ClientSizeChanged);
            this.pnlRight.ResumeLayout(false);
            this.pnlGrv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvListQuestion)).EndInit();
            this.pnlBtnGroup.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pnlAnswerGroup.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlBtnGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlGrv;
        private Guna.UI2.WinForms.Guna2DataGridView grvListQuestion;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2TextBox txtTopicInfor;
        private System.Windows.Forms.Panel pnlAnswerGroup;
        private UCAnswerBox ucAnswerBoxC;
        private UCAnswerBox ucAnswerBoxD;
        private UCAnswerBox ucAnswerBoxA;
        private UCAnswerBox ucAnswerBoxB;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private Guna.UI2.WinForms.Guna2TextBox txtContent;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnRemoveAll;
    }
}

