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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.mnuStripListView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwRegister
            // 
            this.lvwRegister.HideSelection = false;
            this.lvwRegister.Location = new System.Drawing.Point(313, 64);
            this.lvwRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwRegister.Name = "lvwRegister";
            this.lvwRegister.Size = new System.Drawing.Size(470, 173);
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
            this.mnuStripListView.Size = new System.Drawing.Size(95, 26);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Enabled = false;
            this.dtpBirthday.Location = new System.Drawing.Point(111, 92);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(118, 20);
            this.dtpBirthday.TabIndex = 9;
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(125, 40);
            this.txtPassNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Size = new System.Drawing.Size(121, 20);
            this.txtPassNew.TabIndex = 2;
            this.txtPassNew.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassNew_Validating);
            // 
            // lblPassNew
            // 
            this.lblPassNew.AutoSize = true;
            this.lblPassNew.Location = new System.Drawing.Point(45, 42);
            this.lblPassNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassNew.Name = "lblPassNew";
            this.lblPassNew.Size = new System.Drawing.Size(76, 13);
            this.lblPassNew.TabIndex = 0;
            this.lblPassNew.Text = "Mật Khẩu Mới:";
            // 
            // lblPassOld
            // 
            this.lblPassOld.AutoSize = true;
            this.lblPassOld.Location = new System.Drawing.Point(45, 17);
            this.lblPassOld.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassOld.Name = "lblPassOld";
            this.lblPassOld.Size = new System.Drawing.Size(72, 13);
            this.lblPassOld.TabIndex = 0;
            this.lblPassOld.Text = "Mật Khẩu Cũ:";
            // 
            // cboClass
            // 
            this.cboClass.Enabled = false;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(111, 177);
            this.cboClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(125, 21);
            this.cboClass.TabIndex = 14;
            // 
            // cboFaculty
            // 
            this.cboFaculty.Enabled = false;
            this.cboFaculty.FormattingEnabled = true;
            this.cboFaculty.Location = new System.Drawing.Point(111, 148);
            this.cboFaculty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboFaculty.Name = "cboFaculty";
            this.cboFaculty.Size = new System.Drawing.Size(144, 21);
            this.cboFaculty.TabIndex = 12;
            // 
            // cboCourse
            // 
            this.cboCourse.Enabled = false;
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(111, 120);
            this.cboCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(105, 21);
            this.cboCourse.TabIndex = 10;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.Menu;
            this.btnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword.Location = new System.Drawing.Point(56, 90);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(85, 24);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Đổi Mật Khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtRePassNew
            // 
            this.txtRePassNew.Location = new System.Drawing.Point(125, 65);
            this.txtRePassNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRePassNew.Name = "txtRePassNew";
            this.txtRePassNew.Size = new System.Drawing.Size(121, 20);
            this.txtRePassNew.TabIndex = 3;
            this.txtRePassNew.Validating += new System.ComponentModel.CancelEventHandler(this.txtRePassNew_Validating);
            // 
            // lblRePassNew
            // 
            this.lblRePassNew.AutoSize = true;
            this.lblRePassNew.Location = new System.Drawing.Point(45, 67);
            this.lblRePassNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRePassNew.Name = "lblRePassNew";
            this.lblRePassNew.Size = new System.Drawing.Size(53, 13);
            this.lblRePassNew.TabIndex = 0;
            this.lblRePassNew.Text = "Nhập Lại:";
            // 
            // txtFullName
            // 
            this.txtFullName.Enabled = false;
            this.txtFullName.Location = new System.Drawing.Point(111, 65);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(145, 20);
            this.txtFullName.TabIndex = 8;
            // 
            // txtCodeNum
            // 
            this.txtCodeNum.Enabled = false;
            this.txtCodeNum.Location = new System.Drawing.Point(111, 38);
            this.txtCodeNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodeNum.Name = "txtCodeNum";
            this.txtCodeNum.ReadOnly = true;
            this.txtCodeNum.Size = new System.Drawing.Size(105, 20);
            this.txtCodeNum.TabIndex = 6;
            // 
            // btnPassGenerator
            // 
            this.btnPassGenerator.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPassGenerator.ForeColor = System.Drawing.Color.Black;
            this.btnPassGenerator.Location = new System.Drawing.Point(151, 90);
            this.btnPassGenerator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPassGenerator.Name = "btnPassGenerator";
            this.btnPassGenerator.Size = new System.Drawing.Size(102, 24);
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
            this.groupBox1.Location = new System.Drawing.Point(7, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(295, 127);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mật khẩu";
            // 
            // txtPassOld
            // 
            this.txtPassOld.Location = new System.Drawing.Point(125, 15);
            this.txtPassOld.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.Size = new System.Drawing.Size(102, 20);
            this.txtPassOld.TabIndex = 1;
            this.txtPassOld.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassOld_Validating);
            // 
            // picMinimize
            // 
            this.picMinimize.Location = new System.Drawing.Point(746, 6);
            this.picMinimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(18, 18);
            this.picMinimize.TabIndex = 0;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            this.picMinimize.MouseLeave += new System.EventHandler(this.picIcon_MouseLeave);
            this.picMinimize.MouseHover += new System.EventHandler(this.picIcon_MouseHover);
            // 
            // picExit
            // 
            this.picExit.Location = new System.Drawing.Point(774, 6);
            this.picExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(18, 18);
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
            this.groupBox2.Location = new System.Drawing.Point(7, 220);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(295, 222);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(34, 150);
            this.lblFaculty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(35, 13);
            this.lblFaculty.TabIndex = 0;
            this.lblFaculty.Text = "Khoa:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(34, 179);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(28, 13);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Lớp:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(34, 122);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(35, 13);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Khóa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Sinh:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(34, 67);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(46, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Họ Tên:";
            // 
            // lblCodeNum
            // 
            this.lblCodeNum.AutoSize = true;
            this.lblCodeNum.Location = new System.Drawing.Point(34, 40);
            this.lblCodeNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodeNum.Name = "lblCodeNum";
            this.lblCodeNum.Size = new System.Drawing.Size(41, 13);
            this.lblCodeNum.TabIndex = 0;
            this.lblCodeNum.Text = "Mã Số:";
            // 
            // picLogout
            // 
            this.picLogout.Location = new System.Drawing.Point(245, 60);
            this.picLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(17, 16);
            this.picLogout.TabIndex = 31;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // lblWelcomeSlogan
            // 
            this.lblWelcomeSlogan.AutoSize = true;
            this.lblWelcomeSlogan.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeSlogan.Location = new System.Drawing.Point(6, 60);
            this.lblWelcomeSlogan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcomeSlogan.Name = "lblWelcomeSlogan";
            this.lblWelcomeSlogan.Size = new System.Drawing.Size(225, 28);
            this.lblWelcomeSlogan.TabIndex = 30;
            this.lblWelcomeSlogan.Text = "Bạn đang đăng nhập với dữ liệu của học sinh\r\nbạn có thể đăng kí môn ở đây.\r\n";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(6, 40);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(165, 16);
            this.lblWelcome.TabIndex = 28;
            this.lblWelcome.Text = "Xin chào Administrator";
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.picLogo);
            this.pnlTitleBar.Controls.Add(this.picMinimize);
            this.pnlTitleBar.Controls.Add(this.picExit);
            this.pnlTitleBar.Location = new System.Drawing.Point(-11, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(828, 30);
            this.pnlTitleBar.TabIndex = 27;
            this.pnlTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // lvwRegistered
            // 
            this.lvwRegistered.HideSelection = false;
            this.lvwRegistered.Location = new System.Drawing.Point(313, 271);
            this.lvwRegistered.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwRegistered.Name = "lvwRegistered";
            this.lvwRegistered.Size = new System.Drawing.Size(470, 173);
            this.lvwRegistered.TabIndex = 39;
            this.lvwRegistered.UseCompatibleStateImageBehavior = false;
            this.lvwRegistered.SelectedIndexChanged += new System.EventHandler(this.lvwRegistered_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Môn Chưa Đăng Ký";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Môn Đã Đăng Ký";
            // 
            // txtNameRegister
            // 
            this.txtNameRegister.Enabled = false;
            this.txtNameRegister.Location = new System.Drawing.Point(589, 40);
            this.txtNameRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameRegister.Name = "txtNameRegister";
            this.txtNameRegister.Size = new System.Drawing.Size(130, 20);
            this.txtNameRegister.TabIndex = 42;
            // 
            // txtIdRegister
            // 
            this.txtIdRegister.Enabled = false;
            this.txtIdRegister.Location = new System.Drawing.Point(518, 40);
            this.txtIdRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdRegister.Name = "txtIdRegister";
            this.txtIdRegister.Size = new System.Drawing.Size(68, 20);
            this.txtIdRegister.TabIndex = 28;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(721, 38);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(60, 23);
            this.btnRegister.TabIndex = 44;
            this.btnRegister.Text = "Đăng Ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancelRegister
            // 
            this.btnCancelRegister.Location = new System.Drawing.Point(692, 246);
            this.btnCancelRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelRegister.Name = "btnCancelRegister";
            this.btnCancelRegister.Size = new System.Drawing.Size(89, 23);
            this.btnCancelRegister.TabIndex = 47;
            this.btnCancelRegister.Text = "Hủy Đăng Ký";
            this.btnCancelRegister.UseVisualStyleBackColor = true;
            this.btnCancelRegister.Click += new System.EventHandler(this.btnCancelRegister_Click);
            // 
            // txtCancelIdRegister
            // 
            this.txtCancelIdRegister.Enabled = false;
            this.txtCancelIdRegister.Location = new System.Drawing.Point(489, 248);
            this.txtCancelIdRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCancelIdRegister.Name = "txtCancelIdRegister";
            this.txtCancelIdRegister.Size = new System.Drawing.Size(68, 20);
            this.txtCancelIdRegister.TabIndex = 45;
            // 
            // txtCancelNameRegister
            // 
            this.txtCancelNameRegister.Enabled = false;
            this.txtCancelNameRegister.Location = new System.Drawing.Point(559, 248);
            this.txtCancelNameRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCancelNameRegister.Name = "txtCancelNameRegister";
            this.txtCancelNameRegister.Size = new System.Drawing.Size(130, 20);
            this.txtCancelNameRegister.TabIndex = 46;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(22, 6);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(18, 18);
            this.picLogo.TabIndex = 48;
            this.picLogo.TabStop = false;
            // 
            // frmMainStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 456);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMainStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainStudent";
            this.Load += new System.EventHandler(this.frmMainStudent_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.mnuStripListView.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
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
        private System.Windows.Forms.PictureBox picLogo;
    }
}