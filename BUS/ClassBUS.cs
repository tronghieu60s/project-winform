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

        public static void HandleAddClass(ListView lvwCourse, Class classModel)
        {
            bool courseResult = ClassDAL.CreateClass(classModel);
            if (courseResult)
            {
                ListViewItem item = ClassModelToListViewItem(classModel);
                lvwCourse.Items.Insert(0, item.Clone() as ListViewItem);

                // Select New Item When Create
                lvwCourse.Items[0].Selected = true;
                lvwCourse.Select();
            }
        }

        public static void HandleDeleteClass(ListView lvwCourse, string id_class)
        {
            foreach (ListViewItem item in lvwCourse.Items)
            {
                if (item.SubItems[0].Text == id_class)
                {
                    bool result = ClassDAL.DeleteClassWithId(id_class);
                    if (result)
                    {
                        lvwCourse.Items.Remove(item);
                        RenderListViewDataClass(lvwCourse);
                    }
                    return;
                }
            }

            MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void HandleUpdateClass(ListView lvwMain, Class classModel)
        {
            bool courseResult = ClassDAL.UpdateClassWithId(classModel);
            if (courseResult)
            {
                foreach (ListViewItem item in lvwMain.Items)
                    if (item.SubItems[0].Text == classModel.IdClass)
                    {
                        ListViewItem itemUser = ClassModelToListViewItem(classModel);
                        for (int i = 0; i < item.SubItems.Count; i++)
                            item.SubItems[i].Text = i < itemUser.SubItems.Count ?
                                itemUser.SubItems[i].Text ?? null : string.Empty;
                    }
                RenderListViewDataClass(lvwMain);
            }
        }
    }
}
