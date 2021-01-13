using MySql.Data.MySqlClient;
using project_winform.CTO;
using project_winform.src.constants;
using System;
using System.Data;
using System.Windows.Forms;

namespace project_winform.DAL
{
    class RegisterSubjectDAL: DatabaseUtils
    {
        public static DataTable GetRegisterWithIdUserReport(string id_user)
        {
            try
            {
                DataTable subjectsData = new DataTable();
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "SELECT * FROM `registers_user_subject` " +
                    "INNER JOIN `users` ON `users`.`id_user` = `registers_user_subject`.`id_user` " +
                    "INNER JOIN `subjects` ON `subjects`.`id_subjects` = `registers_user_subject`.`id_subject` " +
                    "WHERE `registers_user_subject`.`id_user` = @id_user";
                command.Parameters.Add(new MySqlParameter("@id_user", id_user));

                MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
                sqlData.Fill(subjectsData);

                return subjectsData;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public static bool CreateRegisterSubject(RegisterSubject registerSubject)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "createRegisterSubject";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("@id_user", registerSubject.Id_user));
                command.Parameters.Add(new MySqlParameter("@id_subject", registerSubject.Id_subject));
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

        public static bool DeleteRegisterSubjectWithId(string id_user, string id_subject)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "deleteRegisterSubjectWithId";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("@id_user", id_user));
                command.Parameters.Add(new MySqlParameter("@id_subject", id_subject));
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
