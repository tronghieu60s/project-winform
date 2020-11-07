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
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picResize = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWelcomeSlogan = new System.Windows.Forms.Label();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.cboTypeUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkRandomCodeNum = new System.Windows.Forms.CheckBox();
            this.chkListManager = new System.Windows.Forms.CheckedListBox();
            this.lblManager = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboFaculty = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCodeNum = new System.Windows.Forms.TextBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblCodeNum = new System.Windows.Forms.Label();
            this.lvwMain = new System.Windows.Forms.ListView();
            this.lblCountItemListView = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.mnuStripListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaNhiềuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.radSearchCodeNum = new System.Windows.Forms.RadioButton();
            this.radSearchName = new System.Windows.Forms.RadioButton();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mnuStripListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.picMinimize);
            this.pnlTitleBar.Controls.Add(this.picResize);
            this.pnlTitleBar.Controls.Add(this.picExit);
            this.pnlTitleBar.Location = new System.Drawing.Point(-2, -2);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1242, 46);
            this.pnlTitleBar.TabIndex = 0;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // picMinimize
            // 
            this.picMinimize.Location = new System.Drawing.Point(1065, 9);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(27, 28);
            this.picMinimize.TabIndex = 0;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            this.picMinimize.MouseLeave += new System.EventHandler(this.picIcon_MouseLeave);
            this.picMinimize.MouseHover += new System.EventHandler(this.picIcon_MouseHover);
            // 
            // picResize
            // 
            this.picResize.Location = new System.Drawing.Point(1113, 9);
            this.picResize.Name = "picResize";
            this.picResize.Size = new System.Drawing.Size(27, 28);
            this.picResize.TabIndex = 0;
            this.picResize.TabStop = false;
            this.picResize.MouseLeave += new System.EventHandler(this.picIcon_MouseLeave);
            this.picResize.MouseHover += new System.EventHandler(this.picIcon_MouseHover);
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
            this.lblWelcome.Location = new System.Drawing.Point(12, 60);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(225, 24);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Xin chào Administrator";
            // 
            // lblWelcomeSlogan
            // 
            this.lblWelcomeSlogan.AutoSize = true;
            this.lblWelcomeSlogan.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeSlogan.Location = new System.Drawing.Point(12, 92);
            this.lblWelcomeSlogan.Name = "lblWelcomeSlogan";
            this.lblWelcomeSlogan.Size = new System.Drawing.Size(286, 36);
            this.lblWelcomeSlogan.TabIndex = 2;
            this.lblWelcomeSlogan.Text = "Bạn đang đăng nhập với quyền cao nhất\r\ntrong hệ thống.";
            // 
            // picLogout
            // 
            this.picLogout.Location = new System.Drawing.Point(273, 58);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(26, 25);
            this.picLogout.TabIndex = 3;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnExportExcel);
            this.groupBox1.Controls.Add(this.btnImportExcel);
            this.groupBox1.Controls.Add(this.cboTypeUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExportExcel.Location = new System.Drawing.Point(249, 101);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(147, 46);
            this.btnExportExcel.TabIndex = 7;
            this.btnExportExcel.Text = "Xuất ra Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.SystemColors.Menu;
            this.btnImportExcel.ForeColor = System.Drawing.Color.Black;
            this.btnImportExcel.Location = new System.Drawing.Point(46, 101);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(147, 46);
            this.btnImportExcel.TabIndex = 6;
            this.btnImportExcel.Text = "Nhập từ Excel";
            this.btnImportExcel.UseVisualStyleBackColor = false;
            // 
            // cboTypeUser
            // 
            this.cboTypeUser.FormattingEnabled = true;
            this.cboTypeUser.Items.AddRange(new object[] {
            "Quản Trị Viên",
            "Học Sinh",
            "Giáo Viên"});
            this.cboTypeUser.Location = new System.Drawing.Point(159, 43);
            this.cboTypeUser.Name = "cboTypeUser";
            this.cboTypeUser.Size = new System.Drawing.Size(252, 28);
            this.cboTypeUser.TabIndex = 10;
            this.cboTypeUser.SelectedIndexChanged += new System.EventHandler(this.cboTypeUser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại người dùng:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chkRandomCodeNum);
            this.groupBox2.Controls.Add(this.chkListManager);
            this.groupBox2.Controls.Add(this.lblManager);
            this.groupBox2.Controls.Add(this.dtpBirthday);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.cboClass);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.cboFaculty);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.cboCourse);
            this.groupBox2.Controls.Add(this.txtFullName);
            this.groupBox2.Controls.Add(this.txtCodeNum);
            this.groupBox2.Controls.Add(this.lblFaculty);
            this.groupBox2.Controls.Add(this.lblClass);
            this.groupBox2.Controls.Add(this.lblCourse);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblFullName);
            this.groupBox2.Controls.Add(this.lblCodeNum);
            this.groupBox2.Location = new System.Drawing.Point(12, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 342);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // chkRandomCodeNum
            // 
            this.chkRandomCodeNum.AutoSize = true;
            this.chkRandomCodeNum.Location = new System.Drawing.Point(327, 30);
            this.chkRandomCodeNum.Name = "chkRandomCodeNum";
            this.chkRandomCodeNum.Size = new System.Drawing.Size(114, 24);
            this.chkRandomCodeNum.TabIndex = 15;
            this.chkRandomCodeNum.Text = "ngẫu nhiên";
            this.chkRandomCodeNum.UseVisualStyleBackColor = true;
            this.chkRandomCodeNum.CheckedChanged += new System.EventHandler(this.chkRandomCodeNum_CheckedChanged);
            // 
            // chkListManager
            // 
            this.chkListManager.FormattingEnabled = true;
            this.chkListManager.Location = new System.Drawing.Point(164, 178);
            this.chkListManager.Name = "chkListManager";
            this.chkListManager.Size = new System.Drawing.Size(216, 73);
            this.chkListManager.TabIndex = 14;
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(49, 181);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(106, 20);
            this.lblManager.TabIndex = 13;
            this.lblManager.Text = "Phụ trách lớp:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(164, 103);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(180, 26);
            this.dtpBirthday.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Menu;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(280, 264);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 46);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(164, 218);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(156, 28);
            this.cboClass.TabIndex = 6;
            this.cboClass.Validating += new System.ComponentModel.CancelEventHandler(this.cboClass_Validating);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(159, 264);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 46);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboFaculty
            // 
            this.cboFaculty.FormattingEnabled = true;
            this.cboFaculty.Location = new System.Drawing.Point(164, 140);
            this.cboFaculty.Name = "cboFaculty";
            this.cboFaculty.Size = new System.Drawing.Size(216, 28);
            this.cboFaculty.TabIndex = 5;
            this.cboFaculty.SelectedIndexChanged += new System.EventHandler(this.cboFaculty_SelectedIndexChanged);
            this.cboFaculty.Validating += new System.ComponentModel.CancelEventHandler(this.cboFaculty_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(38, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 46);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboCourse
            // 
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(164, 178);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(122, 28);
            this.cboCourse.TabIndex = 4;
            this.cboCourse.Validating += new System.ComponentModel.CancelEventHandler(this.cboCourse_Validating);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(164, 66);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(216, 26);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFullName_Validating);
            // 
            // txtCodeNum
            // 
            this.txtCodeNum.Location = new System.Drawing.Point(164, 29);
            this.txtCodeNum.Name = "txtCodeNum";
            this.txtCodeNum.Size = new System.Drawing.Size(156, 26);
            this.txtCodeNum.TabIndex = 1;
            this.txtCodeNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeNum_KeyPress);
            this.txtCodeNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodeNum_Validating);
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(49, 143);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(50, 20);
            this.lblFaculty.TabIndex = 0;
            this.lblFaculty.Text = "Khoa:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(49, 221);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(40, 20);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Lớp:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(49, 181);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(50, 20);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Khóa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Sinh:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(49, 69);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(65, 20);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Họ Tên:";
            // 
            // lblCodeNum
            // 
            this.lblCodeNum.AutoSize = true;
            this.lblCodeNum.Location = new System.Drawing.Point(49, 32);
            this.lblCodeNum.Name = "lblCodeNum";
            this.lblCodeNum.Size = new System.Drawing.Size(59, 20);
            this.lblCodeNum.TabIndex = 0;
            this.lblCodeNum.Text = "Mã Số:";
            // 
            // lvwMain
            // 
            this.lvwMain.HideSelection = false;
            this.lvwMain.Location = new System.Drawing.Point(478, 119);
            this.lvwMain.Name = "lvwMain";
            this.lvwMain.Size = new System.Drawing.Size(718, 560);
            this.lvwMain.TabIndex = 6;
            this.lvwMain.UseCompatibleStateImageBehavior = false;
            this.lvwMain.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwMain_ColumnClick);
            this.lvwMain.SelectedIndexChanged += new System.EventHandler(this.lvwMain_SelectedIndexChanged);
            this.lvwMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwMain_MouseClick);
            // 
            // lblCountItemListView
            // 
            this.lblCountItemListView.AutoSize = true;
            this.lblCountItemListView.Location = new System.Drawing.Point(1123, 82);
            this.lblCountItemListView.Name = "lblCountItemListView";
            this.lblCountItemListView.Size = new System.Drawing.Size(52, 20);
            this.lblCountItemListView.TabIndex = 7;
            this.lblCountItemListView.Text = "0 mục";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(567, 79);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 26);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.SearchNameListView);
            // 
            // mnuStripListView
            // 
            this.mnuStripListView.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuStripListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.xóaNhiềuToolStripMenuItem});
            this.mnuStripListView.Name = "contextMenuStrip1";
            this.mnuStripListView.Size = new System.Drawing.Size(167, 68);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(166, 32);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // xóaNhiềuToolStripMenuItem
            // 
            this.xóaNhiềuToolStripMenuItem.Name = "xóaNhiềuToolStripMenuItem";
            this.xóaNhiềuToolStripMenuItem.Size = new System.Drawing.Size(166, 32);
            this.xóaNhiềuToolStripMenuItem.Text = "Xóa Nhiều";
            this.xóaNhiềuToolStripMenuItem.Click += new System.EventHandler(this.xóaNhiềuToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tìm kiếm:";
            // 
            // radSearchCodeNum
            // 
            this.radSearchCodeNum.AutoSize = true;
            this.radSearchCodeNum.Location = new System.Drawing.Point(783, 80);
            this.radSearchCodeNum.Name = "radSearchCodeNum";
            this.radSearchCodeNum.Size = new System.Drawing.Size(120, 24);
            this.radSearchCodeNum.TabIndex = 12;
            this.radSearchCodeNum.TabStop = true;
            this.radSearchCodeNum.Text = "Theo Mã Số";
            this.radSearchCodeNum.UseVisualStyleBackColor = true;
            this.radSearchCodeNum.CheckedChanged += new System.EventHandler(this.radCheckedSearch);
            // 
            // radSearchName
            // 
            this.radSearchName.AutoSize = true;
            this.radSearchName.Location = new System.Drawing.Point(925, 80);
            this.radSearchName.Name = "radSearchName";
            this.radSearchName.Size = new System.Drawing.Size(101, 24);
            this.radSearchName.TabIndex = 12;
            this.radSearchName.TabStop = true;
            this.radSearchName.Text = "Theo Tên";
            this.radSearchName.UseVisualStyleBackColor = true;
            this.radSearchName.CheckedChanged += new System.EventHandler(this.radCheckedSearch);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 694);
            this.Controls.Add(this.radSearchName);
            this.Controls.Add(this.radSearchCodeNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblCountItemListView);
            this.Controls.Add(this.lvwMain);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picLogout);
            this.Controls.Add(this.lblWelcomeSlogan);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlTitleBar);
            this.MinimumSize = new System.Drawing.Size(1204, 750);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.mnuStripListView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picResize;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWelcomeSlogan;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTypeUser;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.CheckedListBox chkListManager;
        private System.Windows.Forms.ContextMenuStrip mnuStripListView;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkRandomCodeNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radSearchCodeNum;
        private System.Windows.Forms.RadioButton radSearchName;
        private System.Windows.Forms.ToolStripMenuItem xóaNhiềuToolStripMenuItem;
    }
}

