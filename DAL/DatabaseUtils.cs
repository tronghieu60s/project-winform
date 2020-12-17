using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using project_winform.src.constants;

namespace project_winform.DAL
{
    // PROCEDURE
    /*
        DELIMITER //
        CREATE PROCEDURE adminupdate()
        BEGIN
        SELECT*
        FROM admin ; 
        END //
        DELIMITER ; 
    */
    class DatabaseUtils
    {
        public static MySqlConnection connectDB = new MySqlConnection();
        private static string strConnect =
            $"Server={DatabaseConfig.Host};" +
            $"Database={DatabaseConfig.Database};" +
            $"Port={DatabaseConfig.Port};" +
            $"User Id={DatabaseConfig.Username};" +
            $"Password={DatabaseConfig.Password}";

        public static bool DatabaseUtilsConnect()
        {
            try
            {
                connectDB.ConnectionString = strConnect;
                connectDB.Open();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.DatabaseConnectFalse, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
