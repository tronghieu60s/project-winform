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
            frmMain.Close();
            frmLogin.Close();
        }
    }
}
