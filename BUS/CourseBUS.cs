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
        public static ListViewItem CourseModelToListViewItem(Course course)
        {
            ListViewItem item = new ListViewItem(course.IdCourse);
            item.SubItems.Add(course.Name);
            return item;
        }

        public static void RenderComboBoxDataCourses(ComboBox cboCourse)
        {
            List<Course> courses = CourseDAL.GetCourses();
            foreach (Course course in courses)
                cboCourse.Items.Add(course);
        }

        public static void RenderListViewDataCourses(ListView lvwCourse)
        {
            lvwCourse.Items.Clear();
            List<Course> courses = CourseDAL.GetCourses();
            foreach (Course course in courses)
                lvwCourse.Items.Add(CourseModelToListViewItem(course));
        }
    }
}
