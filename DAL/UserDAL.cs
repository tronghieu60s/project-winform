using MySql.Data.MySqlClient;
using project_winform.CTO;
using project_winform.dal;
using project_winform.src.constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace project_winform.DAL
{
    class UserDAL : DatabaseUtils
    {

        private static User getUserFromDataRow(DataRow user)
        {
            string sBirthday = user["birthday"].ToString();
            if (sBirthday.Length > 0) sBirthday = sBirthday.Substring(0, 10);
            else sBirthday = new DateTime(1900, 1, 1).ToString();

            string id_user = user["id_user"].ToString();
            string password = user["password"].ToString();
            string name = user["name"].ToString();
            string permission = user["permission"].ToString();
            DateTime birthday = DateTime.Parse(sBirthday);
            Faculty faculty = new Faculty(user["id_faculty"].ToString(), user["faculty_name"].ToString());
            Course course = new Course(user["id_course"].ToString(), user["course_name"].ToString());
            Class classModal = new Class(user["id_class"].ToString(), user["class_name"].ToString(), faculty, course);
            return new User(id_user, password, name, permission, birthday, classModal);
        }

        public static List<User> getUsers()
        {
            try
            {
                DataSet usersData = new DataSet();
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "SELECT *  FROM `users` LEFT JOIN `classes` ON `classes`.`id_class`= `users`.`id_class` LEFT JOIN `courses` ON `courses`.`id_course` = `classes`.`id_course` LEFT JOIN `faculties` ON `faculties`.`id_faculty` = `classes`.`id_faculty`";
                // command.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
                sqlData.Fill(usersData);

                List<User> users = new List<User>();
                foreach (DataRow user in usersData.Tables[0].Rows)
                    users.Add(getUserFromDataRow(user));
                return users;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionException, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public static User getUserWithId(string id)
        {
            try
            {
                DataSet usersData = new DataSet();
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "SELECT *  FROM `users` LEFT JOIN `classes` ON `classes`.`id_class`= `users`.`id_class` LEFT JOIN `courses` ON `courses`.`id_course` = `classes`.`id_course` LEFT JOIN `faculties` ON `faculties`.`id_faculty` = `classes`.`id_faculty` WHERE `users`.`id_user` =  @id_user";
                command.Parameters.Add(new MySqlParameter("@id_user", id));

                MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
                sqlData.Fill(usersData);

                if (usersData.Tables[0].Rows.Count <= 0) return null;
                DataRow user = usersData.Tables[0].Rows[0];

                return getUserFromDataRow(user);
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionException, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public static bool addUser(User user)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                Class classModel = user.ClassModel;
                command.CommandText = "INSERT INTO `users`(`id_user`, `password`, `name`, `permission`, `birthday`, `id_class`) VALUES (@id_user, @password, @name, @permission, @birthday, @id_class)";
                command.Parameters.Add(new MySqlParameter("@id_user", user.IdUser));
                command.Parameters.Add(new MySqlParameter("@password", user.Password));
                command.Parameters.Add(new MySqlParameter("@name", user.Name));
                command.Parameters.Add(new MySqlParameter("@permission", user.Permission));
                command.Parameters.Add(new MySqlParameter("@birthday", user.Birthday));
                command.Parameters.Add(new MySqlParameter("@id_class", classModel != null ? classModel.IdClass : null));
                int result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionException, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
    }
}
