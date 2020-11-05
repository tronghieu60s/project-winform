namespace project_winform
{
    partial class frmLogin
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCodeNum = new System.Windows.Forms.Label();
            this.txtCodeNum = new System.Windows.Forms.TextBox();
            this.lblForgetPass = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlTextCodeNum = new System.Windows.Forms.Panel();
            this.pnlTextPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picMove = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.pnlTextCodeNum.SuspendLayout();
            this.pnlTextPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(738, 144);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 33);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Chào mừng trở lại!";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.Location = new System.Drawing.Point(714, 187);
            this.lblSlogan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(317, 23);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Rất vui mừng khi được gặp lại bạn!";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(648, 356);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "MẬT KHẨU";
            // 
            // lblCodeNum
            // 
            this.lblCodeNum.AutoSize = true;
            this.lblCodeNum.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeNum.Location = new System.Drawing.Point(648, 241);
            this.lblCodeNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeNum.Name = "lblCodeNum";
            this.lblCodeNum.Size = new System.Drawing.Size(60, 19);
            this.lblCodeNum.TabIndex = 3;
            this.lblCodeNum.Text = "MÃ SỐ";
            // 
            // txtCodeNum
            // 
            this.txtCodeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeNum.Location = new System.Drawing.Point(14, 14);
            this.txtCodeNum.Name = "txtCodeNum";
            this.txtCodeNum.Size = new System.Drawing.Size(415, 30);
            this.txtCodeNum.TabIndex = 5;
            // 
            // lblForgetPass
            // 
            this.lblForgetPass.AutoSize = true;
            this.lblForgetPass.Location = new System.Drawing.Point(648, 454);
            this.lblForgetPass.Name = "lblForgetPass";
            this.lblForgetPass.Size = new System.Drawing.Size(127, 20);
            this.lblForgetPass.TabIndex = 3;
            this.lblForgetPass.TabStop = true;
            this.lblForgetPass.Text = "Quên mật khẩu?";
            this.lblForgetPass.MouseLeave += new System.EventHandler(this.lblForgetPass_MouseLeave);
            this.lblForgetPass.MouseHover += new System.EventHandler(this.lblForgetPass_MouseHover);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(652, 494);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(441, 63);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Location = new System.Drawing.Point(0, -4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(546, 734);
            this.pnlLeft.TabIndex = 7;
            // 
            // pnlTextCodeNum
            // 
            this.pnlTextCodeNum.Controls.Add(this.txtCodeNum);
            this.pnlTextCodeNum.Location = new System.Drawing.Point(652, 273);
            this.pnlTextCodeNum.Name = "pnlTextCodeNum";
            this.pnlTextCodeNum.Size = new System.Drawing.Size(441, 52);
            this.pnlTextCodeNum.TabIndex = 8;
            this.pnlTextCodeNum.Click += new System.EventHandler(this.pnlTextCodeNum_Click);
            this.pnlTextCodeNum.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTextCodeNum_Paint);
            // 
            // pnlTextPassword
            // 
            this.pnlTextPassword.Controls.Add(this.txtPassword);
            this.pnlTextPassword.Location = new System.Drawing.Point(652, 390);
            this.pnlTextPassword.Name = "pnlTextPassword";
            this.pnlTextPassword.Size = new System.Drawing.Size(441, 52);
            this.pnlTextPassword.TabIndex = 9;
            this.pnlTextPassword.Click += new System.EventHandler(this.pnlTextPassword_Click);
            this.pnlTextPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTextPassword_Paint);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(14, 14);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(415, 30);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // picMove
            // 
            this.picMove.Location = new System.Drawing.Point(1114, 12);
            this.picMove.Name = "picMove";
            this.picMove.Size = new System.Drawing.Size(27, 28);
            this.picMove.TabIndex = 11;
            this.picMove.TabStop = false;
            this.picMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMove_MouseDown);
            this.picMove.MouseLeave += new System.EventHandler(this.picIcon_MouseLeave);
            this.picMove.MouseHover += new System.EventHandler(this.picIcon_MouseHover);
            // 
            // picExit
            // 
            this.picExit.Location = new System.Drawing.Point(1162, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(27, 28);
            this.picExit.TabIndex = 12;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 723);
            this.Controls.Add(this.picMove);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.pnlTextPassword);
            this.Controls.Add(this.pnlTextCodeNum);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblForgetPass);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCodeNum);
            this.Controls.Add(this.lblPassword);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlTextCodeNum.ResumeLayout(false);
            this.pnlTextCodeNum.PerformLayout();
            this.pnlTextPassword.ResumeLayout(false);
            this.pnlTextPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCodeNum;
        private System.Windows.Forms.TextBox txtCodeNum;
        private System.Windows.Forms.LinkLabel lblForgetPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTextCodeNum;
        private System.Windows.Forms.Panel pnlTextPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picMove;
        private System.Windows.Forms.PictureBox picExit;
    }
}