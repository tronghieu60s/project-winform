using System.Windows.Forms;

namespace project_winform.src.helpers
{
    class Sort
    {
        public static void SetSortArrow(ColumnHeader head, SortOrder order)
        {
            const string ascArrow = " ▲";
            const string descArrow = " ▼";

            // remove arrow
            if (head.Text.EndsWith(ascArrow) || head.Text.EndsWith(descArrow))
                head.Text = head.Text.Substring(0, head.Text.Length - 2);

            // add arrow
            switch (order)
            {
                case SortOrder.Ascending: head.Text += ascArrow; break;
                case SortOrder.Descending: head.Text += descArrow; break;
            }
        }

        public static void SortColumnsListView(ColumnClickEventArgs e, ListView lvwMain)
        {
            ItemComparer sorter = lvwMain.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                SetSortArrow(lvwMain.Columns[e.Column], SortOrder.Ascending);
                lvwMain.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (e.Column == sorter.Column)
            {
                // Reverse the current sort direction
                if (sorter.Order == SortOrder.Ascending)
                {
                    sorter.Order = SortOrder.Descending;
                    SetSortArrow(lvwMain.Columns[e.Column], SortOrder.Descending);
                }
                else
                {
                    sorter.Order = SortOrder.Ascending;
                    SetSortArrow(lvwMain.Columns[e.Column], SortOrder.Ascending);
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
                SetSortArrow(lvwMain.Columns[e.Column], SortOrder.Ascending);
            }
            lvwMain.Sort();
        }
    }
}
