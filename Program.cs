using project_winform.BUS;
using project_winform.dal;
using project_winform.src.config;
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
                    {
                        if (Control.userLogin.IdUser.Substring(0, 2) == Config.typeAdmin)
                            Application.Run(Control.frmMain);
                        else if (Control.userLogin.IdUser.Substring(0, 2) == Config.typeStudent)
                            Application.Run(Control.frmMainStudent);
                    }
                    else Application.Run(Control.frmLogin);
                }
            }
            else if (config == 0)
                Application.Run(Control.frmConfigDatabase);
        }
    }
}
