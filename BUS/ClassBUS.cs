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
    class ClassBUS
    {
        public static ListViewItem ClassModelToListViewItem(Class classItem)
        {
            ListViewItem item = new ListViewItem(classItem.IdClass);
            item.SubItems.Add(classItem.Name);
            item.SubItems.Add(classItem.Course.IdCourse);
            item.SubItems.Add(classItem.Faculty.IdFaculty);
            return item;
        }

        public static void RenderComboBoxDataClasses(ComboBox cboClass, string id_course, string id_faculty)
        {
            List<Class> classes = ClassDAL.GetClassesWithIdCourseAndIdFaculty(id_course, id_faculty);
            foreach (Class classItem in classes)
                cboClass.Items.Add(classItem);
        }

        public static void RenderListViewDataClass(ListView lvwClass)
        {
            lvwClass.Items.Clear();
            List<Class> classes = ClassDAL.GetClasses();
            foreach (Class classItem in classes)
                lvwClass.Items.Add(ClassModelToListViewItem(classItem));
        }
    }
}
