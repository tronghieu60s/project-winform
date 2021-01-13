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
    public partial class GuiUserRegister : Form
    {
        public GuiUserRegister()
        {
            InitializeComponent();
        }

        private void GuiUserRegister_Load(object sender, EventArgs e)
        {
            UserRegisterReport classesReport = new UserRegisterReport();
            DataTable dataTable = new DataTable();
            dataTable = RegisterSubjectDAL.GetRegisterWithIdUserReport(Control.userLogin.IdUser);
            classesReport.SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = classesReport;
        }
    }
}
