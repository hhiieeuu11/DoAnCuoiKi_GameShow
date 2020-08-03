namespace Sever
{
    partial class Home
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFillGame = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlFillGame = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cboFillGame);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(977, 42);
            this.panel5.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Show infor game";
            // 
            // cboFillGame
            // 
            this.cboFillGame.Animated = true;
            this.cboFillGame.BackColor = System.Drawing.Color.Transparent;
            this.cboFillGame.BorderColor = System.Drawing.Color.Cyan;
            this.cboFillGame.BorderRadius = 10;
            this.cboFillGame.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFillGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFillGame.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cboFillGame.FocusedColor = System.Drawing.Color.Cyan;
            this.cboFillGame.FocusedState.BorderColor = System.Drawing.Color.Cyan;
            this.cboFillGame.FocusedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFillGame.FocusedState.Parent = this.cboFillGame;
            this.cboFillGame.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cboFillGame.ForeColor = System.Drawing.Color.Cyan;
            this.cboFillGame.HoverState.Parent = this.cboFillGame;
            this.cboFillGame.ItemHeight = 30;
            this.cboFillGame.Items.AddRange(new object[] {
            "Nearest",
            "Is being broadcast"});
            this.cboFillGame.ItemsAppearance.Parent = this.cboFillGame;
            this.cboFillGame.Location = new System.Drawing.Point(213, 3);
            this.cboFillGame.Name = "cboFillGame";
            this.cboFillGame.ShadowDecoration.Parent = this.cboFillGame;
            this.cboFillGame.Size = new System.Drawing.Size(261, 36);
            this.cboFillGame.TabIndex = 1;
            this.cboFillGame.SelectedIndexChanged += new System.EventHandler(this.cboFillGame_SelectedIndexChanged);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Controls.Add(this.pnlFillGame);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 42);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(977, 561);
            this.pnlBottom.TabIndex = 48;
            // 
            // pnlFillGame
            // 
            this.pnlFillGame.Location = new System.Drawing.Point(119, 5);
            this.pnlFillGame.Name = "pnlFillGame";
            this.pnlFillGame.Size = new System.Drawing.Size(770, 550);
            this.pnlFillGame.TabIndex = 47;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(977, 603);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.panel5);
            this.Name = "Home";
            this.Text = "Home";
            this.SizeChanged += new System.EventHandler(this.Home_SizeChanged);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cboFillGame;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlFillGame;
    }
}