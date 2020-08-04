namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textConfNo = new System.Windows.Forms.TextBox();
            this.chkUseRandomNo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textSelectedUserID = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.axVideoChatServer1 = new AxVideoChatServerLib.AxVideoChatServer();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatServer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Port No.";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(216, 41);
            this.textPort.Margin = new System.Windows.Forms.Padding(4);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(132, 22);
            this.textPort.TabIndex = 2;
            this.textPort.Text = "1234";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conference Number";
            // 
            // textConfNo
            // 
            this.textConfNo.Location = new System.Drawing.Point(216, 90);
            this.textConfNo.Margin = new System.Windows.Forms.Padding(4);
            this.textConfNo.Name = "textConfNo";
            this.textConfNo.Size = new System.Drawing.Size(132, 22);
            this.textConfNo.TabIndex = 2;
            // 
            // chkUseRandomNo
            // 
            this.chkUseRandomNo.AutoSize = true;
            this.chkUseRandomNo.Checked = true;
            this.chkUseRandomNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseRandomNo.Location = new System.Drawing.Point(457, 43);
            this.chkUseRandomNo.Margin = new System.Windows.Forms.Padding(4);
            this.chkUseRandomNo.Name = "chkUseRandomNo";
            this.chkUseRandomNo.Size = new System.Drawing.Size(379, 21);
            this.chkUseRandomNo.TabIndex = 3;
            this.chkUseRandomNo.Text = "The Conference Number, User ID use Random Number";
            this.chkUseRandomNo.UseVisualStyleBackColor = true;
            this.chkUseRandomNo.CheckedChanged += new System.EventHandler(this.chkUseRandomNo_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "User ID  (if the user connected, it will mark *** )";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(457, 114);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(327, 36);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create Conference";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(457, 169);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(327, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add User to this Conference ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selected User ID";
            // 
            // textSelectedUserID
            // 
            this.textSelectedUserID.Location = new System.Drawing.Point(533, 282);
            this.textSelectedUserID.Margin = new System.Windows.Forms.Padding(4);
            this.textSelectedUserID.Name = "textSelectedUserID";
            this.textSelectedUserID.Size = new System.Drawing.Size(160, 22);
            this.textSelectedUserID.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(25, 203);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(396, 436);
            this.listBox1.TabIndex = 12;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // axVideoChatServer1
            // 
            this.axVideoChatServer1.Enabled = true;
            this.axVideoChatServer1.Location = new System.Drawing.Point(504, 326);
            this.axVideoChatServer1.Name = "axVideoChatServer1";
            this.axVideoChatServer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatServer1.OcxState")));
            this.axVideoChatServer1.Size = new System.Drawing.Size(242, 164);
            this.axVideoChatServer1.TabIndex = 13;
            this.axVideoChatServer1.ClientConnected += new AxVideoChatServerLib._DVideoChatServerEvents_ClientConnectedEventHandler(this.AxVideoChatServer1_ClientConnected_1);
            this.axVideoChatServer1.ClientDisconnected += new AxVideoChatServerLib._DVideoChatServerEvents_ClientDisconnectedEventHandler(this.AxVideoChatServer1_ClientDisconnected_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 678);
            this.Controls.Add(this.axVideoChatServer1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textSelectedUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkUseRandomNo);
            this.Controls.Add(this.textConfNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Video Chat Pro Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatServer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textConfNo;
        private System.Windows.Forms.CheckBox chkUseRandomNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSelectedUserID;
        private System.Windows.Forms.ListBox listBox1;
        private AxVideoChatServerLib.AxVideoChatServer axVideoChatServer1;
    }
}

