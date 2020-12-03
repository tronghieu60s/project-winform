using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using project_winform.BUS;
using project_winform.CTO;
using project_winform.DAL;
using project_winform.src.constants;
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

            #region * UI STYLE
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

            // Hidden TitleBar
            FormBorderStyle = FormBorderStyle.None;

            // Style Title Bar
            picExit.Image = Image.FromFile(IconTheme.exitHover);
            picMove.Image = Image.FromFile(IconTheme.move);

            // Text Box Style 
            foreach (var item in FormSetup.GetAll(this, typeof(TextBox)))
            {
                (item as TextBox).BorderStyle = BorderStyle.None;
                (item as TextBox).ForeColor = Color.FromArgb(255, 255, 255);
                (item as TextBox).BackColor = Color.FromArgb(48, 51, 57);
            }
            #endregion
        }

        #region * UI CUSTOM
        /* Title Bar Hover Style */
        private void picIcon_MouseHover(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Name == "picMove")
                picMove.Image = Image.FromFile(IconTheme.moveHover);
        }

        private void picIcon_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Name == "picMove")
                picMove.Image = Image.FromFile(IconTheme.move);
        }

        /* Panel Text Style */
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

        /* Forget Passeword Label Style */
        private void lblForgetPass_MouseHover(object sender, EventArgs e)
        {
            lblForgetPass.LinkBehavior = LinkBehavior.AlwaysUnderline;
        }

        private void lblForgetPass_MouseLeave(object sender, EventArgs e)
        {
            lblForgetPass.LinkBehavior = LinkBehavior.NeverUnderline;
        }


        /* Title Bar Icon Action */
        private void picExit_Click(object sender, EventArgs e)
        {
            Control.CloseWindow();
        }

        private void picMove_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Window.ReleaseCapture();
                Window.SendMessage(Handle, Window.WM_NCLBUTTONDOWN, Window.HT_CAPTION, 0);
            }
        }

        #endregion

        #region * VALIDATING INPUT
        private bool ValidatingTxtCodeNumLogin()
        {
            if (txtCodeNum.Text.Trim().Length <= 0)
            {
                txtCodeNum.Focus();
                lblCodeNum.Text = $"MÃ SỐ - Ô này là bắt buộc";
                lblCodeNum.ForeColor = ColorTheme.getTheme("danger");
                return false;
            }
            else
            {
                lblCodeNum.Text = $"MÃ SỐ";
                lblCodeNum.ForeColor = Color.FromArgb(142, 146, 151);
            }
            return true;
        }

        private bool ValidatingTxtPasswordLogin()
        {
            if (txtPassword.Text.Trim().Length <= 0)
            {
                txtPassword.Focus();
                lblPassword.Text = $"MẬT KHẨU - Ô này là bắt buộc";
                lblPassword.ForeColor = ColorTheme.getTheme("danger");
                return false;
            }
            else
            {
                lblPassword.Text = $"MẬT KHẨU";
                lblPassword.ForeColor = Color.FromArgb(142, 146, 151);
            }
            return true;
        }

        private void txtCodeNum_TextChanged(object sender, EventArgs e)
        {
            ValidatingTxtCodeNumLogin();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidatingTxtPasswordLogin();
        }

        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidatingTxtCodeNumLogin() && ValidatingTxtPasswordLogin())
            {
                string username = txtCodeNum.Text.Trim();
                string password = Password.HashPassword(txtPassword.Text.Trim());
                User userLogin = UserBUS.HandleUserLogin(username, password);
                if (userLogin != null)
                {
                    UserBUS.HandleSaveLogin(username, password);
                    Control.userLogin = userLogin;
                    Control.frmMain.Show();
                    Control.frmLogin.Hide();
                }
                else MessageBox.Show(MessageBoxText.LoginIncorrect, MessageBoxText.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(MessageBoxText.ForgotPass, MessageBoxText.CaptionInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
