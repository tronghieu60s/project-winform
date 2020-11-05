using System;
using System.Drawing;
using System.Windows.Forms;
using project_winform.src.helpers;
using project_winform.src.themes;

namespace project_winform
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            FormSetup.FormLoad(this);

            // Hidden TitleBar
            FormBorderStyle = FormBorderStyle.None;

            // Custom Format DateTime Picker
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd / MM / yyyy";

            // Combobox Default
            cboTypeUser.SelectedIndex = 0;
            cboSort.SelectedIndex = 0;
            cboFilter.SelectedIndex = 0;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            /* --- Title Bar ---  */
            // Style Color
            pnlTitleBar.BackColor = ColorTheme.getTheme();

            // Style Button Title Bar
            picExit.Image = Image.FromFile(IconTheme.exit);
            picResize.Image = Image.FromFile(IconTheme.resize);
            picMinimize.Image = Image.FromFile(IconTheme.minimize);

            /* --- Style General --- */
            BackColor = ColorTheme.getTheme("secondary");
            picLogout.Image = Image.FromFile(IconTheme.logout);
            lblWelcome.ForeColor = ColorTheme.getTheme("text-bold");
            lblWelcomeSlogan.ForeColor = ColorTheme.getTheme("text-normal");

            // Color Button
            btnImportExcel.BackColor =
            btnExportExcel.BackColor = ColorTheme.getTheme("success");
            btnAdd.BackColor = ColorTheme.getTheme("primary");
            btnDelete.BackColor = ColorTheme.getTheme("danger");
            btnUpdate.BackColor = ColorTheme.getTheme("warning");
            btnSearch.BackColor = ColorTheme.getTheme("primary");

            /* --- List View --- */
            lvwMain.View = View.Details;
            lvwMain.GridLines = true;
            lvwMain.FullRowSelect = true;

            lvwMain.Columns.Add("Mã Số", 100);
            lvwMain.Columns.Add("Họ Tên", 100);
            lvwMain.Columns.Add("Ngày Sinh", 70);
            lvwMain.Columns.Add("Khóa", 50);
            lvwMain.Columns.Add("Khoa", 100);
            lvwMain.Columns.Add("Lớp", 70);
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

        // Action Pic Icon
        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        // Move Window Action
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Window.ReleaseCapture();
                Window.SendMessage(Handle, Window.WM_NCLBUTTONDOWN, Window.HT_CAPTION, 0);
            }
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(ColorTheme.getTheme(), 8), DisplayRectangle);
        }
    }
}
