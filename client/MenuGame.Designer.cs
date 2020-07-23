namespace client
{
    partial class MenuGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGame));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlNearestGame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblGameID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grvListGame = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMenuControls = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTimeEnterGame = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHow = new Guna.UI2.WinForms.Guna2Button();
            this.btnAboutUs = new Guna.UI2.WinForms.Guna2Button();
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.pnlLeft.SuspendLayout();
            this.pnlNearestGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListGame)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlMenuControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(715, 60);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "LỊCH PHÁT SÓNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLeft.BackgroundImage")));
            this.pnlLeft.Controls.Add(this.pnlNearestGame);
            this.pnlLeft.Controls.Add(this.grvListGame);
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(715, 703);
            this.pnlLeft.TabIndex = 4;
            // 
            // pnlNearestGame
            // 
            this.pnlNearestGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlNearestGame.Controls.Add(this.label1);
            this.pnlNearestGame.Controls.Add(this.lblGameName);
            this.pnlNearestGame.Controls.Add(this.label13);
            this.pnlNearestGame.Controls.Add(this.lblCountDown);
            this.pnlNearestGame.Controls.Add(this.label5);
            this.pnlNearestGame.Controls.Add(this.lblStartTime);
            this.pnlNearestGame.Controls.Add(this.lblGameID);
            this.pnlNearestGame.Controls.Add(this.label3);
            this.pnlNearestGame.Controls.Add(this.label2);
            this.pnlNearestGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNearestGame.Location = new System.Drawing.Point(0, 408);
            this.pnlNearestGame.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNearestGame.Name = "pnlNearestGame";
            this.pnlNearestGame.Size = new System.Drawing.Size(715, 295);
            this.pnlNearestGame.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 63);
            this.label1.TabIndex = 36;
            this.label1.Text = "NEAREST GAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameName
            // 
            this.lblGameName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.White;
            this.lblGameName.Location = new System.Drawing.Point(123, 110);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(337, 32);
            this.lblGameName.TabIndex = 8;
            this.lblGameName.Text = "#lblGameName";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(21, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 32);
            this.label13.TabIndex = 7;
            this.label13.Text = "Name :";
            // 
            // lblCountDown
            // 
            this.lblCountDown.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.White;
            this.lblCountDown.Location = new System.Drawing.Point(184, 196);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(280, 68);
            this.lblCountDown.TabIndex = 6;
            this.lblCountDown.Text = "__:__";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Waiting time:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.Color.White;
            this.lblStartTime.Location = new System.Drawing.Point(161, 158);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(305, 32);
            this.lblStartTime.TabIndex = 4;
            this.lblStartTime.Text = "#lblStartTime";
            // 
            // lblGameID
            // 
            this.lblGameID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameID.ForeColor = System.Drawing.Color.White;
            this.lblGameID.Location = new System.Drawing.Point(85, 61);
            this.lblGameID.Name = "lblGameID";
            this.lblGameID.Size = new System.Drawing.Size(375, 32);
            this.lblGameID.TabIndex = 3;
            this.lblGameID.Text = "#lblGameID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID :";
            // 
            // grvListGame
            // 
            this.grvListGame.AllowUserToAddRows = false;
            this.grvListGame.AllowUserToDeleteRows = false;
            this.grvListGame.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grvListGame.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvListGame.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvListGame.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grvListGame.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvListGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvListGame.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grvListGame.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvListGame.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvListGame.ColumnHeadersHeight = 30;
            this.grvListGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvListGame.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvListGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.grvListGame.EnableHeadersVisualStyles = false;
            this.grvListGame.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grvListGame.Location = new System.Drawing.Point(0, 60);
            this.grvListGame.Name = "grvListGame";
            this.grvListGame.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvListGame.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grvListGame.RowHeadersVisible = false;
            this.grvListGame.RowHeadersWidth = 10;
            this.grvListGame.RowTemplate.Height = 24;
            this.grvListGame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvListGame.Size = new System.Drawing.Size(715, 348);
            this.grvListGame.TabIndex = 17;
            this.grvListGame.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.grvListGame.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grvListGame.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grvListGame.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grvListGame.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grvListGame.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grvListGame.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.grvListGame.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grvListGame.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grvListGame.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvListGame.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grvListGame.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grvListGame.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grvListGame.ThemeStyle.HeaderStyle.Height = 30;
            this.grvListGame.ThemeStyle.ReadOnly = true;
            this.grvListGame.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grvListGame.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grvListGame.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grvListGame.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grvListGame.ThemeStyle.RowsStyle.Height = 24;
            this.grvListGame.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grvListGame.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grvListGame.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvListGame_CellClick);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.Controls.Add(this.pnlMenuControls);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(715, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(547, 703);
            this.pnlMenu.TabIndex = 5;
            // 
            // pnlMenuControls
            // 
            this.pnlMenuControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuControls.Controls.Add(this.label4);
            this.pnlMenuControls.Controls.Add(this.lblTimeEnterGame);
            this.pnlMenuControls.Controls.Add(this.guna2Button1);
            this.pnlMenuControls.Controls.Add(this.txtUsername);
            this.pnlMenuControls.Controls.Add(this.panel3);
            this.pnlMenuControls.Controls.Add(this.btnHow);
            this.pnlMenuControls.Controls.Add(this.btnAboutUs);
            this.pnlMenuControls.Location = new System.Drawing.Point(27, 12);
            this.pnlMenuControls.Name = "pnlMenuControls";
            this.pnlMenuControls.ShadowDecoration.Parent = this.pnlMenuControls;
            this.pnlMenuControls.Size = new System.Drawing.Size(504, 676);
            this.pnlMenuControls.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(33, 380);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(82, 116);
            this.guna2Button1.TabIndex = 28;
            this.guna2Button1.Text = "guna2Button1";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Animated = true;
            this.txtUsername.BorderColor = System.Drawing.Color.Cyan;
            this.txtUsername.BorderRadius = 20;
            this.txtUsername.BorderThickness = 2;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(59)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtUsername.ForeColor = System.Drawing.Color.Cyan;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(131, 416);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Type your name...";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(286, 60);
            this.txtUsername.TabIndex = 27;
            // 
            // lblTimeEnterGame
            // 
            this.lblTimeEnterGame.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeEnterGame.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeEnterGame.ForeColor = System.Drawing.Color.Red;
            this.lblTimeEnterGame.Location = new System.Drawing.Point(127, 335);
            this.lblTimeEnterGame.Name = "lblTimeEnterGame";
            this.lblTimeEnterGame.Size = new System.Drawing.Size(272, 61);
            this.lblTimeEnterGame.TabIndex = 21;
            this.lblTimeEnterGame.Text = "00:00";
            this.lblTimeEnterGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(118, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 46);
            this.label4.TabIndex = 26;
            this.label4.Text = "Enter the game after";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(56, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 271);
            this.panel3.TabIndex = 25;
            // 
            // btnHow
            // 
            this.btnHow.BackColor = System.Drawing.Color.Transparent;
            this.btnHow.BorderRadius = 20;
            this.btnHow.CheckedState.Parent = this.btnHow;
            this.btnHow.CustomImages.Parent = this.btnHow;
            this.btnHow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHow.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHow.ForeColor = System.Drawing.Color.White;
            this.btnHow.HoverState.Parent = this.btnHow;
            this.btnHow.Location = new System.Drawing.Point(125, 496);
            this.btnHow.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnHow.Name = "btnHow";
            this.btnHow.ShadowDecoration.Parent = this.btnHow;
            this.btnHow.Size = new System.Drawing.Size(293, 59);
            this.btnHow.TabIndex = 24;
            this.btnHow.Text = "HOW";
            this.btnHow.Click += new System.EventHandler(this.btnHow_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutUs.BorderRadius = 20;
            this.btnAboutUs.CheckedState.Parent = this.btnAboutUs;
            this.btnAboutUs.CustomImages.Parent = this.btnAboutUs;
            this.btnAboutUs.FillColor = System.Drawing.Color.Red;
            this.btnAboutUs.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.HoverState.Parent = this.btnAboutUs;
            this.btnAboutUs.Location = new System.Drawing.Point(125, 582);
            this.btnAboutUs.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.ShadowDecoration.Parent = this.btnAboutUs;
            this.btnAboutUs.Size = new System.Drawing.Size(293, 59);
            this.btnAboutUs.TabIndex = 23;
            this.btnAboutUs.Text = "ABOUT US";
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // tmrCountDown
            // 
            this.tmrCountDown.Interval = 1000;
            this.tmrCountDown.Tick += new System.EventHandler(this.tmrCountDown_Tick);
            // 
            // MenuGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1262, 703);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlLeft);
            this.MinimumSize = new System.Drawing.Size(1230, 680);
            this.Name = "MenuGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "#Name game";
            this.SizeChanged += new System.EventHandler(this.MenuGame_SizeChanged);
            this.pnlLeft.ResumeLayout(false);
            this.pnlNearestGame.ResumeLayout(false);
            this.pnlNearestGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListGame)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenuControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2DataGridView grvListGame;
        private System.Windows.Forms.Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Panel pnlMenuControls;
        private System.Windows.Forms.Label lblTimeEnterGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnHow;
        private Guna.UI2.WinForms.Guna2Button btnAboutUs;
        private System.Windows.Forms.Panel pnlNearestGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblGameID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrCountDown;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}