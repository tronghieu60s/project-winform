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
    class CourseBUS
    {
        public static void RenderComboBoxDataCourses(ComboBox cboCourse)
        {
            List<Course> courses = CourseDAL.getAllCourses();
            foreach (Course course in courses)
                cboCourse.Items.Add(course);
        }
    }
}
