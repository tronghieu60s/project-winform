using MySql.Data.MySqlClient;
using project_winform.CTO;
using project_winform.src.constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace project_winform.DAL
{
    class ClassDAL: DatabaseUtils
    {
        private static Class GetClassFromDataRow(DataRow user)
        {
            Faculty faculty = new Faculty(user["id_faculty"].ToString(), user["faculty_name"].ToString());
            Course course = new Course(user["id_course"].ToString(), user["course_name"].ToString());
            return new Class(user["id_class"].ToString(), user["class_name"].ToString(), faculty, course);
        }

        public static List<Class> GetClasses()
        {
            try
            {
                DataSet classesData = new DataSet();
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "SELECT * FROM `classes` LEFT JOIN `faculties` ON `faculties`.`id_faculty`= `classes`.`id_faculty` LEFT JOIN `courses` ON `courses`.`id_course` = `classes`.`id_course` ORDER BY `classes`.`date` DESC";

                MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
                sqlData.Fill(classesData);

                List<Class> classList = new List<Class>();
                foreach (DataRow classItem in classesData.Tables[0].Rows)
                    classList.Add(GetClassFromDataRow(classItem));
                return classList;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public static Class GetClassWithName(string class_name)
        {
            try
            {
                DataSet usersData = new DataSet();
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "SELECT * FROM `classes` LEFT JOIN `courses` ON `courses`.`id_course` = `classes`.`id_course` LEFT JOIN `faculties` ON `faculties`.`id_faculty` = `classes`.`id_faculty` WHERE `classes`.`class_name` = @class_name";
                command.Parameters.Add(new MySqlParameter("@class_name", class_name));

                MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
                sqlData.Fill(usersData);

                if (usersData.Tables[0].Rows.Count <= 0) return null;
                DataRow user = usersData.Tables[0].Rows[0];

                return GetClassFromDataRow(user);
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public static List<Class> GetClassesWithIdCourseAndIdFaculty(string id_course, string id_faculty)
        {
            try
            {
                DataSet classesData = new DataSet();
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "SELECT * FROM `classes` LEFT JOIN `courses` ON `courses`.`id_course` = `classes`.`id_course` LEFT JOIN `faculties` ON `faculties`.`id_faculty` = `classes`.`id_faculty` WHERE `courses`.`id_course` = @id_course AND `faculties`.`id_faculty` = @id_faculty";
                command.Parameters.Add(new MySqlParameter("@id_course", id_course));
                command.Parameters.Add(new MySqlParameter("@id_faculty", id_faculty));

                MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
                sqlData.Fill(classesData);

                List<Class> classes = new List<Class>();
                foreach (DataRow classItem in classesData.Tables[0].Rows)
                {
                    string id_class = classItem["id_class"].ToString();
                    string class_name = classItem["class_name"].ToString();
                    Faculty faculty = new Faculty(classItem["id_faculty"].ToString(), classItem["faculty_name"].ToString());
                    Course course = new Course(classItem["id_course"].ToString(), classItem["course_name"].ToString());
                    classes.Add(new Class(id_class, class_name, faculty, course));
                }
                return classes;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public static bool CreateClass(Class classModel)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "INSERT INTO `classes`(`id_class`, `id_course`, `id_faculty`, `class_name`) VALUES (@id_class, @id_course, @id_faculty, @class_name)";
                command.Parameters.Add(new MySqlParameter("@id_class", classModel.IdClass));
                command.Parameters.Add(new MySqlParameter("@id_course", classModel.Course.IdCourse));
                command.Parameters.Add(new MySqlParameter("@id_faculty", classModel.Faculty.IdFaculty));
                command.Parameters.Add(new MySqlParameter("@class_name", classModel.Name));
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

        public static bool DeleteClassWithId(string id_class)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "DELETE FROM `classes` WHERE `classes`.`id_class` = @id_class";
                command.Parameters.Add(new MySqlParameter("@id_class", id_class));
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

        public static bool UpdateClassWithId(Class classModel)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "UPDATE `classes` SET `id_course`= @id_course,`id_faculty`= @id_faculty,`class_name`= @class_name WHERE `id_class`= @id_class";
                command.Parameters.Add(new MySqlParameter("@id_class", classModel.IdClass));
                command.Parameters.Add(new MySqlParameter("@id_course", classModel.Course.IdCourse));
                command.Parameters.Add(new MySqlParameter("@id_faculty", classModel.Faculty.IdFaculty));
                command.Parameters.Add(new MySqlParameter("@class_name", classModel.Name));
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
