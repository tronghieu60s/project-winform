namespace project_winform
{
    partial class frmMainStudent
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
            this.lvwRegister = new System.Windows.Forms.ListView();
            this.mnuStripListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.lblPassNew = new System.Windows.Forms.Label();
            this.lblPassOld = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.cboFaculty = new System.Windows.Forms.ComboBox();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtRePassNew = new System.Windows.Forms.TextBox();
            this.lblRePassNew = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCodeNum = new System.Windows.Forms.TextBox();
            this.btnPassGenerator = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassOld = new System.Windows.Forms.TextBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblCodeNum = new System.Windows.Forms.Label();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.lblWelcomeSlogan = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lvwRegistered = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameRegister = new System.Windows.Forms.TextBox();
            this.txtIdRegister = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancelRegister = new System.Windows.Forms.Button();
            this.txtCancelIdRegister = new System.Windows.Forms.TextBox();
            this.txtCancelNameRegister = new System.Windows.Forms.TextBox();
            this.mnuStripListView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwRegister
            // 
            this.lvwRegister.HideSelection = false;
            this.lvwRegister.Location = new System.Drawing.Point(469, 99);
            this.lvwRegister.Name = "lvwRegister";
            this.lvwRegister.Size = new System.Drawing.Size(703, 264);
            this.lvwRegister.TabIndex = 0;
            this.lvwRegister.UseCompatibleStateImageBehavior = false;
            this.lvwRegister.SelectedIndexChanged += new System.EventHandler(this.lvwRegister_SelectedIndexChanged);
            // 
            // mnuStripListView
            // 
            this.mnuStripListView.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuStripListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.mnuStripListView.Name = "contextMenuStrip1";
            this.mnuStripListView.Size = new System.Drawing.Size(116, 36);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Enabled = false;
            this.dtpBirthday.Location = new System.Drawing.Point(166, 142);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(175, 26);
            this.dtpBirthday.TabIndex = 9;
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(187, 61);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Size = new System.Drawing.Size(179, 26);
            this.txtPassNew.TabIndex = 2;
            this.txtPassNew.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassNew_Validating);
            // 
            // lblPassNew
            // 
            this.lblPassNew.AutoSize = true;
            this.lblPassNew.Location = new System.Drawing.Point(67, 64);
            this.lblPassNew.Name = "lblPassNew";
            this.lblPassNew.Size = new System.Drawing.Size(110, 20);
            this.lblPassNew.TabIndex = 0;
            this.lblPassNew.Text = "Mật Khẩu Mới:";
            // 
            // lblPassOld
            // 
            this.lblPassOld.AutoSize = true;
            this.lblPassOld.Location = new System.Drawing.Point(67, 26);
            this.lblPassOld.Name = "lblPassOld";
            this.lblPassOld.Size = new System.Drawing.Size(105, 20);
            this.lblPassOld.TabIndex = 0;
            this.lblPassOld.Text = "Mật Khẩu Cũ:";
            // 
            // cboClass
            // 
            this.cboClass.Enabled = false;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(166, 272);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(186, 28);
            this.cboClass.TabIndex = 14;
            // 
            // cboFaculty
            // 
            this.cboFaculty.Enabled = false;
            this.cboFaculty.FormattingEnabled = true;
            this.cboFaculty.Location = new System.Drawing.Point(166, 228);
            this.cboFaculty.Name = "cboFaculty";
            this.cboFaculty.Size = new System.Drawing.Size(214, 28);
            this.cboFaculty.TabIndex = 12;
            // 
            // cboCourse
            // 
            this.cboCourse.Enabled = false;
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(166, 184);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(156, 28);
            this.cboCourse.TabIndex = 10;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.Menu;
            this.btnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword.Location = new System.Drawing.Point(84, 138);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(128, 37);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Đổi Mật Khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtRePassNew
            // 
            this.txtRePassNew.Location = new System.Drawing.Point(187, 100);
            this.txtRePassNew.Name = "txtRePassNew";
            this.txtRePassNew.Size = new System.Drawing.Size(179, 26);
            this.txtRePassNew.TabIndex = 3;
            this.txtRePassNew.Validating += new System.ComponentModel.CancelEventHandler(this.txtRePassNew_Validating);
            // 
            // lblRePassNew
            // 
            this.lblRePassNew.AutoSize = true;
            this.lblRePassNew.Location = new System.Drawing.Point(67, 103);
            this.lblRePassNew.Name = "lblRePassNew";
            this.lblRePassNew.Size = new System.Drawing.Size(76, 20);
            this.lblRePassNew.TabIndex = 0;
            this.lblRePassNew.Text = "Nhập Lại:";
            // 
            // txtFullName
            // 
            this.txtFullName.Enabled = false;
            this.txtFullName.Location = new System.Drawing.Point(166, 100);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(216, 26);
            this.txtFullName.TabIndex = 8;
            // 
            // txtCodeNum
            // 
            this.txtCodeNum.Enabled = false;
            this.txtCodeNum.Location = new System.Drawing.Point(166, 58);
            this.txtCodeNum.Name = "txtCodeNum";
            this.txtCodeNum.ReadOnly = true;
            this.txtCodeNum.Size = new System.Drawing.Size(156, 26);
            this.txtCodeNum.TabIndex = 6;
            // 
            // btnPassGenerator
            // 
            this.btnPassGenerator.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPassGenerator.ForeColor = System.Drawing.Color.Black;
            this.btnPassGenerator.Location = new System.Drawing.Point(227, 138);
            this.btnPassGenerator.Name = "btnPassGenerator";
            this.btnPassGenerator.Size = new System.Drawing.Size(153, 37);
            this.btnPassGenerator.TabIndex = 5;
            this.btnPassGenerator.Text = "Tự Tạo Mật Khẩu";
            this.btnPassGenerator.UseVisualStyleBackColor = false;
            this.btnPassGenerator.Click += new System.EventHandler(this.btnPassGenerator_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnPassGenerator);
            this.groupBox1.Controls.Add(this.btnChangePassword);
            this.groupBox1.Controls.Add(this.txtRePassNew);
            this.groupBox1.Controls.Add(this.lblRePassNew);
            this.groupBox1.Controls.Add(this.txtPassNew);
            this.groupBox1.Controls.Add(this.lblPassNew);
            this.groupBox1.Controls.Add(this.txtPassOld);
            this.groupBox1.Controls.Add(this.lblPassOld);
            this.groupBox1.Location = new System.Drawing.Point(11, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 195);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mật khẩu";
            // 
            // txtPassOld
            // 
            this.txtPassOld.Location = new System.Drawing.Point(187, 23);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.Size = new System.Drawing.Size(151, 26);
            this.txtPassOld.TabIndex = 1;
            this.txtPassOld.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassOld_Validating);
            // 
            // picMinimize
            // 
            this.picMinimize.Location = new System.Drawing.Point(1119, 9);
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
            this.picExit.Location = new System.Drawing.Point(1161, 9);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(27, 28);
            this.picExit.TabIndex = 0;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseLeave += new System.EventHandler(this.picIcon_MouseLeave);
            this.picExit.MouseHover += new System.EventHandler(this.picIcon_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dtpBirthday);
            this.groupBox2.Controls.Add(this.cboClass);
            this.groupBox2.Controls.Add(this.cboFaculty);
            this.groupBox2.Controls.Add(this.cboCourse);
            this.groupBox2.Controls.Add(this.txtFullName);
            this.groupBox2.Controls.Add(this.txtCodeNum);
            this.groupBox2.Controls.Add(this.lblFaculty);
            this.groupBox2.Controls.Add(this.lblClass);
            this.groupBox2.Controls.Add(this.lblCourse);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblFullName);
            this.groupBox2.Controls.Add(this.lblCodeNum);
            this.groupBox2.Location = new System.Drawing.Point(11, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 342);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(51, 231);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(50, 20);
            this.lblFaculty.TabIndex = 0;
            this.lblFaculty.Text = "Khoa:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(51, 275);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(40, 20);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Lớp:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(51, 187);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(50, 20);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Khóa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Sinh:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(51, 103);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(65, 20);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Họ Tên:";
            // 
            // lblCodeNum
            // 
            this.lblCodeNum.AutoSize = true;
            this.lblCodeNum.Location = new System.Drawing.Point(51, 61);
            this.lblCodeNum.Name = "lblCodeNum";
            this.lblCodeNum.Size = new System.Drawing.Size(59, 20);
            this.lblCodeNum.TabIndex = 0;
            this.lblCodeNum.Text = "Mã Số:";
            // 
            // picLogout
            // 
            this.picLogout.Location = new System.Drawing.Point(367, 93);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(26, 25);
            this.picLogout.TabIndex = 31;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // lblWelcomeSlogan
            // 
            this.lblWelcomeSlogan.AutoSize = true;
            this.lblWelcomeSlogan.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeSlogan.Location = new System.Drawing.Point(9, 93);
            this.lblWelcomeSlogan.Name = "lblWelcomeSlogan";
            this.lblWelcomeSlogan.Size = new System.Drawing.Size(320, 36);
            this.lblWelcomeSlogan.TabIndex = 30;
            this.lblWelcomeSlogan.Text = "Bạn đang đăng nhập với dữ liệu của học sinh\r\nbạn có thể đăng kí môn ở đây.\r\n";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(9, 61);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(225, 24);
            this.lblWelcome.TabIndex = 28;
            this.lblWelcome.Text = "Xin chào Administrator";
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.picMinimize);
            this.pnlTitleBar.Controls.Add(this.picExit);
            this.pnlTitleBar.Location = new System.Drawing.Point(-16, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1242, 46);
            this.pnlTitleBar.TabIndex = 27;
            this.pnlTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // lvwRegistered
            // 
            this.lvwRegistered.HideSelection = false;
            this.lvwRegistered.Location = new System.Drawing.Point(469, 417);
            this.lvwRegistered.Name = "lvwRegistered";
            this.lvwRegistered.Size = new System.Drawing.Size(703, 264);
            this.lvwRegistered.TabIndex = 39;
            this.lvwRegistered.UseCompatibleStateImageBehavior = false;
            this.lvwRegistered.SelectedIndexChanged += new System.EventHandler(this.lvwRegistered_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Môn Chưa Đăng Ký";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Môn Đã Đăng Ký";
            // 
            // txtNameRegister
            // 
            this.txtNameRegister.Enabled = false;
            this.txtNameRegister.Location = new System.Drawing.Point(883, 61);
            this.txtNameRegister.Name = "txtNameRegister";
            this.txtNameRegister.Size = new System.Drawing.Size(193, 26);
            this.txtNameRegister.TabIndex = 42;
            // 
            // txtIdRegister
            // 
            this.txtIdRegister.Enabled = false;
            this.txtIdRegister.Location = new System.Drawing.Point(777, 61);
            this.txtIdRegister.Name = "txtIdRegister";
            this.txtIdRegister.Size = new System.Drawing.Size(100, 26);
            this.txtIdRegister.TabIndex = 28;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(1082, 58);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 35);
            this.btnRegister.TabIndex = 44;
            this.btnRegister.Text = "Đăng Ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancelRegister
            // 
            this.btnCancelRegister.Location = new System.Drawing.Point(1038, 378);
            this.btnCancelRegister.Name = "btnCancelRegister";
            this.btnCancelRegister.Size = new System.Drawing.Size(134, 35);
            this.btnCancelRegister.TabIndex = 47;
            this.btnCancelRegister.Text = "Hủy Đăng Ký";
            this.btnCancelRegister.UseVisualStyleBackColor = true;
            this.btnCancelRegister.Click += new System.EventHandler(this.btnCancelRegister_Click);
            // 
            // txtCancelIdRegister
            // 
            this.txtCancelIdRegister.Enabled = false;
            this.txtCancelIdRegister.Location = new System.Drawing.Point(733, 382);
            this.txtCancelIdRegister.Name = "txtCancelIdRegister";
            this.txtCancelIdRegister.Size = new System.Drawing.Size(100, 26);
            this.txtCancelIdRegister.TabIndex = 45;
            // 
            // txtCancelNameRegister
            // 
            this.txtCancelNameRegister.Enabled = false;
            this.txtCancelNameRegister.Location = new System.Drawing.Point(839, 382);
            this.txtCancelNameRegister.Name = "txtCancelNameRegister";
            this.txtCancelNameRegister.Size = new System.Drawing.Size(193, 26);
            this.txtCancelNameRegister.TabIndex = 46;
            // 
            // frmMainStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 694);
            this.Controls.Add(this.btnCancelRegister);
            this.Controls.Add(this.txtCancelIdRegister);
            this.Controls.Add(this.txtCancelNameRegister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtIdRegister);
            this.Controls.Add(this.txtNameRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwRegistered);
            this.Controls.Add(this.lvwRegister);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picLogout);
            this.Controls.Add(this.lblWelcomeSlogan);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlTitleBar);
            this.Name = "frmMainStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainStudent";
            this.Load += new System.EventHandler(this.frmMainStudent_Load);
            this.mnuStripListView.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvwRegister;
        private System.Windows.Forms.ContextMenuStrip mnuStripListView;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.Label lblPassNew;
        private System.Windows.Forms.Label lblPassOld;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.ComboBox cboFaculty;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtRePassNew;
        private System.Windows.Forms.Label lblRePassNew;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtCodeNum;
        private System.Windows.Forms.Button btnPassGenerator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassOld;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblCodeNum;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Label lblWelcomeSlogan;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.ListView lvwRegistered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameRegister;
        private System.Windows.Forms.TextBox txtIdRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancelRegister;
        private System.Windows.Forms.TextBox txtCancelIdRegister;
        private System.Windows.Forms.TextBox txtCancelNameRegister;
    }
}