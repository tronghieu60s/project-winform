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

            #region * Setup Input
            // Custom Format DateTime Picker
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.CustomFormat = "dd / MM / yyyy";

            // Combobox Default
            cboTypeUser.SelectedIndex = 0;
            cboSort.SelectedIndex = 0;
            cboFilter.SelectedIndex = 0;
            #endregion

            #region * Color - Text
            BackColor = ColorTheme.getTheme("secondary");
            picLogout.Image = Image.FromFile(IconTheme.logout);
            lblWelcome.ForeColor = ColorTheme.getTheme("text-bold");
            lblWelcomeSlogan.ForeColor = ColorTheme.getTheme("text-normal");

            // Hidden TitleBar
            FormBorderStyle = FormBorderStyle.None;

            // Style Title Bar
            pnlTitleBar.BackColor = ColorTheme.getTheme();
            picExit.Image = Image.FromFile(IconTheme.exit);
            picResize.Image = Image.FromFile(IconTheme.resize);
            picMinimize.Image = Image.FromFile(IconTheme.minimize);

            // Color Button Style
            btnImportExcel.BackColor =
            btnExportExcel.BackColor = ColorTheme.getTheme("success");
            btnAdd.BackColor = ColorTheme.getTheme("primary");
            btnDelete.BackColor = ColorTheme.getTheme("danger");
            btnUpdate.BackColor = ColorTheme.getTheme("warning");
            btnSearch.BackColor = ColorTheme.getTheme("primary");
            #endregion
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            #region * Structor ListView
            // List View
            lvwMain.View = View.Details;
            lvwMain.GridLines = true;
            lvwMain.FullRowSelect = true;

            SelectTypeUser();
            #endregion

            #region * Fake Data ComboBox
            cboCourse.Items.Add("K17");
            cboCourse.Items.Add("K18");
            cboCourse.Items.Add("K19");
            cboCourse.Items.Add("K20");

            cboFaculty.Items.Add("Công Nghệ Thông Tin");
            cboFaculty.Items.Add("Quản Trị Kinh Doanh");
            cboFaculty.Items.Add("Tiếng Anh");
            cboFaculty.Items.Add("Tiếng Hàn");

            cboClass.Items.Add("CD19TT1");
            cboClass.Items.Add("CD19TT2");
            cboClass.Items.Add("CD19TT3");
            cboClass.Items.Add("CD19TT4");
            cboClass.Items.Add("CD19TT5");
            cboClass.Items.Add("CD19TT6");
            cboClass.Items.Add("CD19TT7");
            #endregion
        }

        #region * Control General
        /* Title Bar Hover Style */
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

        /* Title Bar Icon Action */
        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Control.CloseWindow();
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

        #region * Validating Input

        private bool ValidatingTxtCodeNum()
        {
            if (txtCodeNum.Text.Trim().Length <= 0)
            {
                txtCodeNum.Focus();
                lblCodeNum.ForeColor = ColorTheme.getTheme("danger");
                return false;
            }
            else lblCodeNum.ForeColor = Color.Black;
            return true;
        }

        private bool ValidatingTxtFullName()
        {
            if (txtFullName.Text.Trim().Length <= 0)
            {
                txtFullName.Focus();
                lblFullName.ForeColor = ColorTheme.getTheme("danger");
                return false;
            }
            else lblFullName.ForeColor = Color.Black;
            return true;
        }

        private bool ValidatingCboCourse()
        {
            if (cboCourse.Text.Trim().Length <= 0 || cboCourse.SelectedIndex == -1)
            {
                cboCourse.Focus();
                lblCourse.ForeColor = ColorTheme.getTheme("danger");
                return false;
            }
            else lblCourse.ForeColor = Color.Black;
            return true;
        }

        private bool ValidatingCboFaculty()
        {
            if (cboFaculty.Text.Trim().Length <= 0 || cboFaculty.SelectedIndex == -1)
            {
                cboFaculty.Focus();
                lblFaculty.ForeColor = ColorTheme.getTheme("danger");
                return false;
            }
            else lblFaculty.ForeColor = Color.Black;
            return true;
        }

        private bool ValidatingCboClass()
        {
            if (cboClass.Text.Trim().Length <= 0 || cboClass.SelectedIndex == -1)
            {
                cboClass.Focus();
                lblClass.ForeColor = ColorTheme.getTheme("danger");
                return false;
            }
            else lblClass.ForeColor = Color.Black;
            return true;
        }

        private void txtCodeNum_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingTxtCodeNum();
        }

        private void txtFullName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingTxtFullName();
        }

        private void cboCourse_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingCboCourse();
        }

        private void cboFaculty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingCboFaculty();
        }

        private void cboClass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingCboClass();
        }

        #endregion

        #region * ComboBox Type User Action
        private void SelectTypeUser()
        {
            if (cboTypeUser.SelectedIndex == 0)
                TypeUserAdmin();
            if (cboTypeUser.SelectedIndex == 1)
                TypeUserStudent();
            if (cboTypeUser.SelectedIndex == 2)
                TypeUserTeacher();
        }

        private void TypeUserAdmin()
        {
            lvwMain.Columns.Clear();
            lvwMain.Columns.Add("Mã Số", 100);
            lvwMain.Columns.Add("Họ Tên", 200);
            lvwMain.Columns.Add("Ngày Sinh", 200);

            lblCourse.Hide();
            cboCourse.Hide();
            lblFaculty.Hide();
            cboFaculty.Hide();
            lblClass.Hide();
            cboClass.Hide();
            lblExpertise.Hide();
            cboExpertise.Hide();
            lblManager.Hide();
            chkListManager.Hide();
        }

        private void TypeUserStudent()
        {
            lvwMain.Columns.Clear();
            lvwMain.Columns.Add("Mã Số", 100);
            lvwMain.Columns.Add("Họ Tên", 100);
            lvwMain.Columns.Add("Ngày Sinh", 70);
            lvwMain.Columns.Add("Khóa", 50);
            lvwMain.Columns.Add("Khoa", 100);
            lvwMain.Columns.Add("Lớp", 70);

            lblExpertise.Hide();
            cboExpertise.Hide();
            lblManager.Hide();
            chkListManager.Hide();

            lblCourse.Show();
            cboCourse.Show();
            lblFaculty.Show();
            cboFaculty.Show();
            lblClass.Show();
            cboClass.Show();
        }

        private void TypeUserTeacher()
        {
            lvwMain.Columns.Clear();
            lvwMain.Columns.Add("Mã Số", 100);
            lvwMain.Columns.Add("Họ Tên", 200);
            lvwMain.Columns.Add("Ngày Sinh", 70);
            lvwMain.Columns.Add("Chuyên môn", 130);

            lblCourse.Hide();
            cboCourse.Hide();
            lblFaculty.Hide();
            cboFaculty.Hide();
            lblClass.Hide();
            cboClass.Hide();

            lblExpertise.Show();
            cboExpertise.Show();
            lblManager.Show();
            chkListManager.Show();
        }
        #endregion

        private void picLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Control.frmLogin.Show();
                Control.frmMain.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboTypeUser.SelectedIndex == 0 || cboTypeUser.SelectedIndex == 2)
                if (ValidatingTxtCodeNum() && ValidatingTxtFullName())
                {
                    Console.WriteLine("ok");
                }
            if (cboTypeUser.SelectedIndex == 1)
                if (ValidatingTxtCodeNum() && ValidatingTxtFullName() && ValidatingCboCourse() && ValidatingCboFaculty() && ValidatingCboClass())
                {
                    Console.WriteLine("ok");
                }
        }

        private void cboTypeUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTypeUser();
        }
    }
}
