using project_winform.src.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project_winform.src.themes
{
    class IconTheme
    {
        static readonly string path = Config.path;

        static public string exit = path + "assets/exit.png";
        static public string exitHover = path + "assets/exit_hover.png";
        static public string resize = path + "assets/resize.png";
        static public string resizeHover = path + "assets/resize_hover.png";
        static public string minimize = path + "assets/minimize.png";
        static public string minimizeHover = path + "assets/minimize_hover.png";
        static public string move = path + "assets/move.png";
        static public string moveHover = path + "assets/move_hover.png";
        static public string student = path + "assets/student.png";
        static public string teacher = path + "assets/teacher.png";
        static public string logout = path + "assets/logout.png";
        static public string reload = path + "assets/reload.png";
        static public string password = path + "assets/password.png";
        static public string logo = path + "assets/logo.png";
    }
}
