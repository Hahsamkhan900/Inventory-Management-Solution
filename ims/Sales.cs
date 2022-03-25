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
    public partial class Sales : Sample2
    {
        retrival r = new retrival();
        int proID,rowNumber,quan = 0,q,qCount,stockQuant,nCount;
        float total, gross =0,disc,tot,discount,gt, changetogiven;
        insertion i = new insertion();

        
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        bool prodCheck;
        public Sales()
        {
            InitializeComponent();
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            ViewSalesInvoices vsi = new ViewSalesInvoices();
            MainClass.ShowWindow(vsi,this,MDI.ActiveForm);
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        string[] prodArr = new string[6];
        private void modelNoTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            //    if (modelNoTxtBox.Text != "")
            //    {
            //        if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            //        {
            //            prodArr = r.showProductsWRTModelNo(modelNoTxtBox.Text);
            //            if (dataGridView1.Rows.Count == 0)
            //            {
            //                dataGridView1.Rows.Add(Convert.ToInt32(prodArr[0]), prodArr[1], 1, Convert.ToSingle(prodArr[3]), Convert.ToSingle(prodArr[4]), Convert.ToSingle(prodArr[5]));
            //            }
            //            else
            //            {
            //                foreach (DataGridViewRow row in dataGridView1.Rows)
            //                {
            //                    if (row.Cells["prodIDGV"].Value.ToString() == prodArr[0])
            //                    {
            //                        prodCheck = true;
            //                        rowNumber = row.Index;
            //                    }
            //                    else
            //                    {
            //                        prodCheck = false;
            //                    }
            //                }
            //                if (prodCheck)
            //                {
            //                    disc = 0;
            //                    total = Convert.ToInt32(dataGridView1.Rows[rowNumber].Cells["proQtyGV"].Value) + 1;
            //                    dataGridView1.Rows[rowNumber].Cells["proQtyGV"].Value = total;
            //                    disc = Convert.ToSingle(dataGridView1.Rows[rowNumber].Cells["discountGV"].Value.ToString())+ Convert.ToSingle(prodArr[4]);
            //                    dataGridView1.Rows[rowNumber].Cells["discountGV"].Value = disc;
            //                    tot = (Convert.ToSingle(dataGridView1.Rows[rowNumber].Cells["perUnitPriceGV"].Value.ToString()))* Convert.ToInt32(dataGridView1.Rows[rowNumber].Cells["proQtyGV"].Value)
            //                        - Convert.ToSingle(dataGridView1.Rows[rowNumber].Cells["discountGV"].Value.ToString());
            //                    dataGridView1.Rows[rowNumber].Cells["totalGV"].Value = tot;
            //                }
            //                else
            //                {
            //                    dataGridView1.Rows.Add(Convert.ToInt32(prodArr[0]), prodArr[1], 1, Convert.ToSingle(prodArr[3]), Convert.ToSingle(prodArr[4]), Convert.ToSingle(prodArr[5]));
            //                }
            //            }
            //            gross = 0;
            //            discount = 0;
            //            foreach (DataGridViewRow row in dataGridView1.Rows)
            //            {
            //                gross += Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
            //                discount += Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
            //            }
            //            GrossTotalLabel.Text = Math.Round(gross,0).ToString();
            //            modelNoTxtBox.Focus();
            //            modelNoTxtBox.SelectAll();

            //        }
            //    }
        }

        private void modelNoTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (modelNoTxtBox.Text != "")
            {
                givenAmtTxtBox.Text = "";
                grossTotalTxtBox.Text = "";
                discountTxtBox.Text = "";
                chngtoGiveTxtBox.Text = "";
                qCount = 0; stockQuant =0;nCount = 0;
                prodArr = r.showProductsWRTModelNo(modelNoTxtBox.Text);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (prodArr[0]== row.Cells["prodIDGV"].Value.ToString() )
                    {
                        qCount= qCount + Convert.ToInt32(row.Cells["proQtyGV"].Value.ToString());
                    }
                }
                stockQuant = Convert.ToInt32(r.getProductQty(Convert.ToInt32(prodArr[0])));
                nCount = stockQuant - qCount;
                if (nCount <= 0)
                {

                }
                else
                {
                    if (dataGridView1.RowCount == 0)
                    {
                        dataGridView1.Rows.Add(Convert.ToInt32(prodArr[0]), prodArr[1], 1, Convert.ToSingle(prodArr[3])+Convert.ToSingle(prodArr[4]), Convert.ToSingle(prodArr[4]), Convert.ToSingle(prodArr[3]));
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["prodIDGV"].Value.ToString() == prodArr[0])
                            {
                                prodCheck = true;
                                break;
                            }
                            else
                            {
                                prodCheck = false;
                            }
                        }
                        if (prodCheck == true)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["prodIDGV"].Value.ToString() == prodArr[0])
                                {
                                    disc = 0;
                                    row.Cells["proQtyGV"].Value = Convert.ToInt32(row.Cells["proQtyGV"].Value.ToString()) + 1;
                                    tot = Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()) * Convert.ToSingle(row.Cells["proQtyGV"].Value.ToString()) - Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                                    row.Cells["totalGV"].Value = tot;
                                }
                            }
                        }
                        else
                        {
                            dataGridView1.Rows.Add(Convert.ToInt32(prodArr[0]), prodArr[1], 1, Convert.ToSingle(prodArr[3]), Convert.ToSingle(prodArr[4]), Convert.ToSingle(prodArr[3]));
                        }
                    }

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        gross += Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                    }
                    GrossTotalLabel.Text = Math.Ceiling(gross).ToString();
                    gross = 0;
                    modelNoTxtBox.Focus();
                    modelNoTxtBox.Text = "";
                }
                
            }
        }

        private void givenAmtTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (givenAmtTxtBox.Text != "")
            {
                if (!rg.Match(givenAmtTxtBox.Text).Success)
                {
                    givenAmtTxtBox.Text = "";
                    givenAmtTxtBox.Focus();
                }
                else
                {
                    try
                    {
                        if (Convert.ToSingle(grossTotalTxtBox.Text) <= Convert.ToSingle(givenAmtTxtBox.Text) || givenAmtTxtBox.Text == "")
                        {
                            changetogiven = Convert.ToSingle(givenAmtTxtBox.Text) - Convert.ToSingle(grossTotalTxtBox.Text);
                            chngtoGiveTxtBox.Text = Math.Ceiling(changetogiven).ToString();
                            chngtoGiveTxtBox.Focus();
                        }
                        else
                        {
                            givenAmtTxtBox.Text = "";
                            chngtoGiveTxtBox.Text = ""; 
                            givenAmtTxtBox.Focus();
                            MainClass.showMSG("You Give less amount as compare to Gross Total", "Error...", "Error");
                        }
                    }
                    catch (Exception)
                    {
                    }

                }
            }
            else
            {
                givenAmtTxtBox.Text = "";
            }
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                disc = 0; gross = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    disc = Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) * Convert.ToSingle(row.Cells["proQtyGV"].Value.ToString());
                    gross += Convert.ToSingle(row.Cells["totalGV"].Value.ToString())-disc;
                }

                grossTotalTxtBox.Text = Math.Ceiling(gross).ToString();
                discountTxtBox.Text = Math.Ceiling(disc).ToString();

            }
            else if (dataGridView1.Rows.Count > 1 )
            {
                disc = 0; gross = 0;
               foreach (DataGridViewRow row in dataGridView1.Rows)
               {
                    disc += Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                    gross += Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
               }
                grossTotalTxtBox.Text = Math.Ceiling(gross).ToString();
                discountTxtBox.Text = Math.Ceiling(disc).ToString();

                payTypeDD.SelectedIndex = 0;

            }
            givenAmtTxtBox.Focus();
        }

        private void modelNoTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    givenAmtTxtBox.Text = "";
                    grossTotalTxtBox.Text = "";
                    discountTxtBox.Text = "";
                    chngtoGiveTxtBox.Text = "";
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    q = Convert.ToInt32(row.Cells["proQtyGV"].Value.ToString());
                    if (q == 1)
                    {
                        gt = Convert.ToSingle(GrossTotalLabel.Text);
                        gt = Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                        GrossTotalLabel.Text = gt.ToString();
                        dataGridView1.Rows.Remove(row);
                    }
                    else if (q > 1)
                    {
                        q--;
                        row.Cells["proQtyGV"].Value = q;
                        disc = Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) - Convert.ToSingle(prodArr[4]);
                        row.Cells["discountGV"].Value = disc;
                        tot = Convert.ToSingle(row.Cells["proQtyGV"].Value.ToString()) * Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()) - disc;
                        row.Cells["totalGV"].Value = tot;
                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            gross += Convert.ToSingle(item.Cells["totalGV"].Value.ToString());
                        }
                        GrossTotalLabel.Text = gross.ToString();
                        gross = 0;


                    }
                }
            }
            givenAmtTxtBox.Focus();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (givenAmtTxtBox.Text != "" && discountTxtBox.Text != "" && grossTotalTxtBox.Text != "" && payTypeDD.SelectedIndex != -1 && chngtoGiveTxtBox.Text != "")
            {
                DialogResult dr = MessageBox.Show(" Total Amount : " + grossTotalTxtBox.Text + "\n Total Discount : " + discountTxtBox.Text + "\n Total Given Amount : " + givenAmtTxtBox.Text + "\n Total Return : " + chngtoGiveTxtBox.Text + "\n\n Are you sure, submit current Sales ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    i.insertSales(dataGridView1, "prodIDGV","perUnitPriceGV","discountGV" ,"proQtyGV",retrival.user_Id,DateTime.Now, Convert.ToSingle(grossTotalTxtBox.Text), Convert.ToSingle(discountTxtBox.Text), Convert.ToSingle(givenAmtTxtBox.Text), Convert.ToSingle(chngtoGiveTxtBox.Text), payTypeDD.SelectedItem.ToString());
                    MainClass.enable_reset(leftGroupBox);
                    dataGridView1.Rows.Clear();
                    GrossTotalLabel.Text = "0.00";
                    SaleReport sr = new SaleReport();
                    sr.Show();
                }
            }
        }

    }
}
