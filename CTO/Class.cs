using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_winform.CTO
{
    class Class
    {
        private string idClass;
        private string name;
        private Faculty faculty;

        public string IdClass { get => idClass; set => idClass = value; }
        public string Name { get => name; set => name = value; }
        internal Faculty Faculty { get => faculty; set => faculty = value; }


        public Class()
        {
            this.idClass = "";
            this.name = "";
            this.faculty = new Faculty();
        }

        public Class(string idClass, string name, Faculty faculty)
        {
            this.idClass = idClass;
            this.name = name;
            this.faculty = faculty;
        }
    }
}
