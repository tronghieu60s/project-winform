using MySql.Data.MySqlClient;
using project_winform.CTO;
using project_winform.src.constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_winform.DAL
{
    class RegisterSubjectDAL: DatabaseUtils
    {
        public static bool CreateRegisterSubject(RegisterSubject registerSubject)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "INSERT INTO `registers_user_subject`(`id_user`, `id_subject`) VALUES (@id_user, @id_subject)";
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
                command.CommandText = "DELETE FROM `registers_user_subject` WHERE `registers_user_subject`.`id_user` = @id_user AND `registers_user_subject`.`id_subject` = @id_subject";
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
