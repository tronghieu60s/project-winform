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
    class FacultyDAL: DatabaseUtils
    {
        public static List<Faculty> GetFaculties()
        {
            DataSet facultiesData = new DataSet();
            MySqlCommand command = connectDB.CreateCommand();
            command.CommandText = "SELECT * FROM `faculties` ORDER BY date DESC";

            MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
            sqlData.Fill(facultiesData);

            List<Faculty> faculties = new List<Faculty>();
            foreach (DataRow faculty in facultiesData.Tables[0].Rows)
            {
                string id_faculty = faculty["id_faculty"].ToString();
                string faculty_name = faculty["faculty_name"].ToString();
                faculties.Add(new Faculty(id_faculty, faculty_name));
            }
            return faculties;
        }
    }
}
