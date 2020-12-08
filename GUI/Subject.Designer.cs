namespace project_winform
{
    partial class frmSubject
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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwCourse = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwFaculty = new System.Windows.Forms.ListView();
            this.lvwSubject = new System.Windows.Forms.ListView();
            this.txtSubjectId = new System.Windows.Forms.TextBox();
            this.lblSubjectId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLecturerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDay = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.label1);
            this.pnlTitleBar.Controls.Add(this.picMinimize);
            this.pnlTitleBar.Controls.Add(this.picExit);
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(802, 46);
            this.pnlTitleBar.TabIndex = 11;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Môn Học";
            // 
            // picMinimize
            // 
            this.picMinimize.Location = new System.Drawing.Point(718, 9);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(27, 28);
            this.picMinimize.TabIndex = 27;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            this.picMinimize.MouseLeave += new System.EventHandler(this.picIcon_MouseLeave);
            this.picMinimize.MouseHover += new System.EventHandler(this.picIcon_MouseHover);
            // 
            // picExit
            // 
            this.picExit.Location = new System.Drawing.Point(761, 9);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(27, 28);
            this.picExit.TabIndex = 29;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseLeave += new System.EventHandler(this.picIcon_MouseLeave);
            this.picExit.MouseHover += new System.EventHandler(this.picIcon_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwCourse);
            this.groupBox1.Location = new System.Drawing.Point(438, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 154);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khóa Học";
            // 
            // lvwCourse
            // 
            this.lvwCourse.HideSelection = false;
            this.lvwCourse.Location = new System.Drawing.Point(0, 25);
            this.lvwCourse.Name = "lvwCourse";
            this.lvwCourse.Size = new System.Drawing.Size(346, 125);
            this.lvwCourse.TabIndex = 6;
            this.lvwCourse.UseCompatibleStateImageBehavior = false;
            this.lvwCourse.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwCourse_ColumnClick);
            this.lvwCourse.SelectedIndexChanged += new System.EventHandler(this.lvwCourse_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwFaculty);
            this.groupBox2.Location = new System.Drawing.Point(438, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 154);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khoa";
            // 
            // lvwFaculty
            // 
            this.lvwFaculty.HideSelection = false;
            this.lvwFaculty.Location = new System.Drawing.Point(0, 25);
            this.lvwFaculty.Name = "lvwFaculty";
            this.lvwFaculty.Size = new System.Drawing.Size(346, 125);
            this.lvwFaculty.TabIndex = 7;
            this.lvwFaculty.UseCompatibleStateImageBehavior = false;
            this.lvwFaculty.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwFaculty_ColumnClick);
            this.lvwFaculty.SelectedIndexChanged += new System.EventHandler(this.lvwFaculty_SelectedIndexChanged);
            // 
            // lvwSubject
            // 
            this.lvwSubject.HideSelection = false;
            this.lvwSubject.Location = new System.Drawing.Point(12, 216);
            this.lvwSubject.Name = "lvwSubject";
            this.lvwSubject.Size = new System.Drawing.Size(416, 339);
            this.lvwSubject.TabIndex = 28;
            this.lvwSubject.UseCompatibleStateImageBehavior = false;
            this.lvwSubject.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwSubject_ColumnClick);
            this.lvwSubject.SelectedIndexChanged += new System.EventHandler(this.lvwSubject_SelectedIndexChanged);
            // 
            // txtSubjectId
            // 
            this.txtSubjectId.Location = new System.Drawing.Point(131, 62);
            this.txtSubjectId.Name = "txtSubjectId";
            this.txtSubjectId.Size = new System.Drawing.Size(107, 26);
            this.txtSubjectId.TabIndex = 29;
            // 
            // lblSubjectId
            // 
            this.lblSubjectId.AutoSize = true;
            this.lblSubjectId.Location = new System.Drawing.Point(16, 65);
            this.lblSubjectId.Name = "lblSubjectId";
            this.lblSubjectId.Size = new System.Drawing.Size(70, 20);
            this.lblSubjectId.TabIndex = 30;
            this.lblSubjectId.Text = "Mã Môn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên Môn:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 26);
            this.txtName.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Số Tín Chỉ:";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(131, 132);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(89, 26);
            this.txtCredit.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Thông tin:";
            // 
            // txtInformation
            // 
            this.txtInformation.Location = new System.Drawing.Point(438, 62);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(217, 55);
            this.txtInformation.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tên Giảng Viên:";
            // 
            // txtLecturerName
            // 
            this.txtLecturerName.Location = new System.Drawing.Point(150, 167);
            this.txtLecturerName.Name = "txtLecturerName";
            this.txtLecturerName.Size = new System.Drawing.Size(150, 26);
            this.txtLecturerName.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ngày Bắt Đầu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ngày Kết Thúc:";
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.Location = new System.Drawing.Point(468, 126);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(187, 26);
            this.dtpStartDay.TabIndex = 31;
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.Location = new System.Drawing.Point(468, 161);
            this.dtpEndDay.Name = "dtpEndDay";
            this.dtpEndDay.Size = new System.Drawing.Size(187, 26);
            this.dtpEndDay.TabIndex = 31;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(691, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(691, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(691, 154);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 40);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtFaculty
            // 
            this.txtFaculty.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFaculty.Enabled = false;
            this.txtFaculty.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtFaculty.Location = new System.Drawing.Point(564, 216);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(220, 26);
            this.txtFaculty.TabIndex = 34;
            // 
            // txtCourse
            // 
            this.txtCourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCourse.Enabled = false;
            this.txtCourse.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtCourse.Location = new System.Drawing.Point(438, 216);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(120, 26);
            this.txtCourse.TabIndex = 33;
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpEndDay);
            this.Controls.Add(this.dtpStartDay);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.txtLecturerName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubjectId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSubjectId);
            this.Controls.Add(this.lvwSubject);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlTitleBar);
            this.Name = "frmSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvwFaculty;
        private System.Windows.Forms.ListView lvwSubject;
        private System.Windows.Forms.TextBox txtSubjectId;
        private System.Windows.Forms.Label lblSubjectId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLecturerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.DateTimePicker dtpEndDay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtCourse;
    }
}