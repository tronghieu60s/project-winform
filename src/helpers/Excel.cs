using project_winform.src.constants;
using System;
using System.IO;
using System.Windows.Forms;

namespace project_winform.src.helpers
{
    class Excel
    {
        public static ListView ImportDataExcelToListView()
        {
            ListView lvwMain = new ListView();
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.OpenFile(), System.Text.Encoding.Default))
                    {
                        reader.ReadLine();
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split('\t');

                            ListViewItem item = new ListViewItem(values);
                            lvwMain.Items.Add(item);
                        }
                    }
                }
                return lvwMain;
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public static void ExportDataListViewToExcel(ListView lvwMain)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                // File Name
                DateTime timeNow = DateTime.Now;
                savefile.FileName = "Data_" + timeNow.ToString("dd_MM_yyyy_hhmmss") + ".csv";
                savefile.Filter = "CSV Files (*.csv)|*.csv";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(savefile.FileName, false, System.Text.Encoding.Unicode))
                    {
                        sw.AutoFlush = true;
                        for (int col = 0; col < lvwMain.Columns.Count; col++)
                            sw.Write(lvwMain.Columns[col].Text.ToString() + "\t");

                        sw.Write("\n");
                        string st = "";
                        for (int row = 0; row < lvwMain.Items.Count; row++)
                        {
                            st = "";
                            for (int col = 0; col < lvwMain.Columns.Count; col++)
                                st = st + lvwMain.Items[row].SubItems[col].Text.ToString() + "\t";
                            sw.WriteLine(st);
                        }
                        sw.Close();
                        FileInfo fil = new FileInfo(savefile.FileName);
                        if (fil.Exists == true)
                            MessageBox.Show(MessageBoxText.ExportSuccess + lvwMain.Items.Count, MessageBoxText.CaptionSuccess, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(MessageBoxText.Exception, MessageBoxText.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
