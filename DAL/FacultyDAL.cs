using MySql.Data.MySqlClient;
using project_winform.CTO;
using project_winform.dal;
using project_winform.src.constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static bool CreateFaculty(Faculty faculty)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "INSERT INTO `faculties`(`id_faculty`, `faculty_name`) VALUES (@id_faculty, @faculty_name)";
                command.Parameters.Add(new MySqlParameter("@id_faculty", faculty.IdFaculty));
                command.Parameters.Add(new MySqlParameter("@faculty_name", faculty.Name));
                int result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionException, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public static bool DeleteFacultyWithId(string id_faculty)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "DELETE FROM `faculties` WHERE `faculties`.`id_faculty` = @id_faculty";
                command.Parameters.Add(new MySqlParameter("@id_faculty", id_faculty));
                int result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionException, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public static bool UpdateFacultyWithId(Faculty faculty)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "UPDATE `faculties` SET `faculty_name`= @faculty_name WHERE `id_faculty` = @id_faculty";
                command.Parameters.Add(new MySqlParameter("@id_faculty", faculty.IdFaculty));
                command.Parameters.Add(new MySqlParameter("@faculty_name", faculty.Name));
                int result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionException, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
    }
}
