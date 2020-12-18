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
    public partial class GuiFacultyReport : Form
    {
        public GuiFacultyReport()
        {
            InitializeComponent();
        }

        private void GuiFacultyReport_Load(object sender, EventArgs e)
        {
            FacultiesReport classesReport = new FacultiesReport();
            DataTable dataTable = new DataTable();
            dataTable = FacultyDAL.GetFacultiesReport();
            classesReport.SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = classesReport;
        }
    }
}
