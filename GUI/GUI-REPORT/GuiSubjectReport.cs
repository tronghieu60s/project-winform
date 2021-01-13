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
    public partial class GuiSubjectReport : Form
    {
        public GuiSubjectReport()
        {
            InitializeComponent();
        }

        private void GuiSubjectReport_Load(object sender, EventArgs e)
        {
            SubjectsReport classesReport = new SubjectsReport();
            DataTable dataTable = new DataTable();
            dataTable = SubjectDAL.GetSubjectsReport();
            classesReport.SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = classesReport;
        }
    }
}
