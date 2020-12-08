using MySql.Data.MySqlClient;
using project_winform.CTO;
using project_winform.src.constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace project_winform.DAL
{
    class SubjectDAL : DatabaseUtils
    {
        private static Subject GetSubjectFromDataRow(DataRow subject)
        {
            string sStartDay = subject["start_day"].ToString();
            if (sStartDay.Length > 0) sStartDay = sStartDay.Substring(0, 10);
            else sStartDay = new DateTime(1900, 1, 1).ToString();

            string sEndDay = subject["end_day"].ToString();
            if (sEndDay.Length > 0) sEndDay = sEndDay.Substring(0, 10);
            else sEndDay = new DateTime(1900, 1, 1).ToString();

            string idSubject = subject["id_subjects"].ToString();
            string name = subject["subject_name"].ToString();
            int credit = int.Parse(subject["credit"].ToString());
            string information = subject["information"].ToString();
            string lecturerName = subject["lecturer_name"].ToString();
            DateTime startDay = DateTime.Parse(sStartDay);
            DateTime endDay = DateTime.Parse(sEndDay);
            Faculty faculty = new Faculty(subject["id_faculty"].ToString(), subject["faculty_name"].ToString());
            Course course = new Course(subject["id_course"].ToString(), subject["course_name"].ToString());
            return new Subject(idSubject, name, credit, information, lecturerName, startDay, endDay, faculty, course);
        }

        private static Subject GetSubjectRegisterFromDataRow(DataRow subject)
        {
            string sStartDay = subject["start_day"].ToString();
            if (sStartDay.Length > 0) sStartDay = sStartDay.Substring(0, 10);
            else sStartDay = new DateTime(1900, 1, 1).ToString();

            string sEndDay = subject["end_day"].ToString();
            if (sEndDay.Length > 0) sEndDay = sEndDay.Substring(0, 10);
            else sEndDay = new DateTime(1900, 1, 1).ToString();

            string idSubject = subject["id_subjects"].ToString();
            string name = subject["subject_name"].ToString();
            int credit = int.Parse(subject["credit"].ToString());
            string information = subject["information"].ToString();
            string lecturerName = subject["lecturer_name"].ToString();
            DateTime startDay = DateTime.Parse(sStartDay);
            DateTime endDay = DateTime.Parse(sEndDay);
            Faculty faculty = new Faculty(subject["id_faculty"].ToString(), "");
            Course course = new Course(subject["id_course"].ToString(), "");
            return new Subject(idSubject, name, credit, information, lecturerName, startDay, endDay, faculty, course);
        }

        public static List<Subject> GetSubjects()
        {
            try
            {
                DataSet subjectsData = new DataSet();
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "SELECT * FROM `subjects` LEFT JOIN `courses` ON `courses`.`id_course` = `subjects`.`id_course` LEFT JOIN `faculties` ON `faculties`.`id_faculty` = `subjects`.`id_faculty` ORDER BY `subjects`.`date` DESC";

                MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
                sqlData.Fill(subjectsData);

                List<Subject> subjectList = new List<Subject>();
                foreach (DataRow subject in subjectsData.Tables[0].Rows)
                    subjectList.Add(GetSubjectFromDataRow(subject));
                return subjectList;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public static List<Subject> GetSubjectsWithRegisterIdUser(string id_user)
        {
            try
            {
                DataSet subjectsData = new DataSet();
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "SELECT * FROM `registers_user_subject` LEFT JOIN `users` ON `users`.`id_user` = `registers_user_subject`.`id_user` LEFT JOIN `subjects` ON `subjects`.`id_subjects` = `registers_user_subject`.`id_subject` WHERE `registers_user_subject`.`id_user` = @id_user ORDER BY `registers_user_subject`.`date` DESC";
                command.Parameters.Add(new MySqlParameter("@id_user", id_user));

                MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
                sqlData.Fill(subjectsData);

                List<Subject> subjectList = new List<Subject>();
                foreach (DataRow subject in subjectsData.Tables[0].Rows)
                    subjectList.Add(GetSubjectRegisterFromDataRow(subject));
                return subjectList;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public static bool CreateSubject(Subject subject)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "INSERT INTO `subjects`(`id_subjects`, `subject_name`, `credit`, `information`, `lecturer_name`, `start_day`, `end_day`, `id_course`, `id_faculty`) VALUES (@id_subjects, @subject_name, @credit, @information, @lecturer_name, @start_day, @end_day, @id_course, @id_faculty)";
                command.Parameters.Add(new MySqlParameter("@id_subjects", subject.IdSubject));
                command.Parameters.Add(new MySqlParameter("@subject_name", subject.Name));
                command.Parameters.Add(new MySqlParameter("@credit", subject.Credit));
                command.Parameters.Add(new MySqlParameter("@information", subject.Information));
                command.Parameters.Add(new MySqlParameter("@lecturer_name", subject.LecturerName));
                command.Parameters.Add(new MySqlParameter("@start_day", subject.StartDay));
                command.Parameters.Add(new MySqlParameter("@end_day", subject.EndDay));
                command.Parameters.Add(new MySqlParameter("@id_course", subject.Course.IdCourse));
                command.Parameters.Add(new MySqlParameter("@id_faculty", subject.Faculty.IdFaculty));
                int result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public static bool DeleteSubjectWithId(string id_subject)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "DELETE FROM `subjects` WHERE `subjects`.`id_subjects` = @id_subjects";
                command.Parameters.Add(new MySqlParameter("@id_subjects", id_subject));
                int result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public static bool UpdateSubjectWithId(Subject subject)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "UPDATE `subjects` SET `subject_name`= @subject_name,`credit`= @credit,`information`= @information,`lecturer_name`= @lecturer_name,`start_day`= @start_day,`end_day`= @end_day,`id_course`= @id_course,`id_faculty`= @id_faculty WHERE `subjects`.`id_subjects` = @id_subjects";
                command.Parameters.Add(new MySqlParameter("@id_subjects", subject.IdSubject));
                command.Parameters.Add(new MySqlParameter("@subject_name", subject.Name));
                command.Parameters.Add(new MySqlParameter("@credit", subject.Credit));
                command.Parameters.Add(new MySqlParameter("@information", subject.Information));
                command.Parameters.Add(new MySqlParameter("@lecturer_name", subject.LecturerName));
                command.Parameters.Add(new MySqlParameter("@start_day", subject.StartDay));
                command.Parameters.Add(new MySqlParameter("@end_day", subject.EndDay));
                command.Parameters.Add(new MySqlParameter("@id_course", subject.Course.IdCourse));
                command.Parameters.Add(new MySqlParameter("@id_faculty", subject.Faculty.IdFaculty));
                int result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
    }
}
