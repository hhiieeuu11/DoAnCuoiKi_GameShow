namespace Sever
{
    partial class Scores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scores));
            this.lvScores = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScores = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClosed = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // lvScores
            // 
            this.lvScores.BackgroundImageTiled = true;
            this.lvScores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colScores});
            this.lvScores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvScores.ForeColor = System.Drawing.Color.DimGray;
            this.lvScores.FullRowSelect = true;
            this.lvScores.GridLines = true;
            this.lvScores.HideSelection = false;
            this.lvScores.Location = new System.Drawing.Point(46, 37);
            this.lvScores.Name = "lvScores";
            this.lvScores.ShowItemToolTips = true;
            this.lvScores.Size = new System.Drawing.Size(710, 376);
            this.lvScores.TabIndex = 36;
            this.lvScores.UseCompatibleStateImageBehavior = false;
            this.lvScores.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Player";
            this.colId.Width = 520;
            // 
            // colScores
            // 
            this.colScores.Text = "Scores";
            this.colScores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colScores.Width = 184;
            // 
            // btnClosed
            // 
            this.btnClosed.Animated = true;
            this.btnClosed.BackColor = System.Drawing.Color.Transparent;
            this.btnClosed.CheckedState.Parent = this.btnClosed;
            this.btnClosed.CustomImages.Parent = this.btnClosed;
            this.btnClosed.FillColor = System.Drawing.Color.Transparent;
            this.btnClosed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClosed.ForeColor = System.Drawing.Color.White;
            this.btnClosed.HoverState.Parent = this.btnClosed;
            this.btnClosed.Image = ((System.Drawing.Image)(resources.GetObject("btnClosed.Image")));
            this.btnClosed.ImageSize = new System.Drawing.Size(50, 50);
            this.btnClosed.Location = new System.Drawing.Point(749, 0);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClosed.ShadowDecoration.Parent = this.btnClosed;
            this.btnClosed.Size = new System.Drawing.Size(50, 50);
            this.btnClosed.TabIndex = 37;
            this.btnClosed.UseTransparentBackground = true;
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 60;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.lvScores;
            // 
            // Scores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvScores);
            this.Controls.Add(this.btnClosed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvScores;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colScores;
        private Guna.UI2.WinForms.Guna2CircleButton btnClosed;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}