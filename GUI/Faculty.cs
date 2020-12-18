using project_winform.BUS;
using project_winform.CTO;
using project_winform.DAL;
using project_winform.GUI.GUI_REPORT;
using project_winform.src.constants;
using project_winform.src.helpers;
using project_winform.src.themes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace project_winform
{
    public partial class frmFaculty : Form
    {
        public frmFaculty()
        {
            InitializeComponent();

            /* STYLE */
            #region * UI SETUP 

            lvwFaculty.Columns.Add("Mã Khoa", 140);
            lvwFaculty.Columns.Add("Tên Khoa", 185);

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

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            FacultyBUS.RenderListViewDataFaculty(lvwFaculty);

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

        private void lvwFaculty_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Sort.SortColumnsListView(e, lvwFaculty);
        }

        #endregion

        #region * ADD - UPDATE - DELETE FACULTY

        private bool CodeNumExists()
        {
            foreach (ListViewItem item in lvwFaculty.Items)
                if (item.SubItems[0].Text == txtFacultyId.Text)
                {
                    MessageBox.Show(MessageBoxText.DuplicatedCodeNum, MessageBoxText.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CodeNumExists()) return;
            if (txtFacultyId.Text.Length <= 0)
            {
                lblFacultyId.ForeColor = ColorTheme.getTheme("danger");
                txtFacultyId.Focus();
                MessageBox.Show(MessageBoxText.RequiredInput, MessageBoxText.CaptionInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Faculty faculty = new Faculty(txtFacultyId.Text, txtFacultyName.Text);
            FacultyBUS.HandleAddFaculty(lvwFaculty, faculty);

            txtFacultyId.Text = String.Empty;
            txtFacultyName.Text = String.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtFacultyId.Text.Length <= 0)
            {
                MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FacultyBUS.HandleDeleteFaculty(lvwFaculty, txtFacultyId.Text);

            txtFacultyId.Text = String.Empty;
            txtFacultyName.Text = String.Empty;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtFacultyId.Text.Length <= 0)
            {
                MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Faculty faculty = new Faculty(txtFacultyId.Text, txtFacultyName.Text);
            FacultyBUS.HandleUpdateFaculty(lvwFaculty, faculty);
        }

        #endregion

        private void lvwFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwFaculty.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwFaculty.SelectedItems[0];
                txtFacultyId.Text = item.SubItems[0].Text;
                txtFacultyName.Text = item.SubItems[1].Text;
            }
            SelectListView.SelectListViewColorForMultipleListView(lvwFaculty);
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            GuiFacultyReport report = new GuiFacultyReport();
            report.Show();
        }
    }
}
