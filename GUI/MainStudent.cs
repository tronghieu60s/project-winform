using project_winform.BUS;
using project_winform.CTO;
using project_winform.src.config;
using project_winform.src.constants;
using project_winform.src.helpers;
using project_winform.src.themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_winform
{
    public partial class frmMainStudent : Form
    {
        public frmMainStudent()
        {
            InitializeComponent();

            #region * UI SETUP

            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.Format = DateTimePickerFormat.Custom;

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
            #endregion
        }

        private void frmMainStudent_Load(object sender, EventArgs e)
        {
            new UserBUS();

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
            Control.CloseWindow();
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
                Control.frmLogin.Show();
                Control.frmMain.Hide();
            }
        }

        #endregion
    }
}
