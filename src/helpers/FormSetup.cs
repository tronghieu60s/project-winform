using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using project_winform.src.themes;
using System.Drawing;

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
            foreach (var item in GetAll(control, typeof(Button)))
            {
                (item as Button).FlatStyle = FlatStyle.Flat;
                (item as Button).Cursor = Cursors.Hand;
                (item as Button).ForeColor = ColorTheme.getTheme("secondary");
            }

            foreach (var item in GetAll(control, typeof(PictureBox)))
            {
                (item as PictureBox).SizeMode = PictureBoxSizeMode.StretchImage;
                (item as PictureBox).Cursor = Cursors.Hand;
            }

            foreach (var item in GetAll(control, typeof(Panel)))
            {
                (item as Panel).BackgroundImageLayout = ImageLayout.Stretch;
                (item as Panel).Cursor = Cursors.Hand;
            }
        }
    }
}
