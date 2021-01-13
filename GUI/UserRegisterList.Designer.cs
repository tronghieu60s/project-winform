namespace project_winform.GUI
{
    partial class frmUserRegisterList
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
            this.lvwRegister = new System.Windows.Forms.ListView();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwRegister
            // 
            this.lvwRegister.HideSelection = false;
            this.lvwRegister.Location = new System.Drawing.Point(11, 37);
            this.lvwRegister.Margin = new System.Windows.Forms.Padding(2);
            this.lvwRegister.Name = "lvwRegister";
            this.lvwRegister.Size = new System.Drawing.Size(519, 215);
            this.lvwRegister.TabIndex = 0;
            this.lvwRegister.UseCompatibleStateImageBehavior = false;
            this.lvwRegister.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwRegister_ColumnClick);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.label1);
            this.pnlTitleBar.Controls.Add(this.picMinimize);
            this.pnlTitleBar.Controls.Add(this.picExit);
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(548, 30);
            this.pnlTitleBar.TabIndex = 12;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // picMinimize
            // 
            this.picMinimize.Location = new System.Drawing.Point(482, 8);
            this.picMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(18, 18);
            this.picMinimize.TabIndex = 27;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            this.picMinimize.MouseLeave += new System.EventHandler(this.picIcon_MouseLeave);
            this.picMinimize.MouseHover += new System.EventHandler(this.picIcon_MouseHover);
            // 
            // picExit
            // 
            this.picExit.Location = new System.Drawing.Point(510, 8);
            this.picExit.Margin = new System.Windows.Forms.Padding(2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(18, 18);
            this.picExit.TabIndex = 29;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseLeave += new System.EventHandler(this.picIcon_MouseLeave);
            this.picExit.MouseHover += new System.EventHandler(this.picIcon_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Môn Đăng Ký";
            // 
            // frmUserRegisterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 263);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.lvwRegister);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUserRegisterList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserRegisterList";
            this.Load += new System.EventHandler(this.frmUserRegisterList_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwRegister;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label label1;
    }
}