using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_winform.CTO
{
    class Lecturer
    {
        private string idLecturer;
        private string password;
        private string name;
        private Faculty faculty;
        private Course course;

        public string IdLecturer { get => idLecturer; set => idLecturer = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        internal Faculty Faculty { get => faculty; set => faculty = value; }
        internal Course Course { get => course; set => course = value; }
    }
}
