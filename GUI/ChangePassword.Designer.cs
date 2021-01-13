namespace project_winform.GUI
{
    partial class frmChangePassword
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtPassOld = new System.Windows.Forms.TextBox();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.lblPassOld = new System.Windows.Forms.Label();
            this.lblPassNew = new System.Windows.Forms.Label();
            this.txtRePassNew = new System.Windows.Forms.TextBox();
            this.lblRePassNew = new System.Windows.Forms.Label();
            this.btnPassGenerator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnChangePassword);
            this.groupBox1.Controls.Add(this.txtPassOld);
            this.groupBox1.Controls.Add(this.txtPassNew);
            this.groupBox1.Controls.Add(this.lblPassOld);
            this.groupBox1.Controls.Add(this.lblPassNew);
            this.groupBox1.Controls.Add(this.txtRePassNew);
            this.groupBox1.Controls.Add(this.lblRePassNew);
            this.groupBox1.Controls.Add(this.btnPassGenerator);
            this.groupBox1.Location = new System.Drawing.Point(8, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(295, 170);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mật Khẩu";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.Menu;
            this.btnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword.Location = new System.Drawing.Point(47, 133);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(85, 24);
            this.btnChangePassword.TabIndex = 23;
            this.btnChangePassword.Text = "Đổi Mật Khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtPassOld
            // 
            this.txtPassOld.Location = new System.Drawing.Point(124, 27);
            this.txtPassOld.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.Size = new System.Drawing.Size(102, 20);
            this.txtPassOld.TabIndex = 20;
            this.txtPassOld.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassOld_Validating);
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(124, 62);
            this.txtPassNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Size = new System.Drawing.Size(121, 20);
            this.txtPassNew.TabIndex = 21;
            this.txtPassNew.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassNew_Validating);
            // 
            // lblPassOld
            // 
            this.lblPassOld.AutoSize = true;
            this.lblPassOld.Location = new System.Drawing.Point(44, 29);
            this.lblPassOld.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassOld.Name = "lblPassOld";
            this.lblPassOld.Size = new System.Drawing.Size(72, 13);
            this.lblPassOld.TabIndex = 19;
            this.lblPassOld.Text = "Mật Khẩu Cũ:";
            // 
            // lblPassNew
            // 
            this.lblPassNew.AutoSize = true;
            this.lblPassNew.Location = new System.Drawing.Point(44, 63);
            this.lblPassNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassNew.Name = "lblPassNew";
            this.lblPassNew.Size = new System.Drawing.Size(76, 13);
            this.lblPassNew.TabIndex = 18;
            this.lblPassNew.Text = "Mật Khẩu Mới:";
            // 
            // txtRePassNew
            // 
            this.txtRePassNew.Location = new System.Drawing.Point(124, 92);
            this.txtRePassNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRePassNew.Name = "txtRePassNew";
            this.txtRePassNew.Size = new System.Drawing.Size(121, 20);
            this.txtRePassNew.TabIndex = 22;
            this.txtRePassNew.Validating += new System.ComponentModel.CancelEventHandler(this.txtRePassNew_Validating);
            // 
            // lblRePassNew
            // 
            this.lblRePassNew.AutoSize = true;
            this.lblRePassNew.Location = new System.Drawing.Point(44, 94);
            this.lblRePassNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRePassNew.Name = "lblRePassNew";
            this.lblRePassNew.Size = new System.Drawing.Size(53, 13);
            this.lblRePassNew.TabIndex = 17;
            this.lblRePassNew.Text = "Nhập Lại:";
            // 
            // btnPassGenerator
            // 
            this.btnPassGenerator.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPassGenerator.ForeColor = System.Drawing.Color.Black;
            this.btnPassGenerator.Location = new System.Drawing.Point(141, 133);
            this.btnPassGenerator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPassGenerator.Name = "btnPassGenerator";
            this.btnPassGenerator.Size = new System.Drawing.Size(102, 24);
            this.btnPassGenerator.TabIndex = 24;
            this.btnPassGenerator.Text = "Tự Tạo Mật Khẩu";
            this.btnPassGenerator.UseVisualStyleBackColor = false;
            this.btnPassGenerator.Click += new System.EventHandler(this.btnPassGenerator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPassOld;
        private System.Windows.Forms.TextBox txtPassOld;
        private System.Windows.Forms.Label lblPassNew;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.Label lblRePassNew;
        private System.Windows.Forms.TextBox txtRePassNew;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnPassGenerator;
        private System.Windows.Forms.Label label1;
    }
}