using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project_winform.src.config
{
    class Config
    {
        static public string fileNameConfig = System.Diagnostics.Debugger.IsAttached ? @"../config.txt" : @"config.txt";
        static public string configUsername = "USERNAME=";
        static public string configPassword = "PASSWORD=";
        static public string path = System.Diagnostics.Debugger.IsAttached ? @"../../" : @"./";
        static public string typeAdmin = "AD";
        static public string typeStudent = "SD";
    }
}
