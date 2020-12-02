using project_winform.src.themes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_winform.src.helpers
{
    class ValidatingInput
    {
        public static bool ValidatingInputText(TextBox textBox, Label label)
        {
            if (textBox.Text.Trim().Length <= 0)
            {
                textBox.Focus();
                label.ForeColor = ColorTheme.getTheme("danger");
                return false;
            }
            else label.ForeColor = Color.Black;
            return true;
        }
    }
}
