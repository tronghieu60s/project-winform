using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_winform.CTO
{
    class Course
    {
        private string idCourse;
        private string name;

        public string IdCourse { get => idCourse; set => idCourse = value; }
        public string Name { get => name; set => name = value; }

        public Course()
        {
            this.idCourse = "";
            this.name = "";
        }

        public Course(string idCourse, string name)
        {
            this.idCourse = idCourse;
            this.name = name;
        }
    }
}
