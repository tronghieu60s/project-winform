using MySql.Data.MySqlClient;
using project_winform.CTO;
using project_winform.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

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
            string course = user["course"].ToString();
            Faculty faculty = new Faculty(user["id_faculty"].ToString(), user["faculty_name"].ToString());
            Class classModal = new Class(user["id_class"].ToString(), user["class_name"].ToString(), faculty);
            return new User(id_user, password, name, permission, birthday, course, classModal);
        }

        public static List<User> getAllUsers()
        {
            DataSet usersData = new DataSet();
            MySqlCommand command = connectDB.CreateCommand();
            command.CommandText = "SELECT * FROM `users` LEFT JOIN `class` ON `class`.`id_class`= `users`.`id_class` LEFT JOIN `faculty` ON `faculty`.`id_faculty` = `class`.`id_faculty`";
            // command.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
            sqlData.Fill(usersData);

            List<User> users = new List<User>();
            foreach (DataRow user in usersData.Tables[0].Rows)
                users.Add(getUserFromDataRow(user));
            return users;
        }

        public static User getUserWithId(string id)
        {
            DataSet usersData = new DataSet();
            MySqlCommand command = connectDB.CreateCommand();
            command.CommandText = "SELECT * FROM `users` LEFT JOIN `class` ON `class`.`id_class`= `users`.`id_class` LEFT JOIN `faculty` ON `faculty`.`id_faculty` = `class`.`id_faculty` WHERE `users`.`id_user` = @id_user";
            command.Parameters.Add(new MySqlParameter("@id_user", id));

            MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
            sqlData.Fill(usersData);

            if (usersData.Tables[0].Rows.Count <= 0) return null;
            DataRow user = usersData.Tables[0].Rows[0];

            return getUserFromDataRow(user);
        }
    }
}
