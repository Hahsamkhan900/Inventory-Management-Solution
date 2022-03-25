using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    public partial class SaleReturn : Sample2
    {
        retrival r = new retrival();
        Regex rg = new Regex("^[0-9]+$");
        public SaleReturn()
        {
            InitializeComponent();
        }

        private void saleIDTxtBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void laodBtn_Click(object sender, EventArgs e)
        {
            if (saleIDTxtBox.Text != "" )
            {
                if (rg.Match(saleIDTxtBox.Text).Success)
                {
                    try
                    {
                        r.showSalesViaSaleID(Convert.ToInt64(saleIDTxtBox.Text), dataGridView1, saleIDGV, userNameGV, dateGV, modelNoGV, productNameGV, qtyGV,
                            productPriceGV, perProductTotal, perProDiscountGV, totalAmountGV, totalDiscGV, givenAmountGV, amountReturnGV, saleTypeGV);

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            row.Cells["productPriceGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["productPriceGV"].Value));
                            row.Cells["perProDiscountGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["perProDiscountGV"].Value));
                            row.Cells["perProductTotal"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["perProductTotal"].Value));
                        }

                        salesIDTxtBox.Text = Convert.ToInt64(dataGridView1.Rows[0].Cells["saleIDGV"].Value.ToString()).ToString();
                        userNameTxtBox.Text = dataGridView1.Rows[0].Cells["userNameGV"].Value.ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells["dateGV"].Value);
                        payTypeDD.SelectedItem = dataGridView1.Rows[0].Cells["saleTypeGV"].Value.ToString();
                        totalAmountTxtBox.Text = Math.Ceiling(Convert.ToSingle(dataGridView1.Rows[0].Cells["totalAmountGV"].Value.ToString())).ToString();
                        totalDiscountTxtBox.Text = Math.Ceiling(Convert.ToSingle(dataGridView1.Rows[0].Cells["totalDiscGV"].Value.ToString())).ToString();
                        amtGivenTxtBox.Text = Math.Ceiling(Convert.ToSingle(dataGridView1.Rows[0].Cells["givenAmountGV"].Value.ToString())).ToString();
                        retAmntTxtBox.Text = Math.Ceiling(Convert.ToSingle(dataGridView1.Rows[0].Cells["amountReturnGV"].Value.ToString())).ToString();

                    }
                    catch (Exception ex)
                    {
                        MainClass.showMSG("Sale ID Not Found " +ex.Message, "Error..", "Error");
                    }
                }
                else
                {
                    saleIDTxtBox.Text = "";
                    saleIDTxtBox.Focus();
                    userNameTxtBox.Text = ""; ;
                    dateTimePicker1.Value = DateTime.Now;
                    payTypeDD.SelectedItem = "";
                    totalAmountTxtBox.Text = "";
                    saleIDTxtBox.Text = "";
                    totalDiscountTxtBox.Text = "";
                    amtGivenTxtBox.Text = "";
                    retAmntTxtBox.Text = "";
                    

                }
            }
            else
            {
                salesIDTxtBox.Text = "";
                saleIDTxtBox.Focus();
                userNameTxtBox.Text = ""; ;
                dateTimePicker1.Value = DateTime.Now;
                payTypeDD.SelectedIndex = -1;
                totalAmountTxtBox.Text = "";
                saleIDTxtBox.Text = "";
                totalDiscountTxtBox.Text = "";
                amtGivenTxtBox.Text = "";
                retAmntTxtBox.Text = "";
            }

        }

    }
}
