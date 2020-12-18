namespace project_winform
{
    partial class frmClass
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
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblClassId = new System.Windows.Forms.Label();
            this.lvwClass = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwCourse = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwFaculty = new System.Windows.Forms.ListView();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.btnExportReport = new System.Windows.Forms.Button();
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
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(588, 30);
            this.pnlTitleBar.TabIndex = 10;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Lớp";
            // 
            // picMinimize
            // 
            this.picMinimize.Location = new System.Drawing.Point(527, 6);
            this.picMinimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.picExit.Location = new System.Drawing.Point(556, 6);
            this.picExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(18, 18);
            this.picExit.TabIndex = 29;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseLeave += new System.EventHandler(this.picIcon_MouseLeave);
            this.picExit.MouseHover += new System.EventHandler(this.picIcon_MouseHover);
            // 
            // txtClassName
            // 
            this.txtClassName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtClassName.Location = new System.Drawing.Point(103, 75);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(145, 20);
            this.txtClassName.TabIndex = 1;
            // 
            // txtClassId
            // 
            this.txtClassId.Location = new System.Drawing.Point(103, 51);
            this.txtClassId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(73, 20);
            this.txtClassId.TabIndex = 0;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(27, 77);
            this.lblClassName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(50, 13);
            this.lblClassName.TabIndex = 19;
            this.lblClassName.Text = "Tên Lớp:";
            // 
            // lblClassId
            // 
            this.lblClassId.AutoSize = true;
            this.lblClassId.Location = new System.Drawing.Point(27, 53);
            this.lblClassId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClassId.Name = "lblClassId";
            this.lblClassId.Size = new System.Drawing.Size(46, 13);
            this.lblClassId.TabIndex = 20;
            this.lblClassId.Text = "Mã Lớp:";
            // 
            // lvwClass
            // 
            this.lvwClass.HideSelection = false;
            this.lvwClass.Location = new System.Drawing.Point(8, 147);
            this.lvwClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwClass.Name = "lvwClass";
            this.lvwClass.Size = new System.Drawing.Size(327, 170);
            this.lvwClass.TabIndex = 5;
            this.lvwClass.UseCompatibleStateImageBehavior = false;
            this.lvwClass.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwClass_ColumnClick);
            this.lvwClass.SelectedIndexChanged += new System.EventHandler(this.lvwClass_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(270, 74);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 21);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Menu;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(270, 106);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 21);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(270, 43);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 21);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwCourse);
            this.groupBox1.Location = new System.Drawing.Point(344, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(233, 150);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khóa Học";
            // 
            // lvwCourse
            // 
            this.lvwCourse.HideSelection = false;
            this.lvwCourse.Location = new System.Drawing.Point(0, 16);
            this.lvwCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwCourse.Name = "lvwCourse";
            this.lvwCourse.Size = new System.Drawing.Size(232, 133);
            this.lvwCourse.TabIndex = 6;
            this.lvwCourse.UseCompatibleStateImageBehavior = false;
            this.lvwCourse.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwCourse_ColumnClick);
            this.lvwCourse.SelectedIndexChanged += new System.EventHandler(this.lvwCourse_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwFaculty);
            this.groupBox2.Location = new System.Drawing.Point(344, 188);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(233, 150);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khoa";
            // 
            // lvwFaculty
            // 
            this.lvwFaculty.HideSelection = false;
            this.lvwFaculty.Location = new System.Drawing.Point(0, 16);
            this.lvwFaculty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwFaculty.Name = "lvwFaculty";
            this.lvwFaculty.Size = new System.Drawing.Size(232, 133);
            this.lvwFaculty.TabIndex = 7;
            this.lvwFaculty.UseCompatibleStateImageBehavior = false;
            this.lvwFaculty.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwFaculty_ColumnClick);
            this.lvwFaculty.SelectedIndexChanged += new System.EventHandler(this.lvwFaculty_SelectedIndexChanged);
            // 
            // txtCourse
            // 
            this.txtCourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCourse.Enabled = false;
            this.txtCourse.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtCourse.Location = new System.Drawing.Point(29, 103);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(81, 20);
            this.txtCourse.TabIndex = 27;
            // 
            // txtFaculty
            // 
            this.txtFaculty.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFaculty.Enabled = false;
            this.txtFaculty.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtFaculty.Location = new System.Drawing.Point(121, 103);
            this.txtFaculty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(135, 20);
            this.txtFaculty.TabIndex = 28;
            // 
            // btnExportReport
            // 
            this.btnExportReport.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExportReport.ForeColor = System.Drawing.Color.Black;
            this.btnExportReport.Location = new System.Drawing.Point(103, 321);
            this.btnExportReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(126, 21);
            this.btnExportReport.TabIndex = 29;
            this.btnExportReport.Text = "Xuất Báo Cáo";
            this.btnExportReport.UseVisualStyleBackColor = false;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 349);
            this.Controls.Add(this.btnExportReport);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvwClass);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtClassId);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblClassId);
            this.Controls.Add(this.pnlTitleBar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class";
            this.Load += new System.EventHandler(this.frmClass_Load);
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
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblClassId;
        private System.Windows.Forms.ListView lvwClass;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvwFaculty;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.Button btnExportReport;
    }
}