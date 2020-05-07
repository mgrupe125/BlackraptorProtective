using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportViewerControlApplication.DataSet1TableAdapters;




namespace ReportViewerControlApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //ReportViewerControlApplication.DataSet1TableAdapters.IncidentTableAdapter adapter = new ReportViewerControlApplication.DataSet1TableAdapters.IncidentTableAdapter();
            //ReportViewerControlApplication.DataSet1.IncidentDataTable table = new ReportViewerControlApplication.DataSet1.IncidentDataTable();
            //ReportParameterCollection reportParameters = new ReportParameterCollection();
            //reportParameters.Add(new ReportParameter("ParameterName", "Value"));
            //this.reportViewer.LocalReport.SetParameters(reportParameters);


           // this.DataSet1.Incident.SelectCommand("Select * from Incident Where ReportNumber = @ReportNumber");
            
            this.DataSet1.Incident.Fill();
            this.reportViewer1.RefreshReport();
            

            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cmdFilter_Click(object sender, EventArgs e)
        {
            this.DataSet1.Incident.Fill();
           
          

        }

       
    }
}
