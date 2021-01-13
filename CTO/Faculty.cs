using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_winform.CTO
{
    class Faculty
    {
        private string idFaculty;
        private string name;

        public string IdFaculty { get => idFaculty; set => idFaculty = value; }
        public string Name { get => name; set => name = value; }

        public Faculty()
        {
            this.idFaculty = "";
            this.name = "";
        }

        public Faculty(string idFaculty, string name)
        {
            this.idFaculty = idFaculty;
            this.name = name;
        }
    }
}
