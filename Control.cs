using project_winform.CTO;
using System.Windows.Forms;

namespace project_winform
{
    class Control
    {
        static public User userLogin = null;
        static public Form frmCourse = new frmCourse();
        static public Form frmFaculty = new frmFaculty();
        static public Form frmClass = new frmClass();
        static public Form frmMain = new frmMain();
        static public Form frmLogin = new frmLogin();

        public static void CloseWindow()
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmMain.Close();
                frmLogin.Close();
                frmCourse.Close();
                frmFaculty.Close();
                frmClass.Close();
            }
        }
    }
}
