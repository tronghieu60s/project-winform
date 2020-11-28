using MySql.Data.MySqlClient;
using project_winform.CTO;
using project_winform.dal;
using System;
using System.Collections.Generic;
using System.Data;

namespace project_winform.DAL
{
    class UserDAL: DatabaseUtils
    {
        public static List<User> getAllDataUsers()
        {
            DataSet usersData = new DataSet();
            MySqlCommand command = connectDB.CreateCommand();
            command.CommandText = "SELECT * FROM `users` INNER JOIN `class` ON `class`.`id_class`= `users`.`id_class` INNER JOIN `faculty` ON `faculty`.`id_faculty` = `class`.`id_faculty`";
            // command.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
            sqlData.Fill(usersData);

            List<User> users = new List<User>();
            foreach (DataRow user in usersData.Tables[0].Rows)
            {
                string id_user = user["id_user"].ToString();
                string password = user["password"].ToString();
                string name = user["name"].ToString();
                string permission = user["permission"].ToString();
                DateTime birthday = new DateTime();
                string course = user["course"].ToString();
                Faculty faculty = new Faculty(user["id_faculty"].ToString(), user["faculty_name"].ToString());
                Class classModal = new Class(user["id_class"].ToString(), user["class_name"].ToString(), faculty);
                users.Add(new User(id_user, password, name, permission, birthday, course, classModal));
            }
            return users;
        }

        public static User getDataUserWithId(string id_user)
        {
            DataSet usersData = new DataSet();
            MySqlCommand command = connectDB.CreateCommand();
            command.CommandText = "SELECT * FROM USERS WHERE id_user = @id_user";
            command.Parameters.Add(new MySqlParameter("@id_user", id_user));

            MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
            sqlData.Fill(usersData);
            if (usersData.Tables[0].Rows.Count > 0)
            {
                DataRow user = usersData.Tables[0].Rows[0];
                Console.WriteLine();
                return new User(user["id_user"].ToString(), user["password"].ToString());
            }
            else return null;
        }
    }
}
