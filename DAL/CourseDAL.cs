using MySql.Data.MySqlClient;
using project_winform.CTO;
using project_winform.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_winform.DAL
{
    class CourseDAL: DatabaseUtils
    {
        public static List<Course> GetCourses()
        {
            DataSet coursesData = new DataSet();
            MySqlCommand command = connectDB.CreateCommand();
            command.CommandText = "SELECT * FROM `courses` ORDER BY date DESC";

            MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
            sqlData.Fill(coursesData);

            List<Course> courses = new List<Course>();
            foreach (DataRow course in coursesData.Tables[0].Rows)
            {
                string id_course = course["id_course"].ToString();
                string course_name = course["course_name"].ToString();
                courses.Add(new Course(id_course, course_name));
            }
            return courses;
        }
    }
}
