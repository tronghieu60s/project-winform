using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using project_winform.src.helpers;
using project_winform.src.themes;

namespace project_winform
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            FormSetup.FormLoad(this);

            // Hidden TitleBar
            FormBorderStyle = FormBorderStyle.None;

            foreach (var item in FormSetup.GetAll(this, typeof(TextBox)))
            {
                (item as TextBox).BorderStyle = BorderStyle.None;
                (item as TextBox).ForeColor = Color.FromArgb(255, 255, 255);
                (item as TextBox).BackColor = Color.FromArgb(48, 51, 57);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            /* --- Title Bar ---  */
            // Style Button Title Bar
            picExit.Image = Image.FromFile(IconTheme.exit);
            picResize.Image = Image.FromFile(IconTheme.resize);
            picMinimize.Image = Image.FromFile(IconTheme.minimize);

            BackColor = Color.FromArgb(54, 57, 63);

            // Style Panel
            pnlLeft.BackgroundImage = Image.FromFile(ImageTheme.bg);
            pnlTextCodeNum.BackColor = pnlTextPassword.BackColor 
                = Color.FromArgb(48, 51, 57);
            pnlTextCodeNum.Cursor = pnlTextPassword.Cursor = Cursors.IBeam;

            // Style Label
            lblForgetPass.LinkColor = Color.FromArgb(114, 137, 218);
            lblForgetPass.LinkBehavior = LinkBehavior.NeverUnderline;
            lblSlogan.ForeColor = Color.FromArgb(185, 187, 190);
            lblTitle.ForeColor = Color.FromArgb(255, 255, 255);
            lblPassword.ForeColor = lblCodeNum.ForeColor = Color.FromArgb(142, 146, 151);

            // Style Button
            btnLogin.BackColor = btnLogin.FlatAppearance.BorderColor = Color.FromArgb(114, 137, 218);
        }

        private void pnlTextCodeNum_Click(object sender, EventArgs e)
        {
            txtCodeNum.Focus();
        }

        private void pnlTextPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void pnlTextCodeNum_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pnlTextCodeNum.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void pnlTextPassword_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pnlTextPassword.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void lblForgetPass_MouseHover(object sender, EventArgs e)
        {
            lblForgetPass.LinkBehavior = LinkBehavior.AlwaysUnderline;
        }

        private void lblForgetPass_MouseLeave(object sender, EventArgs e)
        {
            lblForgetPass.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        // Style Title Bar Icon Hover
        private void picIcon_MouseHover(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Name == "picExit")
                picExit.Image = Image.FromFile(IconTheme.exitHover);
            if ((sender as PictureBox).Name == "picResize")
                picResize.Image = Image.FromFile(IconTheme.resizeHover);
            if ((sender as PictureBox).Name == "picMinimize")
                picMinimize.Image = Image.FromFile(IconTheme.minimizeHover);
        }

        private void picIcon_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Name == "picExit")
                picExit.Image = Image.FromFile(IconTheme.exit);
            if ((sender as PictureBox).Name == "picResize")
                picResize.Image = Image.FromFile(IconTheme.resize);
            if ((sender as PictureBox).Name == "picMinimize")
                picMinimize.Image = Image.FromFile(IconTheme.minimize);
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
