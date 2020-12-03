using project_winform.CTO;
using project_winform.DAL;
using project_winform.src.constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_winform.BUS
{
    class FacultyBUS
    {
        public static ListViewItem FacultyModelToListViewItem(Faculty faculty)
        {
            ListViewItem item = new ListViewItem(faculty.IdFaculty);
            item.SubItems.Add(faculty.Name);
            return item;
        }

        public static void RenderComboBoxDataFaculties(ComboBox cboFaculty)
        {
            List<Faculty> faculties = FacultyDAL.GetFaculties();
            foreach (Faculty faculty in faculties)
                cboFaculty.Items.Add(faculty);
        }

        public static void RenderListViewDataFaculty(ListView lvwFaculty)
        {
            lvwFaculty.Items.Clear();
            List<Faculty> faculties = FacultyDAL.GetFaculties();
            foreach (Faculty faculty in faculties)
                lvwFaculty.Items.Add(FacultyModelToListViewItem(faculty));
        }

        public static void HandleAddFaculty(ListView lvwCourse, Faculty faculty)
        {
            bool facultyResult = FacultyDAL.CreateFaculty(faculty);
            if (facultyResult)
            {
                ListViewItem item = FacultyModelToListViewItem(faculty);
                lvwCourse.Items.Insert(0, item.Clone() as ListViewItem);

                // Select New Item When Create
                lvwCourse.Items[0].Selected = true;
                lvwCourse.Select();
            }
        }

        public static void HandleDeleteFaculty(ListView lvwCourse, string id_faculty)
        {
            foreach (ListViewItem item in lvwCourse.Items)
            {
                if (item.SubItems[0].Text == id_faculty)
                {
                    bool result = FacultyDAL.DeleteFacultyWithId(id_faculty);
                    if (result)
                    {
                        lvwCourse.Items.Remove(item);
                        RenderListViewDataFaculty(lvwCourse);
                    }
                    return;
                }
            }

            MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionNotSelectListView, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void HandleUpdateFaculty(ListView lvwMain, Faculty faculty)
        {
            bool courseResult = FacultyDAL.UpdateFacultyWithId(faculty);
            if (courseResult)
            {
                foreach (ListViewItem item in lvwMain.Items)
                    if (item.SubItems[0].Text == faculty.IdFaculty)
                    {
                        ListViewItem itemUser = FacultyModelToListViewItem(faculty);
                        for (int i = 0; i < item.SubItems.Count; i++)
                            item.SubItems[i].Text = i < itemUser.SubItems.Count ?
                                itemUser.SubItems[i].Text ?? null : string.Empty;
                    }
                RenderListViewDataFaculty(lvwMain);
            }
        }
    }
}
