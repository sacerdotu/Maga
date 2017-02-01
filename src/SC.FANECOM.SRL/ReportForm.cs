using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC.FANECOM.SRL
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = reportViewer1.LocalReport;
            localReport.ReportPath = "RaportFactura.rdlc";
            localReport.Refresh();
            //// Set the processing mode for the ReportViewer to Local
            DataSet dataset = new DataSet("ReceptieProduse");
            string nrNota = "1";

            //// Get the sales order data
            GetReceptieProduse(nrNota, ref dataset);

            //// Create a report data source for the sales order data
            ReportDataSource rdsProdRec = new ReportDataSource();
            rdsProdRec.Name = "ProduseReceptie";
            rdsProdRec.Value = dataset.Tables["Produse_Receptie"];
            //localReport.DataSources.Clear();
            localReport.DataSources.Add(rdsProdRec);
            this.reportViewer1.RefreshReport();

            //// Get the sales order detail data
            //GetSalesOrderDetailData(salesOrderNumber, ref dataset);

            //// Create a report data source for the sales order detail 
            //// data
            //ReportDataSource dsSalesOrderDetail =
            //    new ReportDataSource();
            //dsSalesOrderDetail.Name = "SalesOrderDetail";
            //dsSalesOrderDetail.Value =
            //    dataset.Tables["SalesOrderDetail"];

            //localReport.DataSources.Add(dsSalesOrderDetail);

            //// Create a report parameter for the sales order number 
            //ReportParameter rpSalesOrderNumber = new ReportParameter();
            //rpSalesOrderNumber.Name = "SalesOrderNumber";
            //rpSalesOrderNumber.Values.Add("SO43661");

            //// Set the report parameters for the report
            //localReport.SetParameters(
            //    new ReportParameter[] { rpSalesOrderNumber });

            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); 
        }

        private void GetReceptieProduse(string nrNota,
                                  ref DataSet dsProdRec)
        {
            string prodRec =
                "Select NrNota, Articol, Unitate from Produse_Receptie "+
                "WHERE  (NrNota = @NrNota)";
            //prodRec.Replace("@NrNota", nrNota);
            string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\FaneComDatabase.accdb";

            OleDbConnection MyConn = new OleDbConnection(ConnStr);
            MyConn.Open();
            var StrCmd = prodRec;
            OleDbCommand command = new OleDbCommand(StrCmd, MyConn); ;
            command.Parameters.Add(new OleDbParameter("NrNota", nrNota));
            //OleDbDataReader ObjReader = Cmd.ExecuteReader();

            OleDbDataAdapter prodRecrAdapter = new  OleDbDataAdapter(command);
            prodRecrAdapter.Fill(dsProdRec, "Produse_Receptie");
            //if (ObjReader != null)
            //{
            //}
            //ObjReader.Close();
            MyConn.Close();
        }

    }
}
