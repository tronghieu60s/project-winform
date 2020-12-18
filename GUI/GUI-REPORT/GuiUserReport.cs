using project_winform.DAL;
using project_winform.REPORT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_winform.GUI.GUI_REPORT
{
    public partial class GuiUserReport : Form
    {
        public GuiUserReport()
        {
            InitializeComponent();
        }

        private void GuiUserReport_Load(object sender, EventArgs e)
        {
            UsersReport classesReport = new UsersReport();
            DataTable dataTable = new DataTable();
            dataTable = UserDAL.GetUsersReport();
            classesReport.SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = classesReport;
        }
    }
}
