namespace project_winform.dal
{
    class DatabaseConfig
    {
        private static string host = "localhost";
        private static int port = 3306;
        private static string database = "quanlysinhvien";
        private static string username = "root";
        private static string password = "";

        public static string Host { get => host; }
        public static int Port { get => port; }
        public static string Database { get => database; }
        public static string Username { get => username; }
        public static string Password { get => password; }
    }
}
