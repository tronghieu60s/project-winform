using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_winform.CTO
{
    class Subject
    {
        private string idSubject;
        private string name;
        private int credit;
        private string information;
        private User lecturer;
        private DateTime startDay;
        private DateTime endDay;
        private Faculty faculty;
        private Course course;

        public string IdSubject { get => idSubject; set => idSubject = value; }
        public string Name { get => name; set => name = value; }
        public int Credit { get => credit; set => credit = value; }
        public string Information { get => information; set => information = value; }
        public DateTime StartDay { get => startDay; set => startDay = value; }
        public DateTime EndDay { get => endDay; set => endDay = value; }
        internal Faculty Faculty { get => faculty; set => faculty = value; }
        internal Course Course { get => course; set => course = value; }
        internal User Lecturer { get => lecturer; set => lecturer = value; }

        public Subject(string idSubject, string name, int credit, string information, User lecturer, DateTime startDay, DateTime endDay, Faculty faculty, Course course)
        {
            this.idSubject = idSubject;
            this.name = name;
            this.credit = credit;
            this.information = information;
            this.lecturer = lecturer;
            this.startDay = startDay;
            this.endDay = endDay;
            this.faculty = faculty;
            this.course = course;
        }
    }
}
