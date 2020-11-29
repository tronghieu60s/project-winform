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
        public static void RenderComboBoxDataClasses(ComboBox cboClass, string id_course, string id_faculty)
        {
            List<Class> classes = ClassDAL.getClassesWithIdCourseAndIdFaculty(id_course, id_faculty);
            foreach (Class classItem in classes)
                cboClass.Items.Add(classItem);
        }
    }
}
