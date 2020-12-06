using MySql.Data.MySqlClient;
using project_winform.CTO;
using project_winform.src.constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace project_winform.DAL
{
    class CourseDAL: DatabaseUtils
    {
        public static List<Course> GetCourses()
        {
            DataSet coursesData = new DataSet();
            MySqlCommand command = connectDB.CreateCommand();
            command.CommandText = "SELECT * FROM `courses` ORDER BY date DESC";

            MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
            sqlData.Fill(coursesData);

            List<Course> courses = new List<Course>();
            foreach (DataRow course in coursesData.Tables[0].Rows)
            {
                string id_course = course["id_course"].ToString();
                string course_name = course["course_name"].ToString();
                courses.Add(new Course(id_course, course_name));
            }
            return courses;
        }

        public static bool CreateCourse(Course course)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "INSERT INTO `courses`(`id_course`, `course_name`) VALUES (@id_course, @course_name)";
                command.Parameters.Add(new MySqlParameter("@id_course", course.IdCourse));
                command.Parameters.Add(new MySqlParameter("@course_name", course.Name));
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

        public static bool DeleteCourseWithId(string id_course)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "DELETE FROM `courses` WHERE `courses`.`id_course` = @id_course";
                command.Parameters.Add(new MySqlParameter("@id_course", id_course));
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

        public static bool UpdateCourseWithId(Course course)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "UPDATE `courses` SET `course_name`= @course_name WHERE `id_course`= @id_course";
                command.Parameters.Add(new MySqlParameter("@id_course", course.IdCourse));
                command.Parameters.Add(new MySqlParameter("@course_name", course.Name));
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
