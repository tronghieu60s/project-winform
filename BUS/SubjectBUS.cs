using project_winform.CTO;
using project_winform.DAL;
using project_winform.src.constants;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project_winform.BUS
{
    class SubjectBUS
    {
        public static ListView lvwSubjectState = new ListView();
        public static string id_course = string.Empty;
        public static string id_faculty = string.Empty;

        public SubjectBUS()
        {
            lvwSubjectState.Items.Clear();
            List<Subject> subjects = SubjectDAL.GetSubjects();
            if(subjects != null)
                foreach (Subject subject in subjects)
                {
                    ListViewItem item = SubjectModelToListViewItem(subject);
                    lvwSubjectState.Items.Add(item.Clone() as ListViewItem);
                }
        }

        public static ListViewItem SubjectModelToListViewItem(Subject subject)
        {
            ListViewItem item = new ListViewItem(subject.IdSubject);
            item.SubItems.Add(subject.Name);
            item.SubItems.Add(subject.Credit.ToString());
            item.SubItems.Add(subject.Information);
            item.SubItems.Add(subject.Lecturer.Name);
            item.SubItems.Add(subject.StartDay.ToString("dd/MM/yyyy"));
            item.SubItems.Add(subject.EndDay.ToString("dd/MM/yyyy"));
            item.SubItems.Add(subject.Course.IdCourse);
            item.SubItems.Add(subject.Faculty.IdFaculty);
            return item;
        }

        public static void RenderListViewFromState(ListView lvwSubject)
        {
            lvwSubject.Items.Clear();
            foreach (ListViewItem item in lvwSubjectState.Items)
                lvwSubject.Items.Add(item.Clone() as ListViewItem);
        }

        public static void RenderListViewWithCourseAndFaculty(ListView lvwSubject)
        {
            lvwSubject.Items.Clear();
            foreach (ListViewItem item in lvwSubjectState.Items)
                if (item.SubItems[7].Text == id_course && item.SubItems[8].Text == id_faculty)
                    lvwSubject.Items.Add(item.Clone() as ListViewItem);
        }

        public static void HandleAddSubject(ListView lvwSubject, Subject subject)
        {
            bool subjectResult = SubjectDAL.CreateSubject(subject);
            if (subjectResult)
            {
                ListViewItem item = SubjectModelToListViewItem(subject);
                lvwSubjectState.Items.Insert(0, item.Clone() as ListViewItem);
                RenderListViewWithCourseAndFaculty(lvwSubject);
            }
        }

        public static void HandleDeleteSubject(ListView lvwSubject, string id_subject)
        {
            foreach (ListViewItem item in lvwSubjectState.Items)
            {
                if (item.SubItems[0].Text == id_subject)
                {
                    bool result = SubjectDAL.DeleteSubjectWithId(id_subject);
                    if (result)
                    {
                        lvwSubjectState.Items.Remove(item);
                        RenderListViewWithCourseAndFaculty(lvwSubject);
                    }
                    return;
                }
            }

            MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void HandleUpdateSubject(ListView lvwSubject, Subject subject)
        {
            bool subjectResult = SubjectDAL.UpdateSubjectWithId(subject);
            if (subjectResult)
            {
                foreach (ListViewItem item in lvwSubjectState.Items)
                    if (item.SubItems[0].Text == subject.IdSubject)
                    {
                        ListViewItem itemUser = SubjectModelToListViewItem(subject);
                        for (int i = 0; i < item.SubItems.Count; i++)
                            item.SubItems[i].Text = i < itemUser.SubItems.Count ?
                                itemUser.SubItems[i].Text ?? null : string.Empty;
                    }
                RenderListViewWithCourseAndFaculty(lvwSubject);
            }
        }
    }
}
