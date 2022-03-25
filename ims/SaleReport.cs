using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    public partial class SaleReport : Form
    {
        retrival r = new retrival();
        ReportDocument rd = new ReportDocument();
        public SaleReport()
        {
            InitializeComponent();
        }

        private void SaleReport_Load(object sender, EventArgs e)
        {
            if (ViewSalesInvoices.SalesID == 0)
            {
                r.showReport(rd, crystalReportViewer1, "st_getSaleReceipt", "@userID", retrival.user_Id);
            }
            else
            {
                r.showReport(rd, crystalReportViewer1, "st_getSaleReceiptWRTSaleID", "@saleID", ViewSalesInvoices.SalesID);
                ViewSalesInvoices.SalesID = 0;
            }
           

        }

        private void SaleReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd != null)
            {
                rd.Close();
            }
        }
    }
}
