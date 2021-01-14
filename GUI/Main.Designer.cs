namespace project_winform
{
    partial class frmMain
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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWelcomeSlogan = new System.Windows.Forms.Label();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.cboTypeUser = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkRandomCodeNum = new System.Windows.Forms.CheckBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboFaculty = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCodeNum = new System.Windows.Forms.TextBox();
            this.picReloadFaculty = new System.Windows.Forms.PictureBox();
            this.picReloadCourse = new System.Windows.Forms.PictureBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblCodeNum = new System.Windows.Forms.Label();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnAddFaculty = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnShowSubject = new System.Windows.Forms.Button();
            this.lvwMain = new System.Windows.Forms.ListView();
            this.lblCountItemListView = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.mnuStripListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSelectSearch = new System.Windows.Forms.ComboBox();
            this.cboAction = new System.Windows.Forms.ComboBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.picPassWord = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReloadFaculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReloadCourse)).BeginInit();
            this.mnuStripListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassWord)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.picLogo);
            this.pnlTitleBar.Controls.Add(this.picMinimize);
            this.pnlTitleBar.Controls.Add(this.picExit);
            this.pnlTitleBar.Location = new System.Drawing.Point(-2, -2);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1242, 46);
            this.pnlTitleBar.TabIndex = 0;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(18, 9);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(27, 28);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
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
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(16, 60);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(225, 24);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Xin chào Administrator";
            // 
            // lblWelcomeSlogan
            // 
            this.lblWelcomeSlogan.AutoSize = true;
            this.lblWelcomeSlogan.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeSlogan.Location = new System.Drawing.Point(16, 92);
            this.lblWelcomeSlogan.Name = "lblWelcomeSlogan";
            this.lblWelcomeSlogan.Size = new System.Drawing.Size(286, 36);
            this.lblWelcomeSlogan.TabIndex = 2;
            this.lblWelcomeSlogan.Text = "Bạn đang đăng nhập với quyền cao nhất\r\ntrong hệ thống.";
            // 
            // picLogout
            // 
            this.picLogout.Location = new System.Drawing.Point(360, 103);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(26, 25);
            this.picLogout.TabIndex = 3;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExportExcel.Location = new System.Drawing.Point(1056, 652);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(130, 32);
            this.btnExportExcel.TabIndex = 26;
            this.btnExportExcel.Text = "Xuất ra Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.SystemColors.Menu;
            this.btnImportExcel.ForeColor = System.Drawing.Color.Black;
            this.btnImportExcel.Location = new System.Drawing.Point(920, 652);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(130, 32);
            this.btnImportExcel.TabIndex = 25;
            this.btnImportExcel.Text = "Nhập từ Excel";
            this.btnImportExcel.UseVisualStyleBackColor = false;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // cboTypeUser
            // 
            this.cboTypeUser.FormattingEnabled = true;
            this.cboTypeUser.Items.AddRange(new object[] {
            "Quản Trị Viên",
            "Học Sinh"});
            this.cboTypeUser.Location = new System.Drawing.Point(478, 126);
            this.cboTypeUser.Name = "cboTypeUser";
            this.cboTypeUser.Size = new System.Drawing.Size(176, 28);
            this.cboTypeUser.TabIndex = 0;
            this.cboTypeUser.SelectedIndexChanged += new System.EventHandler(this.cboTypeUser_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chkRandomCodeNum);
            this.groupBox2.Controls.Add(this.dtpBirthday);
            this.groupBox2.Controls.Add(this.btnSubject);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.cboClass);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.cboFaculty);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.cboCourse);
            this.groupBox2.Controls.Add(this.txtFullName);
            this.groupBox2.Controls.Add(this.txtCodeNum);
            this.groupBox2.Controls.Add(this.picReloadFaculty);
            this.groupBox2.Controls.Add(this.picReloadCourse);
            this.groupBox2.Controls.Add(this.lblFaculty);
            this.groupBox2.Controls.Add(this.lblClass);
            this.groupBox2.Controls.Add(this.lblCourse);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblFullName);
            this.groupBox2.Controls.Add(this.lblCodeNum);
            this.groupBox2.Location = new System.Drawing.Point(21, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 462);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết";
            // 
            // chkRandomCodeNum
            // 
            this.chkRandomCodeNum.AutoSize = true;
            this.chkRandomCodeNum.Checked = true;
            this.chkRandomCodeNum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomCodeNum.Location = new System.Drawing.Point(318, 40);
            this.chkRandomCodeNum.Name = "chkRandomCodeNum";
            this.chkRandomCodeNum.Size = new System.Drawing.Size(114, 24);
            this.chkRandomCodeNum.TabIndex = 7;
            this.chkRandomCodeNum.Text = "ngẫu nhiên";
            this.chkRandomCodeNum.UseVisualStyleBackColor = true;
            this.chkRandomCodeNum.CheckedChanged += new System.EventHandler(this.chkRandomCodeNum_CheckedChanged);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(152, 126);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(175, 26);
            this.dtpBirthday.TabIndex = 9;
            // 
            // btnSubject
            // 
            this.btnSubject.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSubject.ForeColor = System.Drawing.Color.Black;
            this.btnSubject.Location = new System.Drawing.Point(250, 389);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(129, 46);
            this.btnSubject.TabIndex = 18;
            this.btnSubject.Text = "Môn học";
            this.btnSubject.UseVisualStyleBackColor = false;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Menu;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(250, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 46);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.UpdateUser);
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(152, 263);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(187, 28);
            this.cboClass.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(56, 389);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 46);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.DeleteUser);
            // 
            // cboFaculty
            // 
            this.cboFaculty.FormattingEnabled = true;
            this.cboFaculty.Location = new System.Drawing.Point(152, 217);
            this.cboFaculty.Name = "cboFaculty";
            this.cboFaculty.Size = new System.Drawing.Size(226, 28);
            this.cboFaculty.TabIndex = 12;
            this.cboFaculty.SelectedIndexChanged += new System.EventHandler(this.cboFaculty_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(56, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 46);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.AddUser);
            // 
            // cboCourse
            // 
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(152, 171);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(187, 28);
            this.cboCourse.TabIndex = 10;
            this.cboCourse.SelectedIndexChanged += new System.EventHandler(this.cboCourse_SelectedIndexChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(152, 82);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(216, 26);
            this.txtFullName.TabIndex = 8;
            this.txtFullName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFullName_Validating);
            // 
            // txtCodeNum
            // 
            this.txtCodeNum.Enabled = false;
            this.txtCodeNum.Location = new System.Drawing.Point(152, 37);
            this.txtCodeNum.Name = "txtCodeNum";
            this.txtCodeNum.Size = new System.Drawing.Size(156, 26);
            this.txtCodeNum.TabIndex = 6;
            this.txtCodeNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeNum_KeyPress);
            this.txtCodeNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodeNum_Validating);
            // 
            // picReloadFaculty
            // 
            this.picReloadFaculty.Location = new System.Drawing.Point(398, 220);
            this.picReloadFaculty.Name = "picReloadFaculty";
            this.picReloadFaculty.Size = new System.Drawing.Size(26, 25);
            this.picReloadFaculty.TabIndex = 3;
            this.picReloadFaculty.TabStop = false;
            this.picReloadFaculty.Click += new System.EventHandler(this.picReloadFaculty_Click);
            // 
            // picReloadCourse
            // 
            this.picReloadCourse.Location = new System.Drawing.Point(362, 174);
            this.picReloadCourse.Name = "picReloadCourse";
            this.picReloadCourse.Size = new System.Drawing.Size(26, 25);
            this.picReloadCourse.TabIndex = 3;
            this.picReloadCourse.TabStop = false;
            this.picReloadCourse.Click += new System.EventHandler(this.picReloadCourse_Click);
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(38, 225);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(50, 20);
            this.lblFaculty.TabIndex = 0;
            this.lblFaculty.Text = "Khoa:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(38, 271);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(40, 20);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Lớp:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(38, 178);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(50, 20);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Khóa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Sinh:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(38, 86);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(65, 20);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Họ Tên:";
            // 
            // lblCodeNum
            // 
            this.lblCodeNum.AutoSize = true;
            this.lblCodeNum.Location = new System.Drawing.Point(38, 40);
            this.lblCodeNum.Name = "lblCodeNum";
            this.lblCodeNum.Size = new System.Drawing.Size(59, 20);
            this.lblCodeNum.TabIndex = 0;
            this.lblCodeNum.Text = "Mã Số:";
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAddClass.ForeColor = System.Drawing.Color.Black;
            this.btnAddClass.Location = new System.Drawing.Point(864, 72);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(123, 31);
            this.btnAddClass.TabIndex = 15;
            this.btnAddClass.Text = "Lớp";
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnAddFaculty
            // 
            this.btnAddFaculty.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAddFaculty.ForeColor = System.Drawing.Color.Black;
            this.btnAddFaculty.Location = new System.Drawing.Point(675, 72);
            this.btnAddFaculty.Name = "btnAddFaculty";
            this.btnAddFaculty.Size = new System.Drawing.Size(123, 31);
            this.btnAddFaculty.TabIndex = 13;
            this.btnAddFaculty.Text = "Khoa";
            this.btnAddFaculty.UseVisualStyleBackColor = false;
            this.btnAddFaculty.Click += new System.EventHandler(this.btnAddFaculty_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAddCourse.ForeColor = System.Drawing.Color.Black;
            this.btnAddCourse.Location = new System.Drawing.Point(486, 71);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(123, 31);
            this.btnAddCourse.TabIndex = 11;
            this.btnAddCourse.Text = "Khóa";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnShowSubject
            // 
            this.btnShowSubject.BackColor = System.Drawing.SystemColors.Menu;
            this.btnShowSubject.ForeColor = System.Drawing.Color.Black;
            this.btnShowSubject.Location = new System.Drawing.Point(1053, 72);
            this.btnShowSubject.Name = "btnShowSubject";
            this.btnShowSubject.Size = new System.Drawing.Size(123, 31);
            this.btnShowSubject.TabIndex = 18;
            this.btnShowSubject.Text = "Môn Học";
            this.btnShowSubject.UseVisualStyleBackColor = false;
            this.btnShowSubject.Click += new System.EventHandler(this.btnShowSubject_Click);
            // 
            // lvwMain
            // 
            this.lvwMain.HideSelection = false;
            this.lvwMain.Location = new System.Drawing.Point(478, 163);
            this.lvwMain.Name = "lvwMain";
            this.lvwMain.Size = new System.Drawing.Size(718, 476);
            this.lvwMain.TabIndex = 22;
            this.lvwMain.UseCompatibleStateImageBehavior = false;
            this.lvwMain.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwMain_ColumnClick);
            this.lvwMain.SelectedIndexChanged += new System.EventHandler(this.lvwMain_SelectedIndexChanged);
            this.lvwMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwMain_MouseClick);
            // 
            // lblCountItemListView
            // 
            this.lblCountItemListView.AutoSize = true;
            this.lblCountItemListView.Location = new System.Drawing.Point(1142, 132);
            this.lblCountItemListView.Name = "lblCountItemListView";
            this.lblCountItemListView.Size = new System.Drawing.Size(52, 20);
            this.lblCountItemListView.TabIndex = 21;
            this.lblCountItemListView.Text = "0 mục";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(842, 126);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 26);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.DeleteUser);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(748, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tìm kiếm:";
            // 
            // cboSelectSearch
            // 
            this.cboSelectSearch.FormattingEnabled = true;
            this.cboSelectSearch.Location = new System.Drawing.Point(1042, 125);
            this.cboSelectSearch.Name = "cboSelectSearch";
            this.cboSelectSearch.Size = new System.Drawing.Size(84, 28);
            this.cboSelectSearch.TabIndex = 20;
            // 
            // cboAction
            // 
            this.cboAction.FormattingEnabled = true;
            this.cboAction.Items.AddRange(new object[] {
            "Xóa"});
            this.cboAction.Location = new System.Drawing.Point(478, 652);
            this.cboAction.Name = "cboAction";
            this.cboAction.Size = new System.Drawing.Size(121, 28);
            this.cboAction.TabIndex = 23;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(604, 651);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(99, 35);
            this.btnAction.TabIndex = 24;
            this.btnAction.Text = "Thực Hiện";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnExportReport
            // 
            this.btnExportReport.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExportReport.ForeColor = System.Drawing.Color.Black;
            this.btnExportReport.Location = new System.Drawing.Point(753, 652);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(160, 32);
            this.btnExportReport.TabIndex = 25;
            this.btnExportReport.Text = "Xuất Báo Cáo";
            this.btnExportReport.UseVisualStyleBackColor = false;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // picPassWord
            // 
            this.picPassWord.Location = new System.Drawing.Point(360, 62);
            this.picPassWord.Name = "picPassWord";
            this.picPassWord.Size = new System.Drawing.Size(26, 25);
            this.picPassWord.TabIndex = 3;
            this.picPassWord.TabStop = false;
            this.picPassWord.Click += new System.EventHandler(this.picPassWord_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 702);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.btnAddFaculty);
            this.Controls.Add(this.btnShowSubject);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnExportReport);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.cboTypeUser);
            this.Controls.Add(this.cboAction);
            this.Controls.Add(this.cboSelectSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblCountItemListView);
            this.Controls.Add(this.lvwMain);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picPassWord);
            this.Controls.Add(this.picLogout);
            this.Controls.Add(this.lblWelcomeSlogan);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlTitleBar);
            this.MinimumSize = new System.Drawing.Size(1195, 650);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReloadFaculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReloadCourse)).EndInit();
            this.mnuStripListView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPassWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWelcomeSlogan;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.ComboBox cboTypeUser;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtCodeNum;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblCodeNum;
        private System.Windows.Forms.ListView lvwMain;
        private System.Windows.Forms.Label lblCountItemListView;
        private System.Windows.Forms.ComboBox cboFaculty;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip mnuStripListView;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkRandomCodeNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnAddFaculty;
        private System.Windows.Forms.ComboBox cboSelectSearch;
        private System.Windows.Forms.ComboBox cboAction;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.PictureBox picReloadFaculty;
        private System.Windows.Forms.PictureBox picReloadCourse;
        private System.Windows.Forms.Button btnShowSubject;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picPassWord;
    }
}

