using System;
using System.Runtime.InteropServices;

namespace project_winform.src.helpers
{
    class Window
    {
        // Move Window Action
        public static int WM_NCLBUTTONDOWN = 0xA1;
        public static int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}
