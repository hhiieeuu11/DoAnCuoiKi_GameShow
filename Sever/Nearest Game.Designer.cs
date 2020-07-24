namespace Sever
{
    partial class Nearest_Game
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
            this.pnlNearestGame = new System.Windows.Forms.Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblGameName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblGameID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.pnlNearestGame.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNearestGame
            // 
            this.pnlNearestGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlNearestGame.Controls.Add(this.guna2GradientPanel1);
            this.pnlNearestGame.Controls.Add(this.label1);
            this.pnlNearestGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNearestGame.Location = new System.Drawing.Point(0, 0);
            this.pnlNearestGame.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNearestGame.Name = "pnlNearestGame";
            this.pnlNearestGame.Size = new System.Drawing.Size(770, 550);
            this.pnlNearestGame.TabIndex = 21;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Cyan;
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.BorderThickness = 2;
            this.guna2GradientPanel1.Controls.Add(this.lblGameName);
            this.guna2GradientPanel1.Controls.Add(this.label13);
            this.guna2GradientPanel1.Controls.Add(this.lblCountDown);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.lblStartTime);
            this.guna2GradientPanel1.Controls.Add(this.lblGameID);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(12, 65);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.BorderRadius = 20;
            this.guna2GradientPanel1.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(20);
            this.guna2GradientPanel1.Size = new System.Drawing.Size(746, 464);
            this.guna2GradientPanel1.TabIndex = 37;
            // 
            // lblGameName
            // 
            this.lblGameName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.White;
            this.lblGameName.Location = new System.Drawing.Point(198, 148);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(337, 55);
            this.lblGameName.TabIndex = 16;
            this.lblGameName.Text = "#lblGameName";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(34, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 54);
            this.label13.TabIndex = 15;
            this.label13.Text = "Name :";
            // 
            // lblCountDown
            // 
            this.lblCountDown.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.White;
            this.lblCountDown.Location = new System.Drawing.Point(346, 324);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(330, 95);
            this.lblCountDown.TabIndex = 14;
            this.lblCountDown.Text = "123:45678";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 54);
            this.label5.TabIndex = 13;
            this.label5.Text = "Waiting time:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.Color.White;
            this.lblStartTime.Location = new System.Drawing.Point(246, 236);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(471, 55);
            this.lblStartTime.TabIndex = 12;
            this.lblStartTime.Text = "#lblStartTime";
            // 
            // lblGameID
            // 
            this.lblGameID.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameID.ForeColor = System.Drawing.Color.White;
            this.lblGameID.Location = new System.Drawing.Point(131, 52);
            this.lblGameID.Name = "lblGameID";
            this.lblGameID.Size = new System.Drawing.Size(375, 54);
            this.lblGameID.TabIndex = 11;
            this.lblGameID.Text = "#lblGameID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 54);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 54);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 63);
            this.label1.TabIndex = 36;
            this.label1.Text = "NEAREST GAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrCountDown
            // 
            this.tmrCountDown.Interval = 1000;
            this.tmrCountDown.Tick += new System.EventHandler(this.tmrCountDown_Tick);
            // 
            // Nearest_Game
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(770, 550);
            this.Controls.Add(this.pnlNearestGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nearest_Game";
            this.Text = "Nearest_Game";
            this.pnlNearestGame.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNearestGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrCountDown;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblGameID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}