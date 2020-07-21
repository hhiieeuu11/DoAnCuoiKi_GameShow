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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer tmrCountDown;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cboFillGame = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlFillGame = new System.Windows.Forms.Panel();
            tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 302);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(483, 302);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pnlFillGame);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(483, 299);
            this.panel6.TabIndex = 42;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Cyan;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(480, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(3, 299);
            this.panel11.TabIndex = 37;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Cyan;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 299);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(480, 3);
            this.panel9.TabIndex = 41;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Cyan;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(480, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(3, 302);
            this.panel10.TabIndex = 37;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cboFillGame);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(480, 42);
            this.panel5.TabIndex = 42;
            // 
            // pnlFillGame
            // 
            this.pnlFillGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFillGame.Location = new System.Drawing.Point(0, 42);
            this.pnlFillGame.Name = "pnlFillGame";
            this.pnlFillGame.Size = new System.Drawing.Size(480, 257);
            this.pnlFillGame.TabIndex = 43;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(977, 603);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel pnlFillGame;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cboFillGame;
    }
}