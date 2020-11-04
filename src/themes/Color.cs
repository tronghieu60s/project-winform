using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace project_winform.src.themes
{
    class ColorTheme
    {
        static private byte[] colorTextBold = { 50, 50, 93 };
        static private byte[] colorTextNormal = { 50, 50, 93 };
        static private byte[] colorDefault = { 51, 49, 70 };
        static private byte[] colorPrimary = { 94, 114, 228 };
        static private byte[] colorSecondary = { 244, 245, 247 };
        static private byte[] colorInfo = { 17, 205, 239 };
        static private byte[] colorSuccess = { 45, 206, 137 };
        static private byte[] colorDanger = { 245, 54, 92 };
        static private byte[] colorWarning = { 251, 99, 64 };

        static public Color getTheme(string name = "default")
        {
            byte[] theme = colorDefault;
            if (name == "text-bold")
                theme = colorTextBold;
            if (name == "text-normal")
                theme = colorTextNormal;
            if (name == "primary")
                theme = colorPrimary;
            if (name == "secondary")
                theme = colorSecondary;
            if (name == "info")
                theme = colorInfo;
            if (name == "success")
                theme = colorSuccess;
            if (name == "danger")
                theme = colorDanger;
            if (name == "warning")
                theme = colorWarning;
            return Color.FromArgb(theme[0], theme[1], theme[2]);
        }
    }
}
