using project_winform.BUS;
using project_winform.CTO;
using project_winform.src.config;
using project_winform.src.constants;
using project_winform.src.helpers;
using project_winform.src.themes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace project_winform
{
    public partial class frmMainStudent : Form
    {
        public frmMainStudent()
        {
            InitializeComponent();

            #region * UI SETUP

            // Password Char
            txtPassOld.PasswordChar = '\u25CF';
            txtPassNew.PasswordChar = '\u25CF';
            txtRePassNew.PasswordChar = '\u25CF';

            lvwRegister.Columns.Add("Mã Môn", 70);
            lvwRegister.Columns.Add("Tên Môn", 85);
            lvwRegister.Columns.Add("Số Tín Chỉ", 85);
            lvwRegister.Columns.Add("Thông Tin", 80);
            lvwRegister.Columns.Add("Tên Giảng Viên", 100);
            lvwRegister.Columns.Add("Ngày Bắt Đầu", 100);
            lvwRegister.Columns.Add("Ngày Kết Thúc", 100);
            lvwRegister.Columns.Add("Mã Khóa", 80);
            lvwRegister.Columns.Add("Mã Khoa", 80);

            lvwRegistered.Columns.Add("Mã Môn", 70);
            lvwRegistered.Columns.Add("Tên Môn", 85);
            lvwRegistered.Columns.Add("Số Tín Chỉ", 85);
            lvwRegistered.Columns.Add("Thông Tin", 80);
            lvwRegistered.Columns.Add("Tên Giảng Viên", 100);
            lvwRegistered.Columns.Add("Ngày Bắt Đầu", 100);
            lvwRegistered.Columns.Add("Ngày Kết Thúc", 100);
            lvwRegistered.Columns.Add("Mã Khóa", 80);
            lvwRegistered.Columns.Add("Mã Khoa", 80);

            #endregion

            #region * UI STYLE
            BackColor = ColorTheme.getTheme("secondary");
            picLogout.Image = Image.FromFile(IconTheme.logout);
            lblWelcome.ForeColor = ColorTheme.getTheme("text-bold");
            lblWelcomeSlogan.ForeColor = ColorTheme.getTheme("text-normal");

            // Hidden TitleBar
            FormBorderStyle = FormBorderStyle.None;

            // Style Title Bar
            pnlTitleBar.BackColor = ColorTheme.getTheme();
            picExit.Image = Image.FromFile(IconTheme.exit);
            picMinimize.Image = Image.FromFile(IconTheme.minimize);

            // Color Button Style
            btnChangePassword.BackColor = ColorTheme.getTheme("primary");
            btnPassGenerator.BackColor = ColorTheme.getTheme("success");
            btnRegister.BackColor = ColorTheme.getTheme("primary");
            btnCancelRegister.BackColor = ColorTheme.getTheme("danger");
            #endregion
        }

        private void frmMainStudent_Load(object sender, EventArgs e)
        {
            new RegisterSubjectBUS();
            RegisterSubjectBUS.RenderListViewRegisterFromState(lvwRegister);
            RegisterSubjectBUS.RenderListViewRegisteredFromState(lvwRegistered);

            #region * UI SETUP LOAD

            lblWelcome.Text = $"Xin chào {Control.userLogin.Name}";
            txtCodeNum.Text = Control.userLogin.IdUser;
            txtFullName.Text = Control.userLogin.Name;
            dtpBirthday.Value = DateTime.Parse(Control.userLogin.Birthday.ToString().Substring(0, 10));
            cboCourse.Text = Control.userLogin.ClassModel.Course.Name;
            cboFaculty.Text = Control.userLogin.ClassModel.Faculty.Name;
            cboClass.Text = Control.userLogin.ClassModel.Name;

            #endregion

            // Load Initial Config
            FormSetup.FormLoad(this);
        }

        /* UI CUSTOM */
        #region * (UI) CUSTOM
        /* Title Bar Hover Style */
        private void picIcon_MouseHover(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Name == "picExit")
                picExit.Image = Image.FromFile(IconTheme.exitHover);
            if ((sender as PictureBox).Name == "picMinimize")
                picMinimize.Image = Image.FromFile(IconTheme.minimizeHover);
        }

        private void picIcon_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Name == "picExit")
                picExit.Image = Image.FromFile(IconTheme.exit);
            if ((sender as PictureBox).Name == "picMinimize")
                picMinimize.Image = Image.FromFile(IconTheme.minimize);
        }

        /* Title Bar Icon Action */
        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(MessageBoxText.ConfigExit, MessageBoxText.CaptionInformation, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        /* Move Window Action */
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Window.ReleaseCapture();
                Window.SendMessage(Handle, Window.WM_NCLBUTTONDOWN, Window.HT_CAPTION, 0);
            }
        }

        /* Border Form Style */
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(ColorTheme.getTheme(), 8), DisplayRectangle);
        }

        /* Logout Button */
        private void picLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(MessageBoxText.Logout, MessageBoxText.CaptionInformation, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                File.Delete(Config.fileUserConfig);
                Control.userLogin = null;
                this.Hide();
                new frmLogin().Show();
            }
        }

        #endregion

        /* METHODS */
        #region * PASSWORD

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!ValidatingTxtPassOld() || !ValidatingTxtPassNew() || !ValidatingTxtRePassNew())
            {
                MessageBox.Show(MessageBoxText.RequiredInput, MessageBoxText.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserBUS.HandleChangePassword(txtPassOld.Text, txtPassNew.Text, txtRePassNew.Text);
        }

        private void btnPassGenerator_Click(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox(MessageBoxText.GeneratorPassword, MessageBoxText.CaptionSuccess, Password.GeneratorPassword(12));
            if (result.Length > 0) txtPassNew.Text = result;
        }

        #endregion

        #region * VALIDATING INPUT

        private bool ValidatingTxtPassOld()
        {
            return ValidatingInput.ValidatingInputText(txtPassOld, lblPassOld);
        }

        private bool ValidatingTxtPassNew()
        {
            return ValidatingInput.ValidatingInputText(txtPassNew, lblPassNew);
        }

        private bool ValidatingTxtRePassNew()
        {
            return ValidatingInput.ValidatingInputText(txtRePassNew, lblRePassNew);
        }

        private void txtPassOld_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingTxtPassOld();
        }

        private void txtPassNew_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingTxtPassNew();
        }

        private void txtRePassNew_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingTxtRePassNew();
        }

        #endregion

        #region * SELECTED LISTVIEW

        private void lvwRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwRegister.SelectedItems.Count <= 0) return;

            ListViewItem item = lvwRegister.SelectedItems[0];
            txtIdRegister.Text = item.SubItems[0].Text;
            txtNameRegister.Text = item.SubItems[1].Text;

            SelectListView.SelectListViewColorForMultipleListView(lvwRegister);
        }

        private void lvwRegistered_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwRegistered.SelectedItems.Count <= 0) return;

            ListViewItem item = lvwRegistered.SelectedItems[0];
            txtCancelIdRegister.Text = item.SubItems[0].Text;
            txtCancelNameRegister.Text = item.SubItems[1].Text;

            SelectListView.SelectListViewColorForMultipleListView(lvwRegistered);
        }

        #endregion

        #region * METHODS BUTTON

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string id_user = txtCodeNum.Text;
            string id_subject = txtIdRegister.Text;

            if (id_user.Length <= 0 || id_subject.Length <= 0)
            {
                MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RegisterSubject registerSubject = new RegisterSubject(id_user, id_subject);
            RegisterSubjectBUS.HandleCreateRegisterSubject(lvwRegister, lvwRegistered, registerSubject);

            txtIdRegister.Text = String.Empty;
            txtNameRegister.Text = String.Empty;
        }

        private void btnCancelRegister_Click(object sender, EventArgs e)
        {
            string id_user = txtCodeNum.Text;
            string id_subject = txtCancelIdRegister.Text;

            if (id_user.Length <= 0 || id_subject.Length <= 0)
            {
                MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RegisterSubjectBUS.HandleCancelRegisteredSubject(lvwRegister, lvwRegistered, id_user, id_subject);

            txtCancelIdRegister.Text = String.Empty;
            txtCancelNameRegister.Text = String.Empty;
        }

        #endregion
    }
}
