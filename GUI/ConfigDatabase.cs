using project_winform.DAL;
using project_winform.src.constants;
using project_winform.src.helpers;
using project_winform.src.themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace project_winform
{
    public partial class frmConfigDatabase : Form
    {
        public frmConfigDatabase()
        {
            InitializeComponent();

            #region * UI STYLE
            BackColor = ColorTheme.getTheme("secondary");

            // Hidden TitleBar
            FormBorderStyle = FormBorderStyle.None;

            // Style Title Bar
            pnlTitleBar.BackColor = ColorTheme.getTheme("primary");
            picExit.Image = Image.FromFile(IconTheme.exit);
            picMinimize.Image = Image.FromFile(IconTheme.minimize);

            // Style Button
            btnTestConnect.BackColor = ColorTheme.getTheme("primary");
            btnSaveConnect.BackColor = ColorTheme.getTheme("success");
            #endregion
        }

        private void frmConfigDatabase_Load(object sender, EventArgs e)
        {
            // Load Initial Config
            FormSetup.FormLoad(this);
        }

        #region * (UI) CUSTOM

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
            e.Graphics.DrawRectangle(new Pen(ColorTheme.getTheme("primary"), 8), DisplayRectangle);
        }

        #endregion

        private void btnSaveConnect_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text;
            string database = txtDatabase.Text;
            string port = txtPort.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool result = DatabaseConfig.CheckConnectDatabase(server, database, port, username, password);
            if (result)
            {
                DatabaseConfig.SaveLocalStorageConfig(server, database, port, username, password);
                DialogResult resultBox = MessageBox.Show(MessageBoxText.SaveFileSuccess, MessageBoxText.CaptionSuccess, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (resultBox == DialogResult.OK)
                    Application.Exit();
            }
            else MessageBox.Show(MessageBoxText.DatabaseConnectFalse, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTestConnect_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text;
            string database = txtDatabase.Text;
            string port = txtPort.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool result = DatabaseConfig.CheckConnectDatabase(server, database, port, username, password);
            if (result)
                MessageBox.Show(MessageBoxText.DatabaseConnectTrue, MessageBoxText.CaptionInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show(MessageBoxText.DatabaseConnectFalse, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
