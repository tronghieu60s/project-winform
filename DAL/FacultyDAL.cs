using MySql.Data.MySqlClient;
using project_winform.CTO;
using project_winform.src.constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace project_winform.DAL
{
    class FacultyDAL: DatabaseUtils
    {
        public static DataTable GetFacultiesReport()
        {
            DataTable facultiesData = new DataTable();
            MySqlCommand command = connectDB.CreateCommand();
            command.CommandText = "getFaculties";
            command.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
            sqlData.Fill(facultiesData);
            
            return facultiesData;
        }

        public static List<Faculty> GetFaculties()
        {
            DataSet facultiesData = new DataSet();
            MySqlCommand command = connectDB.CreateCommand();
            command.CommandText = "getFaculties";
            command.CommandType = CommandType.StoredProcedure;

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
                command.CommandText = "createFaculty";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("@id_faculty", faculty.IdFaculty));
                command.Parameters.Add(new MySqlParameter("@faculty_name", faculty.Name));
                int result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public static bool DeleteFacultyWithId(string id_faculty)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "deleteFacultyWithId";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("@id_faculty", id_faculty));
                int result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public static bool UpdateFacultyWithId(Faculty faculty)
        {
            try
            {
                MySqlCommand command = connectDB.CreateCommand();
                command.CommandText = "updateFacultyWithId";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("@v_id_faculty", faculty.IdFaculty));
                command.Parameters.Add(new MySqlParameter("@faculty_name", faculty.Name));
                int result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
    }
}
