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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.grvListGame = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMenuControls = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTimeEnterGame = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHow = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
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
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListGame)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlMenuControls.SuspendLayout();
            this.pnlNearestGame.SuspendLayout();
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
            // grvListGame
            // 
            this.grvListGame.AllowUserToAddRows = false;
            this.grvListGame.AllowUserToDeleteRows = false;
            this.grvListGame.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.grvListGame.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grvListGame.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvListGame.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grvListGame.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvListGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvListGame.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grvListGame.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvListGame.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grvListGame.ColumnHeadersHeight = 30;
            this.grvListGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvListGame.DefaultCellStyle = dataGridViewCellStyle11;
            this.grvListGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.grvListGame.EnableHeadersVisualStyles = false;
            this.grvListGame.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grvListGame.Location = new System.Drawing.Point(0, 60);
            this.grvListGame.Name = "grvListGame";
            this.grvListGame.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvListGame.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            this.pnlMenuControls.Controls.Add(this.lblTimeEnterGame);
            this.pnlMenuControls.Controls.Add(this.label4);
            this.pnlMenuControls.Controls.Add(this.panel3);
            this.pnlMenuControls.Controls.Add(this.btnHow);
            this.pnlMenuControls.Controls.Add(this.guna2Button2);
            this.pnlMenuControls.Controls.Add(this.btnSetting);
            this.pnlMenuControls.Location = new System.Drawing.Point(27, 12);
            this.pnlMenuControls.Name = "pnlMenuControls";
            this.pnlMenuControls.ShadowDecoration.Parent = this.pnlMenuControls;
            this.pnlMenuControls.Size = new System.Drawing.Size(504, 676);
            this.pnlMenuControls.TabIndex = 0;
            // 
            // lblTimeEnterGame
            // 
            this.lblTimeEnterGame.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeEnterGame.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeEnterGame.ForeColor = System.Drawing.Color.Red;
            this.lblTimeEnterGame.Location = new System.Drawing.Point(127, 353);
            this.lblTimeEnterGame.Name = "lblTimeEnterGame";
            this.lblTimeEnterGame.Size = new System.Drawing.Size(272, 43);
            this.lblTimeEnterGame.TabIndex = 21;
            this.lblTimeEnterGame.Text = "00:59";
            this.lblTimeEnterGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(118, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 46);
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
            this.btnHow.FillColor = System.Drawing.Color.Fuchsia;
            this.btnHow.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHow.ForeColor = System.Drawing.Color.White;
            this.btnHow.HoverState.Parent = this.btnHow;
            this.btnHow.Location = new System.Drawing.Point(125, 447);
            this.btnHow.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnHow.Name = "btnHow";
            this.btnHow.ShadowDecoration.Parent = this.btnHow;
            this.btnHow.Size = new System.Drawing.Size(293, 59);
            this.btnHow.TabIndex = 24;
            this.btnHow.Text = "HOW";
            this.btnHow.Click += new System.EventHandler(this.btnHow_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Red;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(125, 605);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(293, 59);
            this.guna2Button2.TabIndex = 23;
            this.guna2Button2.Text = "ABOUT US";
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BorderRadius = 20;
            this.btnSetting.CheckedState.Parent = this.btnSetting;
            this.btnSetting.CustomImages.Parent = this.btnSetting;
            this.btnSetting.FillColor = System.Drawing.Color.DarkOrange;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.HoverState.Parent = this.btnSetting;
            this.btnSetting.Location = new System.Drawing.Point(125, 526);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.ShadowDecoration.Parent = this.btnSetting;
            this.btnSetting.Size = new System.Drawing.Size(293, 59);
            this.btnSetting.TabIndex = 22;
            this.btnSetting.Text = "SETTING";
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
            this.lblCountDown.Text = "00:00";
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
            this.Name = "MenuGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "#Name game";
            this.SizeChanged += new System.EventHandler(this.MenuGame_SizeChanged);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvListGame)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenuControls.ResumeLayout(false);
            this.pnlNearestGame.ResumeLayout(false);
            this.pnlNearestGame.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
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
    }
}