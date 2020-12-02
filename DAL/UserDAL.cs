using MySql.Data.MySqlClient;
using project_winform.CTO;
using project_winform.dal;
using project_winform.src.constants;
using project_winform.src.helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace project_winform.DAL
{
    class UserDAL : DatabaseUtils
    {

        private static User GetUserFromDataRow(DataRow user)
        {
            string sBirthday = user["birthday"].ToString();
            if (sBirthday.Length > 0) sBirthday = sBirthday.Substring(0, 10);
            else sBirthday = new DateTime(1900, 1, 1).ToString();

            string id_user = user["id_user"].ToString();
            string password = user["password"].ToString();
            string name = user["name"].ToString();
            DateTime birthday = DateTime.Parse(sBirthday);
            Faculty faculty = new Faculty(user["id_faculty"].ToString(), user["faculty_name"].ToString());
            Course course = new Course(user["id_course"].ToString(), user["course_name"].ToString());
            Class classModal = new Class(user["id_class"].ToString(), user["class_name"].ToString(), faculty, course);
            return new User(id_user, password, name, birthday, classModal);
        }

        public static List<User> GetUsers()
        {
            try
            {
                DataSet usersData = new DataSet();
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "SELECT * FROM `users` LEFT JOIN `classes` ON `classes`.`id_class`= `users`.`id_class` LEFT JOIN `courses` ON `courses`.`id_course` = `classes`.`id_course` LEFT JOIN `faculties` ON `faculties`.`id_faculty` = `classes`.`id_faculty` ORDER BY `users`.`date` DESC";
                // command.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
                sqlData.Fill(usersData);

                List<User> users = new List<User>();
                foreach (DataRow user in usersData.Tables[0].Rows)
                    users.Add(GetUserFromDataRow(user));
                return users;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionException, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public static User GetUserWithId(string id)
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

                return GetUserFromDataRow(user);
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionException, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public static bool CreateUser(User user)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                Class classModel = user.ClassModel;
                command.CommandText = "INSERT INTO `users`(`id_user`, `password`, `name`, `birthday`, `id_class`) VALUES (@id_user, @password, @name, @birthday, @id_class)";
                command.Parameters.Add(new MySqlParameter("@id_user", user.IdUser));
                command.Parameters.Add(new MySqlParameter("@password", Password.HashPassword(user.Password)));
                command.Parameters.Add(new MySqlParameter("@name", user.Name));
                command.Parameters.Add(new MySqlParameter("@birthday", user.Birthday));
                command.Parameters.Add(new MySqlParameter("@id_class", classModel?.IdClass));
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

        public static bool DeleteUserWithId(string id_user)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "DELETE FROM `users` WHERE `users`.`id_user` = @id_user";
                command.Parameters.Add(new MySqlParameter("@id_user", id_user));
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

        public static bool UpdateUserFromAdminWithId(User user)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                Class classModel = user.ClassModel;
                command.CommandText = "UPDATE `users` SET `name`= @name,`birthday`= @birthday, `id_class`= @id_class WHERE `id_user`= @id_user";
                command.Parameters.Add(new MySqlParameter("@id_user", user.IdUser));
                command.Parameters.Add(new MySqlParameter("@name", user.Name));
                command.Parameters.Add(new MySqlParameter("@birthday", user.Birthday));
                command.Parameters.Add(new MySqlParameter("@id_class", classModel?.IdClass));
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

        public static bool UpdateUserWithId(User user)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                Class classModel = user.ClassModel;
                command.CommandText = "UPDATE `users` SET `password`= @password, `name`= @name,`birthday`= @birthday, `id_class`= @id_class WHERE `id_user`= @id_user";
                command.Parameters.Add(new MySqlParameter("@id_user", user.IdUser));
                command.Parameters.Add(new MySqlParameter("@password", user.Password));
                command.Parameters.Add(new MySqlParameter("@name", user.Name));
                command.Parameters.Add(new MySqlParameter("@birthday", user.Birthday));
                command.Parameters.Add(new MySqlParameter("@id_class", classModel.IdClass.Length > 0 ? classModel?.IdClass : null));
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
