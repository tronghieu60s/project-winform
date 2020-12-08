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
    class ClassBUS
    {
        public static ListView lvwClassState = new ListView();
        public static string id_course = string.Empty;
        public static string id_faculty = string.Empty;

        public ClassBUS()
        {
            lvwClassState.Items.Clear();
            List<Class> classes = ClassDAL.GetClasses();
            foreach (Class classItem in classes)
            {
                ListViewItem item = ClassModelToListViewItem(classItem);
                lvwClassState.Items.Add(item.Clone() as ListViewItem);
            }
        }

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

        public static void RenderListViewFromState(ListView lvwClass)
        {
            lvwClass.Items.Clear();
            foreach (ListViewItem item in lvwClassState.Items)
                lvwClass.Items.Add(item.Clone() as ListViewItem);
        }

        public static void RenderListViewWithCourseAndFaculty(ListView lvwClass)
        {
            lvwClass.Items.Clear();
            foreach (ListViewItem item in lvwClassState.Items)
                if (item.SubItems[2].Text == id_course && item.SubItems[3].Text == id_faculty)
                    lvwClass.Items.Add(item.Clone() as ListViewItem);
        }

        public static void HandleAddClass(ListView lvwClass, Class classModel)
        {
            bool courseResult = ClassDAL.CreateClass(classModel);
            if (courseResult)
            {
                ListViewItem item = ClassModelToListViewItem(classModel);
                lvwClassState.Items.Insert(0, item.Clone() as ListViewItem);
                RenderListViewWithCourseAndFaculty(lvwClass);
            }
        }

        public static void HandleDeleteClass(ListView lvwClass, string id_class)
        {
            foreach (ListViewItem item in lvwClassState.Items)
            {
                if (item.SubItems[0].Text == id_class)
                {
                    bool result = ClassDAL.DeleteClassWithId(id_class);
                    if (result)
                    {
                        lvwClassState.Items.Remove(item);
                        RenderListViewFromState(lvwClass);
                    }
                    return;
                }
            }

            MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void HandleUpdateClass(ListView lvwClass, Class classModel)
        {
            bool courseResult = ClassDAL.UpdateClassWithId(classModel);
            if (courseResult)
            {
                foreach (ListViewItem item in lvwClassState.Items)
                    if (item.SubItems[0].Text == classModel.IdClass)
                    {
                        ListViewItem itemUser = ClassModelToListViewItem(classModel);
                        for (int i = 0; i < item.SubItems.Count; i++)
                            item.SubItems[i].Text = i < itemUser.SubItems.Count ?
                                itemUser.SubItems[i].Text ?? null : string.Empty;
                    }
                RenderListViewWithCourseAndFaculty(lvwClass);
            }
        }
    }
}
