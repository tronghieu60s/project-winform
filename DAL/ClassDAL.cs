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
    class ClassDAL: DatabaseUtils
    {
        public static List<Class> getClassesWithIdCourseAndIdFaculty(string id_course, string id_faculty)
        {
            DataSet classesData = new DataSet();
            MySqlCommand command = connectDB.CreateCommand();
            command.CommandText = "SELECT * FROM `classes` LEFT JOIN `courses` ON `courses`.`id_course` = `classes`.`id_course` LEFT JOIN `faculties` ON `faculties`.`id_faculty` = `classes`.`id_faculty` WHERE `courses`.`id_course` = @id_course AND `faculties`.`id_faculty` = @id_faculty";
            command.Parameters.Add(new MySqlParameter("@id_course", id_course));
            command.Parameters.Add(new MySqlParameter("@id_faculty", id_faculty));

            MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
            sqlData.Fill(classesData);

            List<Class> classes = new List<Class>();
            foreach (DataRow classItem in classesData.Tables[0].Rows)
            {
                string id_class = classItem["id_class"].ToString();
                string class_name = classItem["class_name"].ToString();
                Faculty faculty = new Faculty(classItem["id_faculty"].ToString(), classItem["faculty_name"].ToString());
                Course course = new Course(classItem["id_course"].ToString(), classItem["course_name"].ToString());
                classes.Add(new Class(id_class, class_name, faculty, course));
            }
            return classes;
        }
    }
}
