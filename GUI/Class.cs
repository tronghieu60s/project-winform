using project_winform.BUS;
using project_winform.src.helpers;
using project_winform.src.themes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace project_winform
{
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();

            /* STYLE */
            #region * UI SETUP 

            lvwClass.Columns.Add("Mã Lớp", 60);
            lvwClass.Columns.Add("Tên Lớp", 95);
            lvwClass.Columns.Add("Mã Khóa", 60);
            lvwClass.Columns.Add("Mã Khoa", 60);

            lvwCourse.Columns.Add("Mã Khóa", 80);
            lvwCourse.Columns.Add("Tên Khóa", 148);

            lvwFaculty.Columns.Add("Mã Khoa", 80);
            lvwFaculty.Columns.Add("Tên Khoa", 148);

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

        private void frmClass_Load(object sender, EventArgs e)
        {
            CourseBUS.RenderListViewDataCourses(lvwCourse);
            FacultyBUS.RenderListViewDataFaculty(lvwFaculty);
            ClassBUS.RenderListViewDataClass(lvwClass);

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
            Control.frmClass.Hide();
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

        private void lvwFaculty_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Sort.SortColumnsListView(e, lvwFaculty);
        }

        private void lvwClass_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Sort.SortColumnsListView(e, lvwClass);
        }

        #endregion

        private void lvwCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwCourse.SelectedItems.Count > 0)
                txtCourse.Text = lvwCourse.SelectedItems[0].SubItems[1].Text;
            SelectListView.SelectListViewColorForMultipleListView(lvwCourse);
        }

        private void lvwFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwFaculty.SelectedItems.Count > 0)
                txtFaculty.Text = lvwFaculty.SelectedItems[0].SubItems[1].Text;
            SelectListView.SelectListViewColorForMultipleListView(lvwFaculty);
        }

        private void lvwClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectListView.SelectListViewColorForMultipleListView(lvwClass);
        }
    }
}
