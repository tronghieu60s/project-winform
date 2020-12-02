using project_winform.dal;
using System;
using System.Windows.Forms;

namespace project_winform
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* Database Initialization */
            if (DatabaseUtils.DatabaseUtilsConnect())
            {
                Application.EnableVisualStyles();
                // Application.SetCompatibleTextRenderingDefault(false);
                if (Control.userLogin != null)
                    Application.Run(Control.frmMain);
                else Application.Run(Control.frmLogin);
            }
        }
    }
}
