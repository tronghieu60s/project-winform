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
    public partial class GuiCourseReport : Form
    {
        public GuiCourseReport()
        {
            InitializeComponent();
        }

        private void GuiCourseReport_Load(object sender, EventArgs e)
        {
            CoursesReport classesReport = new CoursesReport();
            DataTable dataTable = new DataTable();
            dataTable = CourseDAL.GetCoursesReport();
            classesReport.SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = classesReport;
        }
    }
}
