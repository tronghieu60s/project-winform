namespace project_winform
{
    partial class frmFaculty
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvwFaculty = new System.Windows.Forms.ListView();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.txtFacultyId = new System.Windows.Forms.TextBox();
            this.lblFacultyName = new System.Windows.Forms.Label();
            this.lblFacultyId = new System.Windows.Forms.Label();
            this.btnExportReport = new System.Windows.Forms.Button();
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
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(345, 30);
            this.pnlTitleBar.TabIndex = 9;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khoa";
            // 
            // picMinimize
            // 
            this.picMinimize.Location = new System.Drawing.Point(290, 6);
            this.picMinimize.Margin = new System.Windows.Forms.Padding(2);
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
            this.picExit.Location = new System.Drawing.Point(317, 6);
            this.picExit.Margin = new System.Windows.Forms.Padding(2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(18, 18);
            this.picExit.TabIndex = 0;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseLeave += new System.EventHandler(this.picIcon_MouseLeave);
            this.picExit.MouseHover += new System.EventHandler(this.picIcon_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(258, 70);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 21);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Menu;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(290, 45);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 21);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(234, 45);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 21);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvwFaculty
            // 
            this.lvwFaculty.HideSelection = false;
            this.lvwFaculty.Location = new System.Drawing.Point(8, 110);
            this.lvwFaculty.Margin = new System.Windows.Forms.Padding(2);
            this.lvwFaculty.Name = "lvwFaculty";
            this.lvwFaculty.Size = new System.Drawing.Size(329, 176);
            this.lvwFaculty.TabIndex = 5;
            this.lvwFaculty.UseCompatibleStateImageBehavior = false;
            this.lvwFaculty.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwFaculty_ColumnClick);
            this.lvwFaculty.SelectedIndexChanged += new System.EventHandler(this.lvwFaculty_SelectedIndexChanged);
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Location = new System.Drawing.Point(85, 70);
            this.txtFacultyName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(145, 20);
            this.txtFacultyName.TabIndex = 1;
            // 
            // txtFacultyId
            // 
            this.txtFacultyId.Location = new System.Drawing.Point(85, 47);
            this.txtFacultyId.Margin = new System.Windows.Forms.Padding(2);
            this.txtFacultyId.Name = "txtFacultyId";
            this.txtFacultyId.Size = new System.Drawing.Size(73, 20);
            this.txtFacultyId.TabIndex = 0;
            // 
            // lblFacultyName
            // 
            this.lblFacultyName.AutoSize = true;
            this.lblFacultyName.Location = new System.Drawing.Point(8, 72);
            this.lblFacultyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacultyName.Name = "lblFacultyName";
            this.lblFacultyName.Size = new System.Drawing.Size(57, 13);
            this.lblFacultyName.TabIndex = 10;
            this.lblFacultyName.Text = "Tên Khoa:";
            // 
            // lblFacultyId
            // 
            this.lblFacultyId.AutoSize = true;
            this.lblFacultyId.Location = new System.Drawing.Point(8, 49);
            this.lblFacultyId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacultyId.Name = "lblFacultyId";
            this.lblFacultyId.Size = new System.Drawing.Size(53, 13);
            this.lblFacultyId.TabIndex = 11;
            this.lblFacultyId.Text = "Mã Khoa:";
            // 
            // btnExportReport
            // 
            this.btnExportReport.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExportReport.ForeColor = System.Drawing.Color.Black;
            this.btnExportReport.Location = new System.Drawing.Point(104, 290);
            this.btnExportReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(126, 21);
            this.btnExportReport.TabIndex = 31;
            this.btnExportReport.Text = "Xuất Báo Cáo";
            this.btnExportReport.UseVisualStyleBackColor = false;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // frmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 319);
            this.Controls.Add(this.btnExportReport);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvwFaculty);
            this.Controls.Add(this.txtFacultyName);
            this.Controls.Add(this.txtFacultyId);
            this.Controls.Add(this.lblFacultyName);
            this.Controls.Add(this.lblFacultyId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmFaculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty";
            this.Load += new System.EventHandler(this.frmFaculty_Load);
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
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvwFaculty;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.TextBox txtFacultyId;
        private System.Windows.Forms.Label lblFacultyName;
        private System.Windows.Forms.Label lblFacultyId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportReport;
    }
}