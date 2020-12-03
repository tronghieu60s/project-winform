using project_winform.CTO;
using System.Windows.Forms;

namespace project_winform
{
    class Control
    {
        static public User userLogin = null;
        static public Form frmConfigDatabase = new frmConfigDatabase();
        static public Form frmMain = new frmMain();
        static public Form frmLogin = new frmLogin();
        static public Form frmCourse = new frmCourse();
        static public Form frmFaculty = new frmFaculty();
        static public Form frmClass = new frmClass();

        public static void HandleCloseWindow()
        {
            frmMain.Close();
            frmConfigDatabase.Close();
            frmLogin.Close();
            frmCourse.Close();
            frmFaculty.Close();
            frmClass.Close();
        }

        public static void CloseWindow()
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                HandleCloseWindow();
        }
    }
}
