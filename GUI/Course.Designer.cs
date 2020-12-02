namespace project_winform
{
    partial class frmCourse
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
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lvwCourse = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.label1);
            this.pnlTitleBar.Controls.Add(this.picMinimize);
            this.pnlTitleBar.Controls.Add(this.picExit);
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(517, 46);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Khóa";
            // 
            // picMinimize
            // 
            this.picMinimize.Location = new System.Drawing.Point(435, 9);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(27, 28);
            this.picMinimize.TabIndex = 6;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picExit
            // 
            this.picExit.Location = new System.Drawing.Point(475, 9);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(27, 28);
            this.picExit.TabIndex = 8;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(127, 72);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(107, 26);
            this.txtCourseId.TabIndex = 0;
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Location = new System.Drawing.Point(12, 75);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(76, 20);
            this.lblCourseId.TabIndex = 3;
            this.lblCourseId.Text = "Mã Khóa:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(12, 111);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(81, 20);
            this.lblCourseName.TabIndex = 3;
            this.lblCourseName.Text = "Tên Khóa:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(127, 108);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(216, 26);
            this.txtCourseName.TabIndex = 1;
            // 
            // lvwCourse
            // 
            this.lvwCourse.HideSelection = false;
            this.lvwCourse.Location = new System.Drawing.Point(12, 169);
            this.lvwCourse.Name = "lvwCourse";
            this.lvwCourse.Size = new System.Drawing.Size(492, 269);
            this.lvwCourse.TabIndex = 5;
            this.lvwCourse.UseCompatibleStateImageBehavior = false;
            this.lvwCourse.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwCourse_ColumnClick);
            this.lvwCourse.SelectedIndexChanged += new System.EventHandler(this.lvwCourse_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(351, 69);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Menu;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(435, 69);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(67, 33);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(387, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 33);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvwCourse);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseId);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCourseId);
            this.Controls.Add(this.pnlTitleBar);
            this.Name = "frmCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course";
            this.Load += new System.EventHandler(this.frmCourse_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.ListView lvwCourse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label label1;
    }
}