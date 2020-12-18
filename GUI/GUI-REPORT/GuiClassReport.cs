using project_winform.DAL;
using project_winform.REPORT;
using System;
using System.Data;
using System.Windows.Forms;

namespace project_winform.GUI.GUI_REPORT
{
    public partial class GuiClassReport: Form
    {
        public GuiClassReport()
        {
            InitializeComponent();
        }

        private void GuiClassReport_Load(object sender, EventArgs e)
        {
            ClassesReport classesReport = new ClassesReport();
            DataTable dataTable = new DataTable();
            dataTable = ClassDAL.GetClassesReport();
            classesReport.SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = classesReport;
        }
    }
}
