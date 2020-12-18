using project_winform.BUS;
using project_winform.CTO;
using project_winform.GUI.GUI_REPORT;
using project_winform.src.constants;
using project_winform.src.helpers;
using project_winform.src.themes;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace project_winform
{
    public partial class frmSubject : Form
    {
        public frmSubject()
        {
            InitializeComponent();

            /* STYLE */
            #region * UI SETUP 

            lvwSubject.Columns.Add("Mã Môn", 70);
            lvwSubject.Columns.Add("Tên Môn", 85);
            lvwSubject.Columns.Add("Số Tín Chỉ", 85);
            lvwSubject.Columns.Add("Thông Tin", 80);
            lvwSubject.Columns.Add("Tên Giảng Viên", 100);
            lvwSubject.Columns.Add("Ngày Bắt Đầu", 100);
            lvwSubject.Columns.Add("Ngày Kết Thúc", 100);
            lvwSubject.Columns.Add("Mã Khóa", 80);
            lvwSubject.Columns.Add("Mã Khoa", 80);

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

        private void frmSubject_Load(object sender, System.EventArgs e)
        {
            new SubjectBUS();
            CourseBUS.RenderListViewDataCourses(lvwCourse);
            FacultyBUS.RenderListViewDataFaculty(lvwFaculty);
            SubjectBUS.RenderListViewFromState(lvwSubject);

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

        /* UI CUSTOM */
        #region * (UI) CUSTOM
        /* Title Bar Hover Style */
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

        private void lvwSubject_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Sort.SortColumnsListView(e, lvwSubject);
        }

        #endregion

        #region * ADD - UPDATE - DELETE SUBJECT

        private bool CodeNumExists()
        {
            foreach (ListViewItem item in SubjectBUS.lvwSubjectState.Items)
                if (item.SubItems[0].Text == txtSubjectId.Text)
                {
                    MessageBox.Show(MessageBoxText.DuplicatedCodeNum, MessageBoxText.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CodeNumExists()) return;
            if (txtSubjectId.Text.Length <= 0)
            {
                lblSubjectId.ForeColor = ColorTheme.getTheme("danger");
                txtSubjectId.Focus();
                MessageBox.Show(MessageBoxText.RequiredInput, MessageBoxText.CaptionInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int credit = 0;
            string idSubject = txtSubjectId.Text;
            string name = txtName.Text;
            int.TryParse(txtCredit.Text, out credit);
            string information = txtInformation.Text;
            string lecturerName = txtLecturerName.Text;
            DateTime startDay = DateTime.Parse(dtpStartDay.Text);
            DateTime endDay = DateTime.Parse(dtpEndDay.Text);
            Faculty faculty = new Faculty(txtFaculty.Text, "");
            Course course = new Course(txtCourse.Text, "");
            Subject subject = new Subject(idSubject, name, credit, information, lecturerName, startDay, endDay, faculty, course);
            SubjectBUS.HandleAddSubject(lvwSubject, subject);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSubjectId.Text.Length <= 0)
            {
                MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SubjectBUS.HandleDeleteSubject(lvwSubject, txtSubjectId.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtSubjectId.Text.Length <= 0)
            {
                MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idSubject = txtSubjectId.Text;
            string name = txtName.Text;
            int credit = int.Parse(txtCredit.Text);
            string information = txtInformation.Text;
            string lecturerName = txtLecturerName.Text;
            DateTime startDay = DateTime.Parse(dtpStartDay.Text);
            DateTime endDay = DateTime.Parse(dtpEndDay.Text);
            Faculty faculty = new Faculty(txtFaculty.Text, "");
            Course course = new Course(txtCourse.Text, "");
            Subject subject = new Subject(idSubject, name, credit, information, lecturerName, startDay, endDay, faculty, course);
            SubjectBUS.HandleUpdateSubject(lvwSubject, subject);
        }

        #endregion

        #region * SELECT LISTVIEW

        private void lvwCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwCourse.SelectedItems.Count > 0)
            {
                txtCourse.Text = lvwCourse.SelectedItems[0].SubItems[0].Text;
                SubjectBUS.id_course = txtCourse.Text;
                SubjectBUS.RenderListViewWithCourseAndFaculty(lvwSubject);
            }
            SelectListView.SelectListViewColorForMultipleListView(lvwCourse);
        }

        private void lvwFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwFaculty.SelectedItems.Count > 0)
            {
                txtFaculty.Text = lvwFaculty.SelectedItems[0].SubItems[0].Text;
                SubjectBUS.id_faculty = txtFaculty.Text;
                SubjectBUS.RenderListViewWithCourseAndFaculty(lvwSubject);
            }
            SelectListView.SelectListViewColorForMultipleListView(lvwFaculty);
        }

        private void lvwSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwSubject.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwSubject.SelectedItems[0];
                txtSubjectId.Text = item.SubItems[0].Text;
                txtName.Text = item.SubItems[1].Text;
                txtCredit.Text = item.SubItems[2].Text;
                txtInformation.Text = item.SubItems[3].Text;
                txtLecturerName.Text = item.SubItems[4].Text;
                dtpStartDay.Value = DateTime.ParseExact(item.SubItems[5].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dtpEndDay.Value = DateTime.ParseExact(item.SubItems[6].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                txtCourse.Text = item.SubItems[7].Text;
                txtFaculty.Text = item.SubItems[8].Text;

                SubjectBUS.id_course = item.SubItems[7].Text;
                SubjectBUS.id_faculty = item.SubItems[8].Text;
            }
            SelectListView.SelectListViewColorForMultipleListView(lvwSubject);
        }

        #endregion

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            GuiSubjectReport report = new GuiSubjectReport();
            report.Show();
        }
    }
}
