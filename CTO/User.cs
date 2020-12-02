using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_winform.CTO
{
    class User
    {
        private string idUser;
        private string password;
        private string name;
        private DateTime birthday;
        private Class classModel;

        public string IdUser { get => idUser; set => idUser = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        internal Class ClassModel { get => classModel; set => classModel = value; }

        public User(string idUser, string password)
        {
            this.idUser = idUser;
            this.password = password;
            this.name = "";
            this.birthday = new DateTime();
            this.classModel = new Class();
        }

        public User(string idUser, string password, string name, DateTime birthday, Class classModel)
        {
            this.idUser = idUser;
            this.password = password;
            this.name = name;
            this.birthday = birthday;
            this.classModel = classModel;
        }
    }
}
