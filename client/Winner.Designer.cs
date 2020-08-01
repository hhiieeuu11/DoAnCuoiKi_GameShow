namespace client
{
    partial class Winner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winner));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlRank = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClosed = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblTop1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTop3 = new System.Windows.Forms.Label();
            this.lblTop2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pnlRank.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1019, 639);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitle.Location = new System.Drawing.Point(66, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(747, 74);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WINNER";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRank
            // 
            this.pnlRank.BackColor = System.Drawing.Color.Transparent;
            this.pnlRank.BorderColor = System.Drawing.Color.Cyan;
            this.pnlRank.BorderRadius = 20;
            this.pnlRank.BorderThickness = 2;
            this.pnlRank.Controls.Add(this.btnClosed);
            this.pnlRank.Controls.Add(this.lblTop1);
            this.pnlRank.Controls.Add(this.guna2Panel1);
            this.pnlRank.Controls.Add(this.lblTitle);
            this.pnlRank.Location = new System.Drawing.Point(75, 46);
            this.pnlRank.Name = "pnlRank";
            this.pnlRank.ShadowDecoration.Parent = this.pnlRank;
            this.pnlRank.Size = new System.Drawing.Size(879, 548);
            this.pnlRank.TabIndex = 2;
            // 
            // btnClosed
            // 
            this.btnClosed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClosed.CheckedState.Parent = this.btnClosed;
            this.btnClosed.CustomImages.Parent = this.btnClosed;
            this.btnClosed.FillColor = System.Drawing.Color.Transparent;
            this.btnClosed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClosed.ForeColor = System.Drawing.Color.White;
            this.btnClosed.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnClosed.HoverState.Image")));
            this.btnClosed.HoverState.Parent = this.btnClosed;
            this.btnClosed.Image = ((System.Drawing.Image)(resources.GetObject("btnClosed.Image")));
            this.btnClosed.ImageSize = new System.Drawing.Size(60, 60);
            this.btnClosed.Location = new System.Drawing.Point(819, 3);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClosed.ShadowDecoration.Parent = this.btnClosed;
            this.btnClosed.Size = new System.Drawing.Size(60, 60);
            this.btnClosed.TabIndex = 15;
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            // 
            // lblTop1
            // 
            this.lblTop1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTop1.Location = new System.Drawing.Point(325, 86);
            this.lblTop1.Name = "lblTop1";
            this.lblTop1.Size = new System.Drawing.Size(224, 80);
            this.lblTop1.TabIndex = 8;
            this.lblTop1.Text = "Top1";
            this.lblTop1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Controls.Add(this.lblTop3);
            this.guna2Panel1.Controls.Add(this.lblTop2);
            this.guna2Panel1.Location = new System.Drawing.Point(-10, 140);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(878, 443);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lblTop3
            // 
            this.lblTop3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTop3.Location = new System.Drawing.Point(570, 204);
            this.lblTop3.Name = "lblTop3";
            this.lblTop3.Size = new System.Drawing.Size(200, 80);
            this.lblTop3.TabIndex = 8;
            this.lblTop3.Text = "Top3";
            this.lblTop3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTop2
            // 
            this.lblTop2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTop2.Location = new System.Drawing.Point(144, 157);
            this.lblTop2.Name = "lblTop2";
            this.lblTop2.Size = new System.Drawing.Size(200, 80);
            this.lblTop2.TabIndex = 9;
            this.lblTop2.Text = "Top2";
            this.lblTop2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Winner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1019, 639);
            this.Controls.Add(this.pnlRank);
            this.Controls.Add(this.guna2PictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Winner";
            this.SizeChanged += new System.EventHandler(this.Winner_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pnlRank.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlRank;
        private System.Windows.Forms.Label lblTop1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblTop3;
        private System.Windows.Forms.Label lblTop2;
        private Guna.UI2.WinForms.Guna2CircleButton btnClosed;
    }
}