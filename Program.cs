using project_winform.BUS;
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
            Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);

            /* Database Initialization */
            int config = DatabaseConfig.GetLocalStorageConfig();
            if (config == 1)
            {
                if (DatabaseUtils.DatabaseUtilsConnect())
                {
                    if (UserBUS.HandleCheckLoginLocalStorage())
                        Application.Run(Control.frmMainStudent);
                    else Application.Run(Control.frmLogin);
                }
            }
            else if (config == 0)
                Application.Run(Control.frmConfigDatabase);
        }
    }
}
