using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using project_winform.src.themes;

namespace project_winform.src.helpers
{
    class FormSetup
    {
        // Select All Object
        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public static void FormLoad(Control control)
        {
            // Format Default Button
            foreach (var btn in GetAll(control, typeof(Button)))
            {
                (btn as Button).FlatStyle = FlatStyle.Flat;
                (btn as Button).Cursor = Cursors.Hand;
                (btn as Button).ForeColor = ColorTheme.getTheme("secondary");
            }

            foreach (var btn in GetAll(control, typeof(PictureBox)))
            {
                (btn as PictureBox).SizeMode = PictureBoxSizeMode.StretchImage;
                (btn as PictureBox).Cursor = Cursors.Hand;
            }
        }
    }
}
