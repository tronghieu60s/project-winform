using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_winform.CTO
{
    class RegisterSubject
    {
        private string id_user;
        private string id_subject;

        public string Id_user { get => id_user; set => id_user = value; }
        public string Id_subject { get => id_subject; set => id_subject = value; }
    
        public RegisterSubject(string id_user, string id_subject)
        {
            this.id_user = id_user;
            this.id_subject = id_subject;
        }
    }
}
