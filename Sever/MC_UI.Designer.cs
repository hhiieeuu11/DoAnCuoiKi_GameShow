namespace Sever
{
    partial class MC_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MC_UI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "123"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "456"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.elipseNumberWatching = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.npwBox = new DTOProject.numberPeopleWacthing();
            this.pnlLeftTop = new System.Windows.Forms.Panel();
            this.pnlContainsTopic = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTopicInfor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlCamera = new Guna.UI2.WinForms.Guna2Panel();
            this.proCountDown = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnLeftBottom = new System.Windows.Forms.Panel();
            this.pnlContainsQuestion = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAnswerGroup = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAnswerD = new System.Windows.Forms.Label();
            this.lblAnswerC = new System.Windows.Forms.Label();
            this.lblAnswerB = new System.Windows.Forms.Label();
            this.lblAnswerA = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnlRight = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnlRightBottom = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlRightTop = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.grvListQuestion = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.elipseClock = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lvListPlayer = new System.Windows.Forms.ListView();
            this.pnlLeftTop.SuspendLayout();
            this.pnlContainsTopic.SuspendLayout();
            this.pnlCamera.SuspendLayout();
            this.proCountDown.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnLeftBottom.SuspendLayout();
            this.pnlContainsQuestion.SuspendLayout();
            this.pnlAnswerGroup.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlRightBottom.SuspendLayout();
            this.pnlRightTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseNumberWatching
            // 
            this.elipseNumberWatching.BorderRadius = 20;
            this.elipseNumberWatching.TargetControl = this.npwBox;
            // 
            // npwBox
            // 
            this.npwBox.BackColor = System.Drawing.Color.Transparent;
            this.npwBox.Location = new System.Drawing.Point(12, 13);
            this.npwBox.Name = "npwBox";
            this.npwBox.Number = 0;
            this.npwBox.Size = new System.Drawing.Size(81, 30);
            this.npwBox.TabIndex = 1;
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.pnlContainsTopic);
            this.pnlLeftTop.Controls.Add(this.label7);
            this.pnlLeftTop.Controls.Add(this.pnlCamera);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(910, 355);
            this.pnlLeftTop.TabIndex = 2;
            // 
            // pnlContainsTopic
            // 
            this.pnlContainsTopic.BorderColor = System.Drawing.Color.Lime;
            this.pnlContainsTopic.BorderRadius = 10;
            this.pnlContainsTopic.BorderThickness = 2;
            this.pnlContainsTopic.Controls.Add(this.lblTopicInfor);
            this.pnlContainsTopic.CustomBorderColor = System.Drawing.Color.Aqua;
            this.pnlContainsTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainsTopic.Location = new System.Drawing.Point(467, 43);
            this.pnlContainsTopic.Name = "pnlContainsTopic";
            this.pnlContainsTopic.ShadowDecoration.Parent = this.pnlContainsTopic;
            this.pnlContainsTopic.Size = new System.Drawing.Size(443, 312);
            this.pnlContainsTopic.TabIndex = 41;
            // 
            // lblTopicInfor
            // 
            this.lblTopicInfor.BackColor = System.Drawing.Color.Transparent;
            this.lblTopicInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTopicInfor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTopicInfor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicInfor.ForeColor = System.Drawing.Color.White;
            this.lblTopicInfor.Location = new System.Drawing.Point(0, 0);
            this.lblTopicInfor.Margin = new System.Windows.Forms.Padding(0);
            this.lblTopicInfor.Name = "lblTopicInfor";
            this.lblTopicInfor.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTopicInfor.Size = new System.Drawing.Size(443, 312);
            this.lblTopicInfor.TabIndex = 34;
            this.lblTopicInfor.Text = "lblTopicInfor";
            this.lblTopicInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(467, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(443, 43);
            this.label7.TabIndex = 40;
            this.label7.Text = "Topic information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCamera
            // 
            this.pnlCamera.BorderColor = System.Drawing.Color.Aqua;
            this.pnlCamera.BorderRadius = 20;
            this.pnlCamera.BorderThickness = 2;
            this.pnlCamera.Controls.Add(this.proCountDown);
            this.pnlCamera.Controls.Add(this.npwBox);
            this.pnlCamera.Controls.Add(this.label1);
            this.pnlCamera.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCamera.Location = new System.Drawing.Point(0, 0);
            this.pnlCamera.Name = "pnlCamera";
            this.pnlCamera.ShadowDecoration.Parent = this.pnlCamera;
            this.pnlCamera.Size = new System.Drawing.Size(467, 355);
            this.pnlCamera.TabIndex = 0;
            // 
            // proCountDown
            // 
            this.proCountDown.Animated = true;
            this.proCountDown.AnimationSpeed = 2F;
            this.proCountDown.BackColor = System.Drawing.Color.Transparent;
            this.proCountDown.Controls.Add(this.lblCountDown);
            this.proCountDown.FillColor = System.Drawing.Color.Transparent;
            this.proCountDown.FillThickness = 10;
            this.proCountDown.Location = new System.Drawing.Point(12, 49);
            this.proCountDown.Maximum = 15;
            this.proCountDown.Name = "proCountDown";
            this.proCountDown.ProgressColor = System.Drawing.Color.Red;
            this.proCountDown.ProgressColor2 = System.Drawing.Color.Red;
            this.proCountDown.ProgressThickness = 10;
            this.proCountDown.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.proCountDown.ShadowDecoration.Parent = this.proCountDown;
            this.proCountDown.Size = new System.Drawing.Size(80, 80);
            this.proCountDown.TabIndex = 6;
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 355);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMERA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnLeftBottom);
            this.pnlLeft.Controls.Add(this.pnlLeftTop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(910, 753);
            this.pnlLeft.TabIndex = 2;
            // 
            // pnLeftBottom
            // 
            this.pnLeftBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnLeftBottom.Controls.Add(this.pnlContainsQuestion);
            this.pnLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLeftBottom.Location = new System.Drawing.Point(0, 355);
            this.pnLeftBottom.Name = "pnLeftBottom";
            this.pnLeftBottom.Size = new System.Drawing.Size(910, 398);
            this.pnLeftBottom.TabIndex = 4;
            // 
            // pnlContainsQuestion
            // 
            this.pnlContainsQuestion.Controls.Add(this.pnlAnswerGroup);
            this.pnlContainsQuestion.Controls.Add(this.panel1);
            this.pnlContainsQuestion.Controls.Add(this.btnNext);
            this.pnlContainsQuestion.Controls.Add(this.btnSend);
            this.pnlContainsQuestion.Controls.Add(this.panel2);
            this.pnlContainsQuestion.Location = new System.Drawing.Point(10, 9);
            this.pnlContainsQuestion.Name = "pnlContainsQuestion";
            this.pnlContainsQuestion.ShadowDecoration.Parent = this.pnlContainsQuestion;
            this.pnlContainsQuestion.Size = new System.Drawing.Size(889, 389);
            this.pnlContainsQuestion.TabIndex = 6;
            // 
            // pnlAnswerGroup
            // 
            this.pnlAnswerGroup.Controls.Add(this.label9);
            this.pnlAnswerGroup.Controls.Add(this.label8);
            this.pnlAnswerGroup.Controls.Add(this.label6);
            this.pnlAnswerGroup.Controls.Add(this.label5);
            this.pnlAnswerGroup.Controls.Add(this.lblAnswerD);
            this.pnlAnswerGroup.Controls.Add(this.lblAnswerC);
            this.pnlAnswerGroup.Controls.Add(this.lblAnswerB);
            this.pnlAnswerGroup.Controls.Add(this.lblAnswerA);
            this.pnlAnswerGroup.Location = new System.Drawing.Point(2, 142);
            this.pnlAnswerGroup.Name = "pnlAnswerGroup";
            this.pnlAnswerGroup.Size = new System.Drawing.Size(886, 182);
            this.pnlAnswerGroup.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(457, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 32);
            this.label9.TabIndex = 43;
            this.label9.Text = "D";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(4, 99);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 32);
            this.label8.TabIndex = 42;
            this.label8.Text = "C";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(457, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 32);
            this.label6.TabIndex = 41;
            this.label6.Text = "B";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(6, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 32);
            this.label5.TabIndex = 40;
            this.label5.Text = "A";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerD
            // 
            this.lblAnswerD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAnswerD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerD.ForeColor = System.Drawing.Color.White;
            this.lblAnswerD.Location = new System.Drawing.Point(454, 97);
            this.lblAnswerD.Name = "lblAnswerD";
            this.lblAnswerD.Size = new System.Drawing.Size(429, 88);
            this.lblAnswerD.TabIndex = 47;
            this.lblAnswerD.Text = "lblAnswerD";
            this.lblAnswerD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerC
            // 
            this.lblAnswerC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAnswerC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerC.ForeColor = System.Drawing.Color.White;
            this.lblAnswerC.Location = new System.Drawing.Point(2, 97);
            this.lblAnswerC.Name = "lblAnswerC";
            this.lblAnswerC.Size = new System.Drawing.Size(429, 88);
            this.lblAnswerC.TabIndex = 46;
            this.lblAnswerC.Text = "lblAnswerC";
            this.lblAnswerC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerB
            // 
            this.lblAnswerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAnswerB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerB.ForeColor = System.Drawing.Color.White;
            this.lblAnswerB.Location = new System.Drawing.Point(454, 0);
            this.lblAnswerB.Name = "lblAnswerB";
            this.lblAnswerB.Size = new System.Drawing.Size(429, 88);
            this.lblAnswerB.TabIndex = 45;
            this.lblAnswerB.Text = "lblAnswerB";
            this.lblAnswerB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerA
            // 
            this.lblAnswerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAnswerA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerA.ForeColor = System.Drawing.Color.White;
            this.lblAnswerA.Location = new System.Drawing.Point(3, 0);
            this.lblAnswerA.Name = "lblAnswerA";
            this.lblAnswerA.Size = new System.Drawing.Size(429, 88);
            this.lblAnswerA.TabIndex = 44;
            this.lblAnswerA.Text = "lblAnswerA";
            this.lblAnswerA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Location = new System.Drawing.Point(701, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 42);
            this.panel1.TabIndex = 12;
            // 
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderRadius = 20;
            this.btnNext.BorderThickness = 2;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.Enabled = false;
            this.btnNext.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnNext.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.HoverState.Image")));
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageSize = new System.Drawing.Size(52, 52);
            this.btnNext.Location = new System.Drawing.Point(558, 328);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(137, 58);
            this.btnNext.TabIndex = 11;
            this.btnNext.UseTransparentBackground = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSend
            // 
            this.btnSend.Animated = true;
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BorderColor = System.Drawing.Color.Transparent;
            this.btnSend.BorderRadius = 20;
            this.btnSend.BorderThickness = 2;
            this.btnSend.CheckedState.Parent = this.btnSend;
            this.btnSend.CustomImages.Parent = this.btnSend;
            this.btnSend.FillColor = System.Drawing.Color.Transparent;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.btnSend.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnSend.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.HoverState.Image")));
            this.btnSend.HoverState.Parent = this.btnSend;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageSize = new System.Drawing.Size(52, 52);
            this.btnSend.Location = new System.Drawing.Point(710, 328);
            this.btnSend.Name = "btnSend";
            this.btnSend.ShadowDecoration.Parent = this.btnSend;
            this.btnSend.Size = new System.Drawing.Size(137, 58);
            this.btnSend.TabIndex = 10;
            this.btnSend.UseTransparentBackground = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblQuestion);
            this.panel2.Controls.Add(this.guna2CustomGradientPanel2);
            this.panel2.Controls.Add(this.guna2CustomGradientPanel4);
            this.panel2.Controls.Add(this.guna2GradientPanel3);
            this.panel2.Controls.Add(this.guna2GradientPanel1);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 132);
            this.panel2.TabIndex = 5;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(7, 7);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(877, 118);
            this.lblQuestion.TabIndex = 32;
            this.lblQuestion.Text = "lblQuestion";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2CustomGradientPanel1);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Yellow;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Yellow;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.Yellow;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(884, 7);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(8, 118);
            this.guna2CustomGradientPanel2.TabIndex = 29;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CustomGradientPanel3);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Yellow;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Yellow;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Yellow;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(8, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(0, 118);
            this.guna2CustomGradientPanel1.TabIndex = 22;
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.Yellow;
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.Yellow;
            this.guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.Yellow;
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(934, 0);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.ShadowDecoration.Parent = this.guna2CustomGradientPanel3;
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(7, 147);
            this.guna2CustomGradientPanel3.TabIndex = 22;
            // 
            // guna2CustomGradientPanel4
            // 
            this.guna2CustomGradientPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel4.FillColor = System.Drawing.Color.Lime;
            this.guna2CustomGradientPanel4.FillColor2 = System.Drawing.Color.Lime;
            this.guna2CustomGradientPanel4.FillColor3 = System.Drawing.Color.Cyan;
            this.guna2CustomGradientPanel4.FillColor4 = System.Drawing.Color.Cyan;
            this.guna2CustomGradientPanel4.Location = new System.Drawing.Point(0, 7);
            this.guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            this.guna2CustomGradientPanel4.ShadowDecoration.Parent = this.guna2CustomGradientPanel4;
            this.guna2CustomGradientPanel4.Size = new System.Drawing.Size(7, 118);
            this.guna2CustomGradientPanel4.TabIndex = 28;
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel3.FillColor = System.Drawing.Color.Aqua;
            this.guna2GradientPanel3.FillColor2 = System.Drawing.Color.Orange;
            this.guna2GradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.ShadowDecoration.Parent = this.guna2GradientPanel3;
            this.guna2GradientPanel3.Size = new System.Drawing.Size(892, 7);
            this.guna2GradientPanel3.TabIndex = 27;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(232)))), ((int)(((byte)(7)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(46)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 125);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(892, 7);
            this.guna2GradientPanel1.TabIndex = 26;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlRightBottom);
            this.pnlRight.Controls.Add(this.pnlRightTop);
            this.pnlRight.Controls.Add(this.guna2GradientPanel2);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRight.Location = new System.Drawing.Point(910, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.ShadowDecoration.Parent = this.pnlRight;
            this.pnlRight.Size = new System.Drawing.Size(354, 753);
            this.pnlRight.TabIndex = 3;
            // 
            // pnlRightBottom
            // 
            this.pnlRightBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlRightBottom.Controls.Add(this.lvListPlayer);
            this.pnlRightBottom.Controls.Add(this.label4);
            this.pnlRightBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightBottom.Location = new System.Drawing.Point(5, 376);
            this.pnlRightBottom.Name = "pnlRightBottom";
            this.pnlRightBottom.ShadowDecoration.Parent = this.pnlRightBottom;
            this.pnlRightBottom.Size = new System.Drawing.Size(349, 376);
            this.pnlRightBottom.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 34);
            this.label4.TabIndex = 36;
            this.label4.Text = "Rank";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRightTop
            // 
            this.pnlRightTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlRightTop.Controls.Add(this.grvListQuestion);
            this.pnlRightTop.Controls.Add(this.panel3);
            this.pnlRightTop.Controls.Add(this.label3);
            this.pnlRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTop.Location = new System.Drawing.Point(5, 0);
            this.pnlRightTop.Name = "pnlRightTop";
            this.pnlRightTop.ShadowDecoration.Parent = this.pnlRightTop;
            this.pnlRightTop.Size = new System.Drawing.Size(349, 376);
            this.pnlRightTop.TabIndex = 7;
            // 
            // grvListQuestion
            // 
            this.grvListQuestion.AllowUserToAddRows = false;
            this.grvListQuestion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grvListQuestion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvListQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvListQuestion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvListQuestion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
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
            this.grvListQuestion.Location = new System.Drawing.Point(0, 34);
            this.grvListQuestion.Name = "grvListQuestion";
            this.grvListQuestion.ReadOnly = true;
            this.grvListQuestion.RowHeadersVisible = false;
            this.grvListQuestion.RowHeadersWidth = 51;
            this.grvListQuestion.RowTemplate.Height = 24;
            this.grvListQuestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvListQuestion.Size = new System.Drawing.Size(349, 337);
            this.grvListQuestion.TabIndex = 38;
            this.grvListQuestion.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.grvListQuestion.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grvListQuestion.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grvListQuestion.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grvListQuestion.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grvListQuestion.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grvListQuestion.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
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
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aqua;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel3.Location = new System.Drawing.Point(0, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 5);
            this.panel3.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 34);
            this.label3.TabIndex = 35;
            this.label3.Text = "List question";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.Black;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.Aqua;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(5, 753);
            this.guna2GradientPanel2.TabIndex = 6;
            // 
            // tmrCountDown
            // 
            this.tmrCountDown.Interval = 1000;
            this.tmrCountDown.Tick += new System.EventHandler(this.CountDown_Tick);
            // 
            // elipseClock
            // 
            this.elipseClock.BorderRadius = 100;
            this.elipseClock.TargetControl = this.proCountDown;
            // 
            // lvListPlayer
            // 
            this.lvListPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvListPlayer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvListPlayer.HideSelection = false;
            this.lvListPlayer.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvListPlayer.Location = new System.Drawing.Point(0, 34);
            this.lvListPlayer.Name = "lvListPlayer";
            this.lvListPlayer.ShowItemToolTips = true;
            this.lvListPlayer.Size = new System.Drawing.Size(349, 342);
            this.lvListPlayer.TabIndex = 37;
            this.lvListPlayer.UseCompatibleStateImageBehavior = false;
            this.lvListPlayer.View = System.Windows.Forms.View.Tile;
            // 
            // MC_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Name = "MC_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MC_UI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MC_UI_FormClosing);
            this.Load += new System.EventHandler(this.MC_UI_Load);
            this.SizeChanged += new System.EventHandler(this.MC_UI_SizeChanged);
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlContainsTopic.ResumeLayout(false);
            this.pnlCamera.ResumeLayout(false);
            this.proCountDown.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnLeftBottom.ResumeLayout(false);
            this.pnlContainsQuestion.ResumeLayout(false);
            this.pnlAnswerGroup.ResumeLayout(false);
            this.pnlAnswerGroup.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRightBottom.ResumeLayout(false);
            this.pnlRightTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvListQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseNumberWatching;
        private System.Windows.Forms.Panel pnlLeftTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnLeftBottom;
        private Guna.UI2.WinForms.Guna2Panel pnlContainsQuestion;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblQuestion;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlRight;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlRightBottom;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlRightTop;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Panel pnlAnswerGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAnswerD;
        private System.Windows.Forms.Label lblAnswerC;
        private System.Windows.Forms.Label lblAnswerB;
        private System.Windows.Forms.Label lblAnswerA;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView grvListQuestion;
        private Guna.UI2.WinForms.Guna2Panel pnlContainsTopic;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Panel pnlCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTopicInfor;
        private DTOProject.numberPeopleWacthing npwBox;
        private System.Windows.Forms.Timer tmrCountDown;
        private Guna.UI2.WinForms.Guna2Elipse elipseClock;
        private Guna.UI2.WinForms.Guna2CircleProgressBar proCountDown;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.ListView lvListPlayer;
    }
}