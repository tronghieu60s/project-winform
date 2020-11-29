using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using project_winform.BUS;
using project_winform.CTO;
using project_winform.DAL;
using project_winform.src.constants;
using project_winform.src.helpers;
using project_winform.src.themes;

namespace project_winform
{
    public partial class frmMain : Form
    {
        private ListView lvwMainState = new ListView();

        public frmMain()
        {
            InitializeComponent();
            FormSetup.FormLoad(this);

            #region * UI SETUP 
            // List View
            lvwMain.View = View.Details;
            lvwMain.GridLines = true;
            lvwMain.FullRowSelect = true;

            // Custom Format DateTime Picker
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.CustomFormat = "dd / MM / yyyy";

            // Default Input Data
            cboTypeUser.SelectedIndex = 1;
            radSearchCodeNum.Checked = true;
            lvwMain.MultiSelect = false;
            #endregion

            #region * UI STYLE
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
            UserBUS.RenderListViewAllDataUser();
            SelectTypeUser();
        }

        #region * UI TAB BAR
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

        #region * FILTER TYPE USER
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
            UserBUS.ListViewRenderWithPermission(lvwMain, "AD");

            lvwMain.Columns.Clear();
            lvwMain.Columns.Add("Mã Số", 100);
            lvwMain.Columns.Add("Họ Tên", 200);
            lvwMain.Columns.Add("Ngày Sinh", 100);

            lblCourse.Hide();
            cboCourse.Hide();
            lblFaculty.Hide();
            cboFaculty.Hide();
            lblClass.Hide();
            cboClass.Hide();
            lblManager.Hide();
            chkListManager.Hide();
        }

        private void TypeUserStudent()
        {
            UserBUS.ListViewRenderWithPermission(lvwMain, "SD");

            lvwMain.Columns.Clear();
            lvwMain.Columns.Add("Mã Số", 100);
            lvwMain.Columns.Add("Họ Tên", 100);
            lvwMain.Columns.Add("Ngày Sinh", 70);
            lvwMain.Columns.Add("Khóa", 50);
            lvwMain.Columns.Add("Khoa", 100);
            lvwMain.Columns.Add("Lớp", 70);

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
            lvwMain.Columns.Add("Khoa", 130);

            lblCourse.Hide();
            cboCourse.Hide();
            lblClass.Hide();
            cboClass.Hide();

            lblFaculty.Show();
            cboFaculty.Show();
            lblManager.Show();
            chkListManager.Show();
        }
        #endregion

        #region * Validating Input

        private bool ValidatingTxtCodeNum()
        {
            if (chkRandomCodeNum.Checked) return true;
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

        #region * Add Data User
        private int RandomCodeNum()
        {
            Random rd = new Random();
            int random = rd.Next(10000000, 99999999);
            // Recursive Random
            foreach (ListViewItem item in lvwMainState.Items)
                if (item.SubItems[0].Text == random.ToString())
                    return RandomCodeNum();
            return random;
        }

        private void AddUserAdmin()
        {
            if (ValidatingTxtCodeNum() && ValidatingTxtFullName())
            {
                string[] arrData = new string[3];
                if (chkRandomCodeNum.Checked)
                    arrData[0] = txtCodeNum.Text = RandomCodeNum().ToString();
                else arrData[0] = txtCodeNum.Text;
                arrData[1] = txtFullName.Text;
                arrData[2] = dtpBirthday.Text;

                ListViewItem item = new ListViewItem(arrData);
                lvwMain.Items.Add(item);
            }
            else MessageBox.Show(MessageBoxText.RequiredInput, MessageBoxText.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AddUserStudent()
        {
            if (ValidatingTxtCodeNum() && ValidatingTxtFullName() && ValidatingCboCourse() && ValidatingCboFaculty() && ValidatingCboClass())
            {
                string[] arrData = new string[6];
                if (chkRandomCodeNum.Checked)
                    arrData[0] = txtCodeNum.Text = RandomCodeNum().ToString();
                else arrData[0] = txtCodeNum.Text;
                arrData[1] = txtFullName.Text;
                arrData[2] = dtpBirthday.Text;
                arrData[3] = cboCourse.SelectedItem.ToString();
                arrData[4] = cboFaculty.SelectedItem.ToString();
                arrData[5] = cboClass.SelectedItem.ToString();

                ListViewItem item = new ListViewItem(arrData);
                lvwMain.Items.Add(item);
            }
            else MessageBox.Show(MessageBoxText.RequiredInput, MessageBoxText.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AddUserTeacher()
        {
            if (ValidatingTxtCodeNum() && ValidatingTxtFullName() && ValidatingCboFaculty())
            {
                string[] arrData = new string[6];
                if (chkRandomCodeNum.Checked)
                    arrData[0] = txtCodeNum.Text = RandomCodeNum().ToString();
                else arrData[0] = txtCodeNum.Text;
                arrData[1] = txtFullName.Text;
                arrData[2] = dtpBirthday.Text;
                arrData[3] = cboFaculty.SelectedItem.ToString();

                ListViewItem item = new ListViewItem(arrData);
                lvwMain.Items.Add(item);
            }
            else MessageBox.Show(MessageBoxText.RequiredInput, MessageBoxText.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region * Menu Strip List View
        private void DeleteItemListView()
        {
            foreach (ListViewItem itemMain in lvwMain.SelectedItems)
            {
                lvwMain.Items.Remove(itemMain);
                foreach (ListViewItem itemMainState in lvwMainState.Items)
                    if (itemMainState.SubItems[0].Text == itemMain.SubItems[0].Text)
                        lvwMainState.Items.Remove(itemMainState);
            }
            CountNumberListView();
        }

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

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItemListView();
        }

        private void xóaNhiềuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (xóaNhiềuToolStripMenuItem.Text == "Xóa Nhiều")
            {
                xóaNhiềuToolStripMenuItem.Text = "Hủy Xóa Nhiều";
                lvwMain.MultiSelect = true;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                xóaNhiềuToolStripMenuItem.Text = "Hủy Xóa Nhiều";
                lvwMain.MultiSelect = false;
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        #endregion

        #region * Handle Small Modules
        private void txtCodeNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void chkRandomCodeNum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRandomCodeNum.Checked)
                txtCodeNum.Enabled = false;
            else txtCodeNum.Enabled = true;
        }

        private void radCheckedSearch(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        #endregion

        #region * Sort Column in ListView
        private void lvwMain_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = lvwMain.ListViewItemSorter as ItemComparer;

            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                lvwMain.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (e.Column == sorter.Column)
            {
                // Reverse the current sort direction
                if (sorter.Order == SortOrder.Ascending)
                    sorter.Order = SortOrder.Descending;
                else
                    sorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }
            lvwMain.Sort();
        }
        #endregion

        #region * Handle Button Add, Edit, Delete
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!chkRandomCodeNum.Checked)
                foreach (ListViewItem item in lvwMainState.Items)
                    if (item.SubItems[0].Text == txtCodeNum.Text)
                    {
                        MessageBox.Show(MessageBoxText.DuplicatedCodeNum, MessageBoxText.CaptionDuplicatedCodeNum, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

            if (cboTypeUser.SelectedIndex == 0)
                AddUserAdmin();
            if (cboTypeUser.SelectedIndex == 1)
                AddUserStudent();
            if (cboTypeUser.SelectedIndex == 2)
                AddUserTeacher();
            SaveListViewToBase();
            CountNumberListView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteItemListView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwMain.Items)
            {
                if (item.SubItems[0].Text == txtCodeNum.Text)
                {
                    item.SubItems[1].Text = txtFullName.Text;
                    item.SubItems[2].Text = dtpBirthday.Text;
                    item.SubItems[3].Text = cboCourse.Text;
                    item.SubItems[4].Text = cboFaculty.Text;
                    item.SubItems[5].Text = cboClass.Text;
                }
            }
        }
        #endregion

        private void CountNumberListView()
        {
            int number = lvwMain.Items.Count;
            lblCountItemListView.Text = $"{number} mục";
        }

        private void SaveListViewToBase()
        {
            lvwMainState.Items.Clear();
            ListViewItem itemClone;
            foreach (ListViewItem item in lvwMain.Items)
            {
                itemClone = item.Clone() as ListViewItem;
                lvwMainState.Items.Add(itemClone);
            }
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(MessageBoxText.Logout, MessageBoxText.CaptionLogout, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Control.frmLogin.Show();
                Control.frmMain.Hide();
            }
        }

        private void cboTypeUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTypeUser();
        }

        private void cboFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkListManager.Items.Clear();
            if (cboFaculty.SelectedIndex == 0)
            {
                // while or for
                chkListManager.Items.Add("CD19TT1");
                chkListManager.Items.Add("CD19TT2");
                chkListManager.Items.Add("CD19TT3");
                chkListManager.Items.Add("CD19TT4");
                chkListManager.Items.Add("CD19TT5");
                chkListManager.Items.Add("CD19TT6");
            }
        }

        private void SearchNameListView(object sender, EventArgs e)
        {
            ListViewItem itemClone;
            if (txtSearch.Text == string.Empty)
            {
                lvwMain.Items.Clear();
                foreach (ListViewItem item in lvwMainState.Items)
                {
                    itemClone = item.Clone() as ListViewItem;
                    lvwMain.Items.Add(itemClone);
                }
                CountNumberListView();
                return;
            }

            ListView lvwTemporary = new ListView();
            foreach (ListViewItem item in lvwMainState.Items)
            {
                itemClone = item.Clone() as ListViewItem;
                if (radSearchCodeNum.Checked)
                    if (item.SubItems[0].Text.Trim().ToLower() == txtSearch.Text.Trim().ToLower())
                        lvwTemporary.Items.Add(itemClone);
                if (radSearchName.Checked)
                    if (item.SubItems[1].Text.Trim().ToLower() == txtSearch.Text.Trim().ToLower())
                        lvwTemporary.Items.Add(itemClone);
            }

            lvwMain.Items.Clear();
            foreach (ListViewItem item in lvwTemporary.Items)
            {
                itemClone = item.Clone() as ListViewItem;
                lvwMain.Items.Add(itemClone);
            }

            CountNumberListView();
        }

        private void lvwMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwMain.SelectedItems)
            {
                txtCodeNum.Text = item.SubItems[0].Text;
                txtFullName.Text = item.SubItems[1].Text;
                dtpBirthday.Value = DateTime.ParseExact(item.SubItems[2].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                cboCourse.Text = item.SubItems[3].Text;
                cboFaculty.Text = item.SubItems[4].Text;
                cboClass.Text = item.SubItems[5].Text;
            }
        }
    }
}
