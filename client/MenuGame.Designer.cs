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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGame));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlNearestGame = new System.Windows.Forms.Panel();
            this.lblGameName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGameTime = new System.Windows.Forms.Label();
            this.lblGameID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grvListGame = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimeEnterGame = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHow = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLeft.SuspendLayout();
            this.pnlNearestGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListGame)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
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
            this.pnlLeft.Controls.Add(this.pnlNearestGame);
            this.pnlLeft.Controls.Add(this.grvListGame);
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(715, 703);
            this.pnlLeft.TabIndex = 4;
            // 
            // pnlNearestGame
            // 
            this.pnlNearestGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlNearestGame.Controls.Add(this.lblGameName);
            this.pnlNearestGame.Controls.Add(this.label13);
            this.pnlNearestGame.Controls.Add(this.lblCountDown);
            this.pnlNearestGame.Controls.Add(this.label5);
            this.pnlNearestGame.Controls.Add(this.lblGameTime);
            this.pnlNearestGame.Controls.Add(this.lblGameID);
            this.pnlNearestGame.Controls.Add(this.label3);
            this.pnlNearestGame.Controls.Add(this.label2);
            this.pnlNearestGame.Controls.Add(this.label1);
            this.pnlNearestGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNearestGame.Location = new System.Drawing.Point(0, 408);
            this.pnlNearestGame.Name = "pnlNearestGame";
            this.pnlNearestGame.Size = new System.Drawing.Size(715, 299);
            this.pnlNearestGame.TabIndex = 19;
            // 
            // lblGameName
            // 
            this.lblGameName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.White;
            this.lblGameName.Location = new System.Drawing.Point(111, 131);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(595, 32);
            this.lblGameName.TabIndex = 8;
            this.lblGameName.Text = "#GameName (lblGameName)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(18, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 32);
            this.label13.TabIndex = 7;
            this.label13.Text = "Name :";
            // 
            // lblCountDown
            // 
            this.lblCountDown.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.White;
            this.lblCountDown.Location = new System.Drawing.Point(201, 231);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(397, 32);
            this.lblCountDown.TabIndex = 6;
            this.lblCountDown.Text = "#Thời gian chờ (lblCountDown)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thời gian chờ :";
            // 
            // lblGameTime
            // 
            this.lblGameTime.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTime.ForeColor = System.Drawing.Color.White;
            this.lblGameTime.Location = new System.Drawing.Point(154, 174);
            this.lblGameTime.Name = "lblGameTime";
            this.lblGameTime.Size = new System.Drawing.Size(481, 32);
            this.lblGameTime.TabIndex = 4;
            this.lblGameTime.Text = "#Thời gian game phát sóng (lblGameTime)";
            // 
            // lblGameID
            // 
            this.lblGameID.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameID.ForeColor = System.Drawing.Color.White;
            this.lblGameID.Location = new System.Drawing.Point(90, 79);
            this.lblGameID.Name = "lblGameID";
            this.lblGameID.Size = new System.Drawing.Size(622, 32);
            this.lblGameID.TabIndex = 3;
            this.lblGameID.Text = "#GameID (lblGameID)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(199, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game gần nhất";
            // 
            // grvListGame
            // 
            this.grvListGame.AllowUserToAddRows = false;
            this.grvListGame.AllowUserToDeleteRows = false;
            this.grvListGame.AllowUserToResizeColumns = false;
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
            this.grvListGame.ColumnHeadersHeight = 20;
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
            this.grvListGame.ThemeStyle.HeaderStyle.Height = 20;
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
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.lblTimeEnterGame);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnHow);
            this.panel2.Controls.Add(this.guna2Button2);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(715, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 703);
            this.panel2.TabIndex = 5;
            // 
            // lblTimeEnterGame
            // 
            this.lblTimeEnterGame.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeEnterGame.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeEnterGame.ForeColor = System.Drawing.Color.Red;
            this.lblTimeEnterGame.Location = new System.Drawing.Point(152, 353);
            this.lblTimeEnterGame.Name = "lblTimeEnterGame";
            this.lblTimeEnterGame.Size = new System.Drawing.Size(272, 43);
            this.lblTimeEnterGame.TabIndex = 9;
            this.lblTimeEnterGame.Text = "00:59";
            this.lblTimeEnterGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(143, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 46);
            this.label4.TabIndex = 20;
            this.label4.Text = "Enter the game after";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(81, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 271);
            this.panel3.TabIndex = 19;
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
            this.btnHow.Location = new System.Drawing.Point(150, 447);
            this.btnHow.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnHow.Name = "btnHow";
            this.btnHow.ShadowDecoration.Parent = this.btnHow;
            this.btnHow.Size = new System.Drawing.Size(293, 59);
            this.btnHow.TabIndex = 18;
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
            this.guna2Button2.Location = new System.Drawing.Point(150, 605);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(293, 59);
            this.guna2Button2.TabIndex = 17;
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
            this.btnSetting.Location = new System.Drawing.Point(150, 526);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.ShadowDecoration.Parent = this.btnSetting;
            this.btnSetting.Size = new System.Drawing.Size(293, 59);
            this.btnSetting.TabIndex = 16;
            this.btnSetting.Text = "SETTING";
            // 
            // MenuGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1262, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlLeft);
            this.Name = "MenuGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "#Name game";
            this.SizeChanged += new System.EventHandler(this.MenuGame_SizeChanged);
            this.pnlLeft.ResumeLayout(false);
            this.pnlNearestGame.ResumeLayout(false);
            this.pnlNearestGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListGame)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2DataGridView grvListGame;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTimeEnterGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnHow;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
        private System.Windows.Forms.Panel pnlNearestGame;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGameTime;
        private System.Windows.Forms.Label lblGameID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}