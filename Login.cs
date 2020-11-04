using System;
using System.Drawing;
using System.Windows.Forms;
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
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(54, 57, 63);
        }
    }
}
