using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project_winform.dal
{
    public class DatabaseUtils
    {
        private readonly MySqlConnection connectDB = new MySqlConnection();
        private readonly string strConnect = 
            $"Server={DatabaseConfig.Host};"+
            $"Database={DatabaseConfig.Database};"+
            $"Port={DatabaseConfig.Port};"+
            $"User Id={DatabaseConfig.Username};"+
            $"Password={DatabaseConfig.Password}";

        public DatabaseUtils()
        {
            try
            {
                connectDB.ConnectionString = strConnect;
                connectDB.Open();
                MessageBox.Show("Connect Success!");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
