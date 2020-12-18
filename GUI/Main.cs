using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using project_winform.BUS;
using project_winform.CTO;
using project_winform.GUI.GUI_REPORT;
using project_winform.src.config;
using project_winform.src.constants;
using project_winform.src.helpers;
using project_winform.src.themes;

namespace project_winform
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            /* STYLE */
            #region * UI SETUP 
            lvwMain.CheckBoxes = true;
            lvwMain.AllowColumnReorder = true;

            // Password Char
            txtPassOld.PasswordChar = '\u25CF';
            txtPassNew.PasswordChar = '\u25CF';
            txtRePassNew.PasswordChar = '\u25CF';

            // Default Input Data
            cboTypeUser.SelectedIndex = 1;
            cboSelectSearch.SelectedIndex = 1;
            cboAction.SelectedIndex = 0;
            lvwMain.MultiSelect = false;

            // ComboBox Custom
            cboFaculty.DisplayMember = "Text";
            cboFaculty.ValueMember = "Value";
            cboCourse.DisplayMember = "Text";
            cboCourse.ValueMember = "Value";
            cboClass.DisplayMember = "Text";
            cboClass.ValueMember = "Value";

            cboFaculty.Format += (s, e) =>
            {
                e.Value = ((Faculty)e.Value).Name;
            };

            cboCourse.Format += (s, e) =>
            {
                e.Value = ((Course)e.Value).Name;
            };

            cboClass.Format += (s, e) =>
            {
                e.Value = ((Class)e.Value).Name;
            };

            #endregion

            #region * UI STYLE
            BackColor = ColorTheme.getTheme("secondary");
            picLogout.Image = Image.FromFile(IconTheme.logout);
            picReloadCourse.Image = Image.FromFile(IconTheme.reload);
            picReloadFaculty.Image = Image.FromFile(IconTheme.reload);
            lblWelcome.ForeColor = ColorTheme.getTheme("text-bold");
            lblWelcomeSlogan.ForeColor = ColorTheme.getTheme("text-normal");

            // Hidden TitleBar
            FormBorderStyle = FormBorderStyle.None;

            // Style Title Bar
            pnlTitleBar.BackColor = ColorTheme.getTheme();
            picExit.Image = Image.FromFile(IconTheme.exit);
            picMinimize.Image = Image.FromFile(IconTheme.minimize);

            // Color Button Style
            btnImportExcel.BackColor =
            btnExportExcel.BackColor = ColorTheme.getTheme("success");
            btnAdd.BackColor = ColorTheme.getTheme("primary");
            btnDelete.BackColor = ColorTheme.getTheme("danger");
            btnUpdate.BackColor = ColorTheme.getTheme("warning");
            btnAddCourse.BackColor = ColorTheme.getTheme("warning");
            btnAddFaculty.BackColor = ColorTheme.getTheme("success");
            btnAddClass.BackColor = ColorTheme.getTheme("danger");
            btnAction.BackColor = ColorTheme.getTheme("primary");
            btnChangePassword.BackColor = ColorTheme.getTheme("primary");
            btnPassGenerator.BackColor = ColorTheme.getTheme("success");
            btnShowSubject.BackColor = ColorTheme.getTheme();
            btnExportReport.BackColor = ColorTheme.getTheme("primary");
            #endregion
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            new UserBUS();
            FacultyBUS.RenderComboBoxDataFaculties(cboFaculty);
            CourseBUS.RenderComboBoxDataCourses(cboCourse);

            SelectTypeUser();

            lblWelcome.Text = "Xin chào ADMIN " + Control.userLogin.Name;

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
            DialogResult result = MessageBox.Show(MessageBoxText.ConfigExit, MessageBoxText.CaptionInformation, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
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

        /* Logout Button */
        private void picLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(MessageBoxText.Logout, MessageBoxText.CaptionInformation, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                File.Delete(Config.fileUserConfig);
                Control.userLogin = null;
                this.Hide();
                new frmLogin().Show();
            }
        }

        #endregion

        /* SORT */
        #region * (LIB) SORT COLUMN IN LISTVIEW

        private void lvwMain_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Sort.SortColumnsListView(e, lvwMain);
        }

        #endregion

        /* METHODS */
        #region * PASSWORD

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!ValidatingTxtPassOld() || !ValidatingTxtPassNew() || !ValidatingTxtRePassNew())
            {
                MessageBox.Show(MessageBoxText.RequiredInput, MessageBoxText.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserBUS.HandleChangePassword(txtPassOld.Text, txtPassNew.Text, txtRePassNew.Text);
        }

        private void btnPassGenerator_Click(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox(MessageBoxText.GeneratorPassword, MessageBoxText.CaptionSuccess, Password.GeneratorPassword(12));
            if (result.Length > 0) txtPassNew.Text = result;
        }

        #endregion

        #region * RENDER COMBOBOX CLASSES
        private void RenderComboBoxClasses()
        {
            cboClass.Items.Clear();
            cboClass.SelectedIndex = -1;
            cboClass.Text = String.Empty;
            if (cboFaculty.SelectedIndex != -1 && cboCourse.SelectedIndex != -1)
            {
                string id_course = ((Course)cboCourse.SelectedItem).IdCourse;
                string id_faculty = ((Faculty)cboFaculty.SelectedItem).IdFaculty;
                ClassBUS.RenderComboBoxDataClasses(cboClass, id_course, id_faculty);
            }
        }

        private void cboFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderComboBoxClasses();
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderComboBoxClasses();
        }

        #endregion

        #region * FILTER TYPE USER

        private void cboTypeUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTypeUser();
        }

        private void SelectTypeUser()
        {
            if (cboTypeUser.SelectedIndex == 0)
                TypeUserAdmin();
            if (cboTypeUser.SelectedIndex == 1)
                TypeUserStudent();

            UserBUS.RenderListViewDataUsersWithPermission(lvwMain);
            CountNumberListView();
        }

        private void TypeUserAdmin()
        {
            UserBUS.TypeSelectUser = Config.typeAdmin;

            cboSelectSearch.Items.Clear();
            cboSelectSearch.Items.Add("Mã Số ^");
            cboSelectSearch.Items.Add("Họ Tên");
            cboSelectSearch.Items.Add("Ngày Sinh");

            lvwMain.Columns.Clear();
            lvwMain.Columns.Add("Mã Số", 100);
            lvwMain.Columns.Add("Họ Tên", 200);
            lvwMain.Columns.Add("Ngày Sinh", 175);

            lblCourse.Hide();
            cboCourse.Hide();
            lblFaculty.Hide();
            cboFaculty.Hide();
            lblClass.Hide();
            cboClass.Hide();
            picReloadCourse.Hide();
            picReloadFaculty.Hide();

            btnAddCourse.Hide();
            btnAddFaculty.Hide();
            btnAddClass.Hide();
        }

        private void TypeUserStudent()
        {
            UserBUS.TypeSelectUser = Config.typeStudent;

            cboSelectSearch.Items.Clear();
            cboSelectSearch.Items.Add("Mã Số");
            cboSelectSearch.Items.Add("Họ Tên");
            cboSelectSearch.Items.Add("Ngày Sinh");
            cboSelectSearch.Items.Add("Khóa");
            cboSelectSearch.Items.Add("Khoa");
            cboSelectSearch.Items.Add("Lớp");

            lvwMain.Columns.Clear();
            lvwMain.Columns.Add("Mã Số", 100);
            lvwMain.Columns.Add("Họ Tên", 100);
            lvwMain.Columns.Add("Ngày Sinh", 85);
            lvwMain.Columns.Add("Khóa", 60);
            lvwMain.Columns.Add("Khoa", 90);
            lvwMain.Columns.Add("Lớp", 65);

            lblCourse.Show();
            cboCourse.Show();
            lblFaculty.Show();
            cboFaculty.Show();
            lblClass.Show();
            cboClass.Show();
            picReloadCourse.Show();
            picReloadFaculty.Show();

            btnAddCourse.Show();
            btnAddFaculty.Show();
            btnAddClass.Show();
        }

        #endregion

        #region * VALIDATING INPUT

        private bool CodeNumExists()
        {
            if (!chkRandomCodeNum.Checked)
                foreach (ListViewItem item in UserBUS.LvwMainState.Items)
                    if (item.SubItems[0].Text == $"{UserBUS.TypeSelectUser}{txtCodeNum.Text}")
                    {
                        MessageBox.Show(MessageBoxText.DuplicatedCodeNum, MessageBoxText.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
            return false;
        }

        private bool ValidatingTxtCodeNum()
        {
            if (chkRandomCodeNum.Checked) return true;
            return ValidatingInput.ValidatingInputText(txtCodeNum, lblCodeNum);
        }

        private bool ValidatingTxtFullName()
        {
            return ValidatingInput.ValidatingInputText(txtFullName, lblFullName);
        }

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

        private void txtCodeNum_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingTxtCodeNum();
        }

        private void txtFullName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingTxtFullName();
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

        private void txtCodeNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        #endregion

        #region * RELOAD COMBO BOX

        private void picReloadFaculty_Click(object sender, EventArgs e)
        {
            FacultyBUS.RenderComboBoxDataFaculties(cboFaculty);
            MessageBox.Show(MessageBoxText.ReloadDataSuccess, MessageBoxText.CaptionSuccess, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picReloadCourse_Click(object sender, EventArgs e)
        {
            CourseBUS.RenderComboBoxDataCourses(cboCourse);
            MessageBox.Show(MessageBoxText.ReloadDataSuccess, MessageBoxText.CaptionSuccess, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region * ADD - UPDATE - DELETE USER
        private void btnAction_Click(object sender, EventArgs e)
        {
            if (cboAction.SelectedItem.ToString() == "Xóa")
            {
                DialogResult result = MessageBox.Show(MessageBoxText.ConfigDelete, MessageBoxText.CaptionInformation, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    UserBUS.HandleDeleteUsersWithChecked(lvwMain);
                    CountNumberListView();
                }
            }
        }

        private void AddUser(object sender, EventArgs e)
        {
            // Validating
            if (CodeNumExists()) return;
            if (!ValidatingTxtCodeNum() || !ValidatingTxtFullName())
            {
                MessageBox.Show(MessageBoxText.RequiredInput, MessageBoxText.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboTypeUser.SelectedIndex != -1)
            {
                string id_user = chkRandomCodeNum.Checked ?
                    txtCodeNum.Text = UserBUS.RandomCodeNum(UserBUS.TypeSelectUser).ToString() : txtCodeNum.Text;
                id_user = UserBUS.TypeSelectUser + id_user;

                string password = "123456";
                string name = txtFullName.Text;
                DateTime birthday = DateTime.Parse(dtpBirthday.Text);
                Class classModal = ((Class)cboClass.SelectedItem);
                User user = new User(id_user, password, name, birthday, classModal);

                UserBUS.HandleAddUser(lvwMain, user);
                CountNumberListView();
            }
        }

        private void DeleteUser(object sender, EventArgs e)
        {
            if (txtCodeNum.Text.Length <= 0)
            {
                MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserBUS.HandleDeleteUserWithId(lvwMain, txtCodeNum.Text);
            CountNumberListView();
        }

        private void UpdateUser(object sender, EventArgs e)
        {
            if (txtCodeNum.Text.Length <= 0)
            {
                MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidatingTxtCodeNum() || !ValidatingTxtFullName())
            {
                MessageBox.Show(MessageBoxText.RequiredInput, MessageBoxText.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id_user = UserBUS.TypeSelectUser + txtCodeNum.Text;
            string name = txtFullName.Text;
            DateTime birthday = DateTime.Parse(dtpBirthday.Text);
            Class classModal = ((Class)cboClass.SelectedItem);
            User user = new User(id_user, null, name, birthday, classModal);

            UserBUS.HandleUpdateUser(lvwMain, user);
            CountNumberListView();
        }

        #endregion

        #region * SEARCH MODULES

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int selectIndex = cboSelectSearch.SelectedIndex == -1 ? 1 : cboSelectSearch.SelectedIndex;
            UserBUS.HandleSearchOnListView(lvwMain, txtSearch.Text, selectIndex);
            CountNumberListView();
        }

        private void radCheckedSearch(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        #endregion

        #region * EXCEL

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            UserBUS.HandleImportDataExcelToListView(lvwMain);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Excel.ExportDataListViewToExcel(lvwMain);
        }

        #endregion

        #region * TOOL STRIP MENU

        private void lvwMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvwMain.FocusedItem.Bounds.Contains(e.Location))
                {
                    mnuStripListView.Show(Cursor.Position);
                }
            }
        }

        #endregion

        #region * OTHERS METHODS

        private void CountNumberListView()
        {
            int number = lvwMain.Items.Count;
            lblCountItemListView.Text = $"{number} mục";
        }

        private void lvwMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMain.SelectedItems.Count <= 0) return;

            ListViewItem item = lvwMain.SelectedItems[0];
            string id = item.SubItems[0].Text;
            txtCodeNum.Text = id.Substring(2, id.Length - 2);
            txtFullName.Text = item.SubItems[1].Text;
            dtpBirthday.Value = DateTime.ParseExact(item.SubItems[2].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (UserBUS.TypeSelectUser == Config.typeStudent && item.SubItems.Count > 3)
            {
                cboCourse.SelectedIndex = -1;
                cboFaculty.SelectedIndex = -1;
                cboClass.SelectedIndex = -1;

                cboCourse.Text = item.SubItems[3].Text;
                cboFaculty.Text = item.SubItems[4].Text;
                cboClass.Text = item.SubItems[5].Text;
            }

            SelectListView.SelectListViewColorForMultipleListView(lvwMain);
        }

        private void chkRandomCodeNum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRandomCodeNum.Checked)
                txtCodeNum.Enabled = false;
            else txtCodeNum.Enabled = true;
        }

        #endregion

        #region * OPEN OTHER FORM

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmCourse frmCourse = new frmCourse();
            frmCourse.Show();
        }

        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            frmFaculty frmFaculty = new frmFaculty();
            frmFaculty.Show();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            frmClass frmClass = new frmClass();
            frmClass.Show();
        }

        #endregion

        private void btnShowSubject_Click(object sender, EventArgs e)
        {
            frmSubject frmSubject = new frmSubject();
            frmSubject.Show();
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            GuiUserReport report = new GuiUserReport();
            report.Show();
        }
    }
}
