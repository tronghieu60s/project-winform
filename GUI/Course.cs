using project_winform.src.themes;
using System;
using System.Drawing;
using project_winform.src.helpers;
using System.Windows.Forms;
using project_winform.BUS;

namespace project_winform
{
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();

            /* STYLE */
            #region * UI SETUP 
            
            lvwCourse.Columns.Add("Mã Khóa", 140);
            lvwCourse.Columns.Add("Tên Khóa", 185);

            #endregion

            #region * UI STYLE
            BackColor = ColorTheme.getTheme("secondary");

            // Hidden TitleBar
            FormBorderStyle = FormBorderStyle.None;

            // Style Title Bar
            pnlTitleBar.BackColor = ColorTheme.getTheme();
            picExit.Image = Image.FromFile(IconTheme.exit);
            picMinimize.Image = Image.FromFile(IconTheme.minimize);

            // Color Button Style
            btnAdd.BackColor = ColorTheme.getTheme("primary");
            btnDelete.BackColor = ColorTheme.getTheme("danger");
            btnEdit.BackColor = ColorTheme.getTheme("warning");
            #endregion
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            CourseBUS.RenderListViewDataCourses(lvwCourse);

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
            Control.frmCourse.Hide();
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

        /* SORT */
        #region * (LIB) SORT COLUMN IN LISTVIEW

        private void lvwCourse_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Sort.SortColumnsListView(e, lvwCourse);
        }

        #endregion

        private void lvwCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectListView.SelectListViewColorForMultipleListView(lvwCourse);
        }
    }
}
