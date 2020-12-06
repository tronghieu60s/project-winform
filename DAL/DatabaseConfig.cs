using MySql.Data.MySqlClient;
using project_winform.src.config;
using project_winform.src.constants;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace project_winform.DAL
{
    class DatabaseConfig
    {
        public static MySqlConnection connectDB = new MySqlConnection();

        private static string host = System.Diagnostics.Debugger.IsAttached ? "localhost" : "";
        private static int port = System.Diagnostics.Debugger.IsAttached ? 3306 : 0;
        private static string database = System.Diagnostics.Debugger.IsAttached ? "quanlysinhvien" : "";
        private static string username = System.Diagnostics.Debugger.IsAttached ? "root" : "";
        private static string password = System.Diagnostics.Debugger.IsAttached ? "" : "";

        public static string Host { get => host; }
        public static int Port { get => port; }
        public static string Database { get => database; }
        public static string Username { get => username; }
        public static string Password { get => password; }

        public static bool CheckConnectDatabase(string server, string database, string port, string username, string password)
        {
            string strConnect =
               $"Server={server};" +
               $"Database={database};" +
               $"Port={port};" +
               $"User Id={username};" +
               $"Password={password}";
            bool connect = false;
            try
            {
                connectDB.ConnectionString = strConnect;
                connectDB.Open();
                connect = true;
            }
            catch (Exception)
            {
                connect = false;
            }
            finally
            {
                if (connectDB.State == ConnectionState.Open)
                    connectDB.Close();
            }

            return connect;
        }

        public static int GetLocalStorageConfig()
        {
            string line = "";
            bool fileValid = File.Exists(Config.fileDatabaseConfig);
            if (!fileValid) return -1;

            string server = String.Empty;
            string database = String.Empty;
            string port = String.Empty;
            string username = String.Empty;
            string password = String.Empty;
            using (StreamReader sr = new StreamReader(Config.fileDatabaseConfig))
            {
                if ((line = sr.ReadLine()) == null) return -1;
                server = line.StartsWith(Config.configServer) ?
                    line.Substring(Config.configServer.Length, line.Length - Config.configServer.Length) : String.Empty;

                if ((line = sr.ReadLine()) == null) return -1;
                database = line.StartsWith(Config.configDatabaseName) ?
                    line.Substring(Config.configDatabaseName.Length, line.Length - Config.configDatabaseName.Length) : String.Empty;

                if ((line = sr.ReadLine()) == null) return -1;
                port = line.StartsWith(Config.configPort) ?
                    line.Substring(Config.configPort.Length, line.Length - Config.configPort.Length) : String.Empty;

                if ((line = sr.ReadLine()) == null) return -1;
                username = line.StartsWith(Config.configUsername) ?
                    line.Substring(Config.configUsername.Length, line.Length - Config.configUsername.Length) : String.Empty;

                if ((line = sr.ReadLine()) == null) return -1;
                password = line.StartsWith(Config.configPassword) ?
                    line.Substring(Config.configPassword.Length, line.Length - Config.configPassword.Length) : String.Empty;
            }

            bool check = CheckConnectDatabase(server, database, port, username, password);
            if (check)
            {
                DatabaseConfig.host = server;
                DatabaseConfig.database = database;
                int.TryParse(port, out DatabaseConfig.port);
                DatabaseConfig.username = username;
                DatabaseConfig.password = password;
                return 1;
            }
            else
            {
                DialogResult result = MessageBox.Show(MessageBoxText.QuestionConfigDatabase, MessageBoxText.CaptionInformation, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                    return 0;
            }
            return -1;
        }

        public static void SaveLocalStorageConfig(string server, string database, string port, string username, string password)
        {
            using (StreamWriter sw = new StreamWriter(Config.fileDatabaseConfig))
            {
                sw.WriteLine(Config.configServer + server);
                sw.WriteLine(Config.configDatabaseName + database);
                sw.WriteLine(Config.configPort + port);
                sw.WriteLine(Config.configUsername + username);
                sw.WriteLine(Config.configPassword + password);
            }
        }
    }
}
