using System;
using System.Windows.Forms;

namespace project_winform
{
    class Control
    {
        static public Form frmMain = new frmMain();
        static public Form frmLogin = new frmLogin();

        public static void CloseWindow()
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmMain.Close();
                frmLogin.Close();
            }
        }
    }
}
