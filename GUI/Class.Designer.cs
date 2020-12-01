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
            this.pnlTitleBar.TabIndex = 10;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Lớp";
            // 
            // picMinimize
            // 
            this.picMinimize.Location = new System.Drawing.Point(718, 9);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(27, 28);
            this.picMinimize.TabIndex = 27;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picExit
            // 
            this.picExit.Location = new System.Drawing.Point(761, 9);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(27, 28);
            this.picExit.TabIndex = 29;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(155, 102);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(216, 26);
            this.txtClassName.TabIndex = 1;
            // 
            // txtClassId
            // 
            this.txtClassId.Location = new System.Drawing.Point(155, 66);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(107, 26);
            this.txtClassId.TabIndex = 0;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(40, 105);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(71, 20);
            this.lblClassName.TabIndex = 19;
            this.lblClassName.Text = "Tên Lớp:";
            // 
            // lblClassId
            // 
            this.lblClassId.AutoSize = true;
            this.lblClassId.Location = new System.Drawing.Point(40, 69);
            this.lblClassId.Name = "lblClassId";
            this.lblClassId.Size = new System.Drawing.Size(66, 20);
            this.lblClassId.TabIndex = 20;
            this.lblClassId.Text = "Mã Lớp:";
            // 
            // lvwClass
            // 
            this.lvwClass.HideSelection = false;
            this.lvwClass.Location = new System.Drawing.Point(12, 200);
            this.lvwClass.Name = "lvwClass";
            this.lvwClass.Size = new System.Drawing.Size(416, 316);
            this.lvwClass.TabIndex = 5;
            this.lvwClass.UseCompatibleStateImageBehavior = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(177, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Menu;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(276, 149);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(67, 33);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(78, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwCourse);
            this.groupBox1.Location = new System.Drawing.Point(438, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 231);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khóa Học";
            // 
            // lvwCourse
            // 
            this.lvwCourse.HideSelection = false;
            this.lvwCourse.Location = new System.Drawing.Point(0, 25);
            this.lvwCourse.Name = "lvwCourse";
            this.lvwCourse.Size = new System.Drawing.Size(346, 203);
            this.lvwCourse.TabIndex = 6;
            this.lvwCourse.UseCompatibleStateImageBehavior = false;
            this.lvwCourse.SelectedIndexChanged += new System.EventHandler(this.lvwCourse_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwFaculty);
            this.groupBox2.Location = new System.Drawing.Point(438, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 231);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khoa";
            // 
            // lvwFaculty
            // 
            this.lvwFaculty.HideSelection = false;
            this.lvwFaculty.Location = new System.Drawing.Point(0, 25);
            this.lvwFaculty.Name = "lvwFaculty";
            this.lvwFaculty.Size = new System.Drawing.Size(346, 203);
            this.lvwFaculty.TabIndex = 7;
            this.lvwFaculty.UseCompatibleStateImageBehavior = false;
            this.lvwFaculty.SelectedIndexChanged += new System.EventHandler(this.lvwFaculty_SelectedIndexChanged);
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
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
    }
}