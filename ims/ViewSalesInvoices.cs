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
    public partial class ViewSalesInvoices : Sample
    {
        retrival r = new retrival();
        float gross;
        public static int SalesID = 0;
        public ViewSalesInvoices()
        {
            InitializeComponent();
        }

        private void ViewSalesInvoices_Load(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            r.showSaleInovice(dataGridView1,saleIDGV,userGV,totalAmountGV,givenAmountGV,amountReturnGV,totalDiscountGV,dateTimePicker1.Value,userrIDGV);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["totalAmountGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["totalAmountGV"].Value));
                row.Cells["totalDiscountGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["totalDiscountGV"].Value));
                row.Cells["givenAmountGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["givenAmountGV"].Value));
                row.Cells["amountReturnGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["amountReturnGV"].Value));
            }
            try
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    gross += Convert.ToSingle(item.Cells["totalAmountGV"].Value.ToString());
                }
                totalRichTextBox.Text = gross.ToString() + " Rs.";
                gross = 0;
            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            MainClass.ShowWindow(s, this, MDI.ActiveForm);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SalesID = Convert.ToInt32(row.Cells["saleIDGV"].Value.ToString());
                SaleReport sr = new SaleReport();
                sr.Show();
            }
                 
        }
    }
}
