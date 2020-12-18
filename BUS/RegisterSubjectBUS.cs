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
    class RegisterSubjectBUS
    {
        public static ListView lvwRegisterSubjectState = new ListView();
        public static ListView lvwRegisteredSubjectState = new ListView();

        public RegisterSubjectBUS()
        {
            lvwRegisterSubjectState.Items.Clear();
            lvwRegisteredSubjectState.Items.Clear();
            new SubjectBUS();
            SubjectBUS.id_course = Control.userLogin.ClassModel.Course.IdCourse;
            SubjectBUS.id_faculty = Control.userLogin.ClassModel.Faculty.IdFaculty;
            SubjectBUS.RenderListViewWithCourseAndFaculty(lvwRegisterSubjectState);

            List<Subject> subjects = SubjectDAL.GetSubjectsWithRegisterIdUser(Control.userLogin.IdUser);
            if (subjects != null)
                foreach (Subject subject in subjects)
                {
                    foreach (ListViewItem lvwRegisterItem in lvwRegisterSubjectState.Items)
                        if (lvwRegisterItem.SubItems[0].Text == subject.IdSubject)
                            lvwRegisterSubjectState.Items.Remove(lvwRegisterItem);
                   
                    ListViewItem item = SubjectBUS.SubjectModelToListViewItem(subject);
                    lvwRegisteredSubjectState.Items.Add(item.Clone() as ListViewItem);
                }
        }

        public static ListViewItem RegisterSubjectModelToListViewItem(RegisterSubject registerSubject)
        {
            foreach (ListViewItem item in lvwRegisterSubjectState.Items)
                if (item.SubItems[0].Text == registerSubject.Id_subject)
                    return item;
            return null;
        }

        public static void RenderListViewRegisterWithIdUser(ListView lvwRegister, string id_user)
        {
           List<Subject> listSubject = SubjectDAL.GetSubjectsWithRegisterIdUser(id_user);
            foreach (Subject subject in listSubject)
            {
                ListViewItem item = SubjectBUS.SubjectModelToListViewItem(subject);
                lvwRegister.Items.Add(item.Clone() as ListViewItem);
            }
        }

        public static void RenderListViewRegisterFromState(ListView lvwRegister)
        {
            lvwRegister.Items.Clear();
            foreach (ListViewItem item in lvwRegisterSubjectState.Items)
                lvwRegister.Items.Add(item.Clone() as ListViewItem);
        }

        public static void RenderListViewRegisteredFromState(ListView lvwRegistered)
        {
            lvwRegistered.Items.Clear();
            foreach (ListViewItem item in lvwRegisteredSubjectState.Items)
                lvwRegistered.Items.Add(item.Clone() as ListViewItem);
        }

        public static void DeleteListViewRegisterWithIdSubject(string id_subject)
        {
            foreach (ListViewItem item in lvwRegisterSubjectState.Items)
                if (item.SubItems[0].Text == id_subject)
                {
                    lvwRegisterSubjectState.Items.Remove(item);
                    return;
                }
        }

        public static void HandleCreateRegisterSubject(ListView lvwRegister, ListView lvwRegistered, RegisterSubject registerSubject)
        {
            bool result = RegisterSubjectDAL.CreateRegisterSubject(registerSubject);
            if (result)
            {
                ListViewItem item = RegisterSubjectModelToListViewItem(registerSubject);
                if (item != null)
                {
                    lvwRegisteredSubjectState.Items.Insert(0, item.Clone() as ListViewItem);
                    DeleteListViewRegisterWithIdSubject(registerSubject.Id_subject);
                    RenderListViewRegisterFromState(lvwRegister);
                    RenderListViewRegisteredFromState(lvwRegistered);
                }
            }
        }
    
        public static void HandleCancelRegisteredSubject(ListView lvwRegister, ListView lvwRegistered, string id_user, string id_subject)
        {
            bool result = RegisterSubjectDAL.DeleteRegisterSubjectWithId(id_user, id_subject);
            if (result)
            {
                foreach (ListViewItem lvwRegisteredItem in lvwRegisteredSubjectState.Items)
                    if (lvwRegisteredItem.SubItems[0].Text == id_subject)
                    {
                        lvwRegisteredSubjectState.Items.Remove(lvwRegisteredItem);
                        lvwRegisterSubjectState.Items.Add(lvwRegisteredItem.Clone() as ListViewItem);
                    }

                RenderListViewRegisteredFromState(lvwRegistered);
                RenderListViewRegisterFromState(lvwRegister);
            }
        }
    }
}
