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
        private string permission;
        private DateTime birthday;
        private Class classModel;

        public string IdUser { get => idUser; set => idUser = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Permission { get => permission; set => permission = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        internal Class ClassModel { get => classModel; set => classModel = value; }

        public User(string idUser, string password, string name, string permission, DateTime birthday, Class classModel)
        {
            this.idUser = idUser;
            this.password = password;
            this.name = name;
            this.permission = permission;
            this.birthday = birthday;
            this.classModel = classModel;
        }
    }
}
