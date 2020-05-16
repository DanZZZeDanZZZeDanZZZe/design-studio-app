using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignStudio
{
    public partial class Report : Form
    {
        public int ID;
        public DataTable dt;
        public Report(int ID)
        {
            this.ID = ID;
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

            this.dt = DatabaseAPI.getExOrderById(ID);
            string date = dt.Rows[0].ItemArray[1].ToString();
            string deadline = dt.Rows[0].ItemArray[2].ToString();
            string sum = dt.Rows[0].ItemArray[3].ToString();

            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameterID", ID.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameterDate", date));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameterDeadLine", deadline));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameterSum", sum));

            bool font = Convert.ToBoolean(DatabaseAPI.checkAvailability(this.ID, 1));
            bool logo = Convert.ToBoolean(DatabaseAPI.checkAvailability(this.ID, 2));
            bool cup = Convert.ToBoolean(DatabaseAPI.checkAvailability(this.ID, 3));
            bool clothes = Convert.ToBoolean(DatabaseAPI.checkAvailability(this.ID, 4));
            bool cover = Convert.ToBoolean(DatabaseAPI.checkAvailability(this.ID, 5));

            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameterFont", font.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameterLogo", logo.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameterCup", cup.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameterCover", cover.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameterClothes", clothes.ToString()));

            this.reportViewer1.RefreshReport();
             
        }
    }
}
