namespace project_winform
{
    partial class frmConfigDatabase
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnTestConnect = new System.Windows.Forms.Button();
            this.btnSaveConnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(43, 135);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(233, 26);
            this.txtServer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(43, 198);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(188, 26);
            this.txtDatabase.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(43, 261);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(233, 26);
            this.txtUsername.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(43, 324);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 26);
            this.txtPassword.TabIndex = 5;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(282, 135);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(79, 26);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "3306";
            // 
            // btnTestConnect
            // 
            this.btnTestConnect.Location = new System.Drawing.Point(33, 380);
            this.btnTestConnect.Name = "btnTestConnect";
            this.btnTestConnect.Size = new System.Drawing.Size(166, 44);
            this.btnTestConnect.TabIndex = 6;
            this.btnTestConnect.Text = "Test Connection";
            this.btnTestConnect.UseVisualStyleBackColor = true;
            this.btnTestConnect.Click += new System.EventHandler(this.btnTestConnect_Click);
            // 
            // btnSaveConnect
            // 
            this.btnSaveConnect.Location = new System.Drawing.Point(226, 380);
            this.btnSaveConnect.Name = "btnSaveConnect";
            this.btnSaveConnect.Size = new System.Drawing.Size(166, 44);
            this.btnSaveConnect.TabIndex = 7;
            this.btnSaveConnect.Text = "Save Connect";
            this.btnSaveConnect.UseVisualStyleBackColor = true;
            this.btnSaveConnect.Click += new System.EventHandler(this.btnSaveConnect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "STUDENT MANAGEMENT - MYSQL";
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.picMinimize);
            this.pnlTitleBar.Controls.Add(this.picExit);
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(428, 46);
            this.pnlTitleBar.TabIndex = 10;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // picMinimize
            // 
            this.picMinimize.Location = new System.Drawing.Point(336, 9);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(27, 28);
            this.picMinimize.TabIndex = 0;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            this.picMinimize.MouseLeave += new System.EventHandler(this.picIcon_MouseLeave);
            this.picMinimize.MouseHover += new System.EventHandler(this.picIcon_MouseHover);
            // 
            // picExit
            // 
            this.picExit.Location = new System.Drawing.Point(376, 9);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(27, 28);
            this.picExit.TabIndex = 0;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseLeave += new System.EventHandler(this.picIcon_MouseLeave);
            this.picExit.MouseHover += new System.EventHandler(this.picIcon_MouseHover);
            // 
            // frmConfigDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 463);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSaveConnect);
            this.Controls.Add(this.btnTestConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.Name = "frmConfigDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigDatabase";
            this.Load += new System.EventHandler(this.frmConfigDatabase_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnTestConnect;
        private System.Windows.Forms.Button btnSaveConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picExit;
    }
}