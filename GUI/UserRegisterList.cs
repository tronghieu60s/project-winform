using project_winform.BUS;
using project_winform.src.helpers;
using project_winform.src.themes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace project_winform.GUI
{
    public partial class frmUserRegisterList : Form
    {
        private string id_user = "";

        public frmUserRegisterList(string id_user)
        {
            InitializeComponent();
            this.id_user = id_user;

            #region * UI SETUP

            lvwRegister.Columns.Add("Mã Môn", 70);
            lvwRegister.Columns.Add("Tên Môn", 85);
            lvwRegister.Columns.Add("Số Tín Chỉ", 85);
            lvwRegister.Columns.Add("Thông Tin", 80);
            lvwRegister.Columns.Add("Tên Giảng Viên", 100);
            lvwRegister.Columns.Add("Ngày Bắt Đầu", 100);
            lvwRegister.Columns.Add("Ngày Kết Thúc", 100);
            lvwRegister.Columns.Add("Mã Khóa", 80);
            lvwRegister.Columns.Add("Mã Khoa", 80);

            #endregion

            #region * UI STYLE
            BackColor = ColorTheme.getTheme("secondary");

            // Hidden TitleBar
            FormBorderStyle = FormBorderStyle.None;

            // Style Title Bar
            pnlTitleBar.BackColor = ColorTheme.getTheme();
            picExit.Image = Image.FromFile(IconTheme.exit);
            picMinimize.Image = Image.FromFile(IconTheme.minimize);
            #endregion
        }

        private void frmUserRegisterList_Load(object sender, EventArgs e)
        {
            new RegisterSubjectBUS();
            RegisterSubjectBUS.RenderListViewRegisterWithIdUser(lvwRegister, id_user);

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
            this.Close();
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

        #endregion

        private void lvwRegister_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Sort.SortColumnsListView(e, lvwRegister);
        }
    }
}
