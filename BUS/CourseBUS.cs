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

        public static void HandleAddCourse(ListView lvwCourse, Course course)
        {
            bool courseResult = CourseDAL.CreateCourse(course);
            if (courseResult)
            {
                ListViewItem item = CourseModelToListViewItem(course);
                lvwCourse.Items.Insert(0, item.Clone() as ListViewItem);

                // Select New Item When Create
                lvwCourse.Items[0].Selected = true;
                lvwCourse.Select();
            }
        }
    
        public static void HandleDeleteCourse(ListView lvwCourse, string id_course)
        {
            foreach (ListViewItem item in lvwCourse.Items)
            {
                if (item.SubItems[0].Text == id_course)
                {
                    bool result = CourseDAL.DeleteCourseWithId(id_course);
                    if (result)
                    {
                        lvwCourse.Items.Remove(item);
                        RenderListViewDataCourses(lvwCourse);
                    }
                    return;
                }
            }

            MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionNotSelectListView, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void HandleUpdateCourse(ListView lvwMain, Course course)
        {
            bool courseResult = CourseDAL.UpdateCourseWithId(course);
            if (courseResult)
            {
                foreach (ListViewItem item in lvwMain.Items)
                    if (item.SubItems[0].Text == course.IdCourse)
                    {
                        ListViewItem itemUser = CourseModelToListViewItem(course);
                        for (int i = 0; i < item.SubItems.Count; i++)
                            item.SubItems[i].Text = i < itemUser.SubItems.Count ?
                                itemUser.SubItems[i].Text ?? null : string.Empty;
                    }
                RenderListViewDataCourses(lvwMain);
            }
        }
    }
}
