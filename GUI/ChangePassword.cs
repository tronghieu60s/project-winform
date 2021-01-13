using project_winform.BUS;
using project_winform.src.constants;
using project_winform.src.helpers;
using project_winform.src.themes;
using System;
using System.Windows.Forms;

namespace project_winform.GUI
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();

            #region * UI SETUP
            // Password Char
            txtPassOld.PasswordChar = '\u25CF';
            txtPassNew.PasswordChar = '\u25CF';
            txtRePassNew.PasswordChar = '\u25CF';
            #endregion

            #region * UI STYLE
            btnChangePassword.BackColor = ColorTheme.getTheme("primary");
            btnPassGenerator.BackColor = ColorTheme.getTheme("success");
            #endregion
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            // Load Initial Config
            FormSetup.FormLoad(this);
        }

        #region * VALIDATING
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

        #region * PASSWORD

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!ValidatingTxtPassOld() || !ValidatingTxtPassNew() || !ValidatingTxtRePassNew())
            {
                MessageBox.Show(MessageBoxText.RequiredInput, MessageBoxText.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserBUS.HandleChangePassword(txtPassOld.Text, txtPassNew.Text, txtRePassNew.Text);
            txtPassOld.Text = string.Empty;
            txtPassNew.Text = string.Empty;
            txtRePassNew.Text = string.Empty;
        }

        private void btnPassGenerator_Click(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox(MessageBoxText.GeneratorPassword, MessageBoxText.CaptionSuccess, Password.GeneratorPassword(12));
            if (result.Length > 0) txtPassNew.Text = result;
        }

        #endregion
    }
}
