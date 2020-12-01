using project_winform.CTO;
using project_winform.DAL;
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
    }
}
