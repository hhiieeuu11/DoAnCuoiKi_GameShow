namespace client
{
    partial class Playgame
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playgame));
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlRank = new Guna.UI2.WinForms.Guna2Panel();
            this.lvScores = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScores = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartCountPlayerAnswer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axVideoChatReceiver1 = new AxVideoChatReceiverLib.AxVideoChatReceiver();
            this.proCountDown = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.npwBox = new DTOProject.numberPeopleWacthing();
            this.pnlInforQuestion = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAnwserGroup = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAnswerD = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnswerC = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnswerB = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnswerA = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.ElipseNumberPeopleWatching = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlRight.SuspendLayout();
            this.pnlRank.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountPlayerAnswer)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).BeginInit();
            this.proCountDown.SuspendLayout();
            this.pnlInforQuestion.SuspendLayout();
            this.pnlAnwserGroup.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlRank);
            this.pnlRight.Controls.Add(this.panel2);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(974, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(286, 703);
            this.pnlRight.TabIndex = 7;
            // 
            // pnlRank
            // 
            this.pnlRank.Controls.Add(this.lvScores);
            this.pnlRank.Controls.Add(this.label3);
            this.pnlRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRank.Location = new System.Drawing.Point(0, 356);
            this.pnlRank.Name = "pnlRank";
            this.pnlRank.ShadowDecoration.Parent = this.pnlRank;
            this.pnlRank.Size = new System.Drawing.Size(286, 347);
            this.pnlRank.TabIndex = 1;
            // 
            // lvScores
            // 
            this.lvScores.BackgroundImageTiled = true;
            this.lvScores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colScores});
            this.lvScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvScores.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvScores.ForeColor = System.Drawing.Color.DimGray;
            this.lvScores.FullRowSelect = true;
            this.lvScores.GridLines = true;
            this.lvScores.HideSelection = false;
            this.lvScores.Location = new System.Drawing.Point(0, 34);
            this.lvScores.Name = "lvScores";
            this.lvScores.ShowItemToolTips = true;
            this.lvScores.Size = new System.Drawing.Size(286, 313);
            this.lvScores.TabIndex = 37;
            this.lvScores.UseCompatibleStateImageBehavior = false;
            this.lvScores.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Player";
            this.colId.Width = 194;
            // 
            // colScores
            // 
            this.colScores.Text = "Scores";
            this.colScores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colScores.Width = 86;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 34);
            this.label3.TabIndex = 38;
            this.label3.Text = "List question";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartCountPlayerAnswer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 356);
            this.panel2.TabIndex = 0;
            // 
            // chartCountPlayerAnswer
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCountPlayerAnswer.ChartAreas.Add(chartArea1);
            this.chartCountPlayerAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCountPlayerAnswer.Location = new System.Drawing.Point(0, 0);
            this.chartCountPlayerAnswer.Name = "chartCountPlayerAnswer";
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.MarkerSize = 10;
            series1.Name = "numberOfPlayerChoose";
            this.chartCountPlayerAnswer.Series.Add(series1);
            this.chartCountPlayerAnswer.Size = new System.Drawing.Size(286, 356);
            this.chartCountPlayerAnswer.TabIndex = 28;
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "ANALYSIS TABLE";
            this.chartCountPlayerAnswer.Titles.Add(title1);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(977, 703);
            this.pnlLeft.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.proCountDown);
            this.panel1.Controls.Add(this.npwBox);
            this.panel1.Controls.Add(this.pnlInforQuestion);
            this.panel1.Controls.Add(this.axVideoChatReceiver1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 703);
            this.panel1.TabIndex = 18;
            // 
            // axVideoChatReceiver1
            // 
            this.axVideoChatReceiver1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axVideoChatReceiver1.Enabled = true;
            this.axVideoChatReceiver1.Location = new System.Drawing.Point(0, 0);
            this.axVideoChatReceiver1.Name = "axVideoChatReceiver1";
            this.axVideoChatReceiver1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatReceiver1.OcxState")));
            this.axVideoChatReceiver1.Size = new System.Drawing.Size(977, 703);
            this.axVideoChatReceiver1.TabIndex = 30;
            // 
            // proCountDown
            // 
            this.proCountDown.Animated = true;
            this.proCountDown.AnimationSpeed = 2F;
            this.proCountDown.BackColor = System.Drawing.Color.Transparent;
            this.proCountDown.Controls.Add(this.lblCountDown);
            this.proCountDown.FillColor = System.Drawing.Color.Transparent;
            this.proCountDown.FillThickness = 10;
            this.proCountDown.Location = new System.Drawing.Point(147, 12);
            this.proCountDown.Maximum = 15;
            this.proCountDown.Name = "proCountDown";
            this.proCountDown.ProgressColor = System.Drawing.Color.Red;
            this.proCountDown.ProgressColor2 = System.Drawing.Color.Red;
            this.proCountDown.ProgressThickness = 10;
            this.proCountDown.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.proCountDown.ShadowDecoration.Parent = this.proCountDown;
            this.proCountDown.Size = new System.Drawing.Size(80, 80);
            this.proCountDown.TabIndex = 23;
            // 
            // lblCountDown
            // 
            this.lblCountDown.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.White;
            this.lblCountDown.Location = new System.Drawing.Point(0, 20);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(80, 38);
            this.lblCountDown.TabIndex = 1;
            this.lblCountDown.Text = "0:15";
            this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // npwBox
            // 
            this.npwBox.BackColor = System.Drawing.Color.Transparent;
            this.npwBox.Location = new System.Drawing.Point(23, 35);
            this.npwBox.Name = "npwBox";
            this.npwBox.Number = 0;
            this.npwBox.Size = new System.Drawing.Size(81, 30);
            this.npwBox.TabIndex = 22;
            // 
            // pnlInforQuestion
            // 
            this.pnlInforQuestion.BackColor = System.Drawing.Color.Transparent;
            this.pnlInforQuestion.Controls.Add(this.pnlAnwserGroup);
            this.pnlInforQuestion.Controls.Add(this.guna2Panel1);
            this.pnlInforQuestion.Location = new System.Drawing.Point(11, 360);
            this.pnlInforQuestion.Name = "pnlInforQuestion";
            this.pnlInforQuestion.ShadowDecoration.Parent = this.pnlInforQuestion;
            this.pnlInforQuestion.Size = new System.Drawing.Size(956, 343);
            this.pnlInforQuestion.TabIndex = 29;
            // 
            // pnlAnwserGroup
            // 
            this.pnlAnwserGroup.BackColor = System.Drawing.Color.Transparent;
            this.pnlAnwserGroup.Controls.Add(this.btnAnswerD);
            this.pnlAnwserGroup.Controls.Add(this.btnAnswerC);
            this.pnlAnwserGroup.Controls.Add(this.btnAnswerB);
            this.pnlAnwserGroup.Controls.Add(this.btnAnswerA);
            this.pnlAnwserGroup.Location = new System.Drawing.Point(9, 168);
            this.pnlAnwserGroup.Name = "pnlAnwserGroup";
            this.pnlAnwserGroup.ShadowDecoration.Parent = this.pnlAnwserGroup;
            this.pnlAnwserGroup.Size = new System.Drawing.Size(936, 172);
            this.pnlAnwserGroup.TabIndex = 27;
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.BorderRadius = 20;
            this.btnAnswerD.CheckedState.Parent = this.btnAnswerD;
            this.btnAnswerD.CustomImages.Parent = this.btnAnswerD;
            this.btnAnswerD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAnswerD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerD.ForeColor = System.Drawing.Color.White;
            this.btnAnswerD.HoverState.Parent = this.btnAnswerD;
            this.btnAnswerD.Location = new System.Drawing.Point(475, 79);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.ShadowDecoration.Parent = this.btnAnswerD;
            this.btnAnswerD.Size = new System.Drawing.Size(450, 70);
            this.btnAnswerD.TabIndex = 27;
            this.btnAnswerD.Text = "D. ";
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.BorderRadius = 20;
            this.btnAnswerC.CheckedState.Parent = this.btnAnswerC;
            this.btnAnswerC.CustomImages.Parent = this.btnAnswerC;
            this.btnAnswerC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAnswerC.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerC.ForeColor = System.Drawing.Color.White;
            this.btnAnswerC.HoverState.Parent = this.btnAnswerC;
            this.btnAnswerC.Location = new System.Drawing.Point(3, 79);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.ShadowDecoration.Parent = this.btnAnswerC;
            this.btnAnswerC.Size = new System.Drawing.Size(450, 70);
            this.btnAnswerC.TabIndex = 26;
            this.btnAnswerC.Text = "C. ";
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.BorderRadius = 20;
            this.btnAnswerB.CheckedState.Parent = this.btnAnswerB;
            this.btnAnswerB.CustomImages.Parent = this.btnAnswerB;
            this.btnAnswerB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAnswerB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerB.ForeColor = System.Drawing.Color.White;
            this.btnAnswerB.HoverState.Parent = this.btnAnswerB;
            this.btnAnswerB.Location = new System.Drawing.Point(475, 3);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.ShadowDecoration.Parent = this.btnAnswerB;
            this.btnAnswerB.Size = new System.Drawing.Size(450, 70);
            this.btnAnswerB.TabIndex = 25;
            this.btnAnswerB.Text = "B. ";
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.BorderRadius = 20;
            this.btnAnswerA.CheckedState.Parent = this.btnAnswerA;
            this.btnAnswerA.CustomImages.Parent = this.btnAnswerA;
            this.btnAnswerA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAnswerA.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerA.ForeColor = System.Drawing.Color.White;
            this.btnAnswerA.HoverState.Parent = this.btnAnswerA;
            this.btnAnswerA.Location = new System.Drawing.Point(3, 3);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.ShadowDecoration.Parent = this.btnAnswerA;
            this.btnAnswerA.Size = new System.Drawing.Size(450, 70);
            this.btnAnswerA.TabIndex = 24;
            this.btnAnswerA.Text = "A.";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.panel3);
            this.guna2Panel1.Controls.Add(this.panel4);
            this.guna2Panel1.Controls.Add(this.panel9);
            this.guna2Panel1.Controls.Add(this.panel10);
            this.guna2Panel1.Controls.Add(this.panel8);
            this.guna2Panel1.Controls.Add(this.panel5);
            this.guna2Panel1.Controls.Add(this.panel11);
            this.guna2Panel1.Controls.Add(this.lblQuestion);
            this.guna2Panel1.Location = new System.Drawing.Point(9, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(939, 147);
            this.guna2Panel1.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(588, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 5);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aqua;
            this.panel4.Location = new System.Drawing.Point(3, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(584, 5);
            this.panel4.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Yellow;
            this.panel9.Location = new System.Drawing.Point(931, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 143);
            this.panel9.TabIndex = 12;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Lime;
            this.panel10.Location = new System.Drawing.Point(388, 1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(549, 5);
            this.panel10.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Aqua;
            this.panel8.Location = new System.Drawing.Point(0, 123);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 24);
            this.panel8.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(0, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 5);
            this.panel5.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.Location = new System.Drawing.Point(0, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 69);
            this.panel7.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Red;
            this.panel11.Location = new System.Drawing.Point(0, 1);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 125);
            this.panel11.TabIndex = 5;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(11, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(914, 130);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrCountDown
            // 
            this.tmrCountDown.Interval = 1000;
            this.tmrCountDown.Tick += new System.EventHandler(this.tmrCountDown_Tick);
            // 
            // ElipseNumberPeopleWatching
            // 
            this.ElipseNumberPeopleWatching.BorderRadius = 20;
            this.ElipseNumberPeopleWatching.TargetControl = this.npwBox;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 80;
            this.guna2Elipse1.TargetControl = this.proCountDown;
            // 
            // Playgame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1260, 703);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Playgame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Playgame_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Playgame_FormClosed);
            this.Load += new System.EventHandler(this.Playgame_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Playgame_ClientSizeChanged);
            this.SizeChanged += new System.EventHandler(this.Playgame_ClientSizeChanged);
            this.pnlRight.ResumeLayout(false);
            this.pnlRank.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCountPlayerAnswer)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).EndInit();
            this.proCountDown.ResumeLayout(false);
            this.pnlInforQuestion.ResumeLayout(false);
            this.pnlAnwserGroup.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmrCountDown;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountPlayerAnswer;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel pnlRank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvScores;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colScores;
        private Guna.UI2.WinForms.Guna2CircleProgressBar proCountDown;
        private System.Windows.Forms.Label lblCountDown;
        private DTOProject.numberPeopleWacthing npwBox;
        private Guna.UI2.WinForms.Guna2Panel pnlInforQuestion;
        private Guna.UI2.WinForms.Guna2Panel pnlAnwserGroup;
        private Guna.UI2.WinForms.Guna2Button btnAnswerD;
        private Guna.UI2.WinForms.Guna2Button btnAnswerC;
        private Guna.UI2.WinForms.Guna2Button btnAnswerB;
        private Guna.UI2.WinForms.Guna2Button btnAnswerA;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblQuestion;
        private Guna.UI2.WinForms.Guna2Elipse ElipseNumberPeopleWatching;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AxVideoChatReceiverLib.AxVideoChatReceiver axVideoChatReceiver1;
    }
}

