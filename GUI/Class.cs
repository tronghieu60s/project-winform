using project_winform.BUS;
using project_winform.CTO;
using project_winform.GUI.GUI_REPORT;
using project_winform.src.constants;
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

            lvwClass.Columns.Add("Mã Lớp", 70);
            lvwClass.Columns.Add("Tên Lớp", 80);
            lvwClass.Columns.Add("Mã Khóa", 78);
            lvwClass.Columns.Add("Mã Khoa", 78);

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
            btnExportReport.BackColor = ColorTheme.getTheme("primary");
            #endregion
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            new ClassBUS();
            CourseBUS.RenderListViewDataCourses(lvwCourse);
            FacultyBUS.RenderListViewDataFaculty(lvwFaculty);
            ClassBUS.RenderListViewFromState(lvwClass);

            // Select Default
            if (lvwCourse.Items.Count > 0)
            {
                lvwCourse.Items[0].Selected = true;
                lvwCourse.Select();
            }

            if (lvwFaculty.Items.Count > 0)
            {
                lvwFaculty.Items[0].Selected = true;
                lvwFaculty.Select();
            }

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

        #region * LISTVIEW SELECTED CHANGED

        private void lvwCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwCourse.SelectedItems.Count > 0)
            {
                txtCourse.Text = lvwCourse.SelectedItems[0].SubItems[0].Text;
                ClassBUS.id_course = txtCourse.Text;
                ClassBUS.RenderListViewWithCourseAndFaculty(lvwClass);
            }
            SelectListView.SelectListViewColorForMultipleListView(lvwCourse);
        }

        private void lvwFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwFaculty.SelectedItems.Count > 0)
            {
                txtFaculty.Text = lvwFaculty.SelectedItems[0].SubItems[0].Text;
                ClassBUS.id_faculty = txtFaculty.Text;
                ClassBUS.RenderListViewWithCourseAndFaculty(lvwClass);
            }
            SelectListView.SelectListViewColorForMultipleListView(lvwFaculty);
        }

        private void lvwClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwClass.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwClass.SelectedItems[0];
                txtClassId.Text = item.SubItems[0].Text;
                txtClassName.Text = item.SubItems[1].Text;
                txtCourse.Text = item.SubItems[2].Text;
                txtFaculty.Text = item.SubItems[3].Text;
            }
            SelectListView.SelectListViewColorForMultipleListView(lvwClass);
        }

        #endregion

        #region * ADD - UPDATE - DELETE CLASS

        private bool CodeNumExists()
        {
            foreach (ListViewItem item in ClassBUS.lvwClassState.Items)
                if (item.SubItems[0].Text == txtClassId.Text)
                {
                    MessageBox.Show(MessageBoxText.DuplicatedCodeNum, MessageBoxText.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CodeNumExists()) return;
            if(txtClassId.Text.Length <= 0)
            {
                lblClassId.ForeColor = ColorTheme.getTheme("danger");
                txtClassId.Focus();
                MessageBox.Show(MessageBoxText.RequiredInput, MessageBoxText.CaptionInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Class classModel = new Class(txtClassId.Text, txtClassName.Text, new Faculty(txtFaculty.Text, ""), new Course(txtCourse.Text, ""));
            ClassBUS.HandleAddClass(lvwClass, classModel);

            txtClassId.Text = String.Empty;
            txtClassName.Text = String.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtClassId.Text.Length <= 0)
            {
                MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClassBUS.HandleDeleteClass(lvwClass, txtClassId.Text);

            txtClassId.Text = String.Empty;
            txtClassName.Text = String.Empty;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtClassId.Text.Length <= 0)
            {
                MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Class classModel = new Class(txtClassId.Text, txtClassName.Text, new Faculty(txtFaculty.Text, ""), new Course(txtCourse.Text, ""));
            ClassBUS.HandleUpdateClass(lvwClass, classModel);
        }

        #endregion

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            GuiClassReport guiClassReport = new GuiClassReport();
            guiClassReport.Show();
        }
    }
}
