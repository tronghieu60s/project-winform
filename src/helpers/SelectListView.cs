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
    class SelectListView
    {
        public static void SelectListViewForMultipleListView(ListView listView)
        {
            listView.HideSelection = false;
            listView.MultiSelect = false;
            ListViewItem item = listView.FocusedItem as ListViewItem;
            foreach (ListViewItem listItem in listView.Items)
                listItem.BackColor = Color.White;

            if (item != null)
            {
                item.Selected = false;
                if (item.Index != 0)
                    listView.Items[item.Index - 1].BackColor = Color.White;

                if (listView.Items[item.Index].Focused == true)
                {
                    listView.Items[item.Index].BackColor = ColorTheme.getTheme("primary");
                    if (item.Index < listView.Items.Count - 1)
                    {
                        listView.Items[item.Index + 1].BackColor = Color.White;
                    }
                }
                else if (listView.Items[item.Index].Focused == false)
                {
                    listView.Items[item.Index].BackColor = Color.Blue;
                }
            }
        }

    }
}
