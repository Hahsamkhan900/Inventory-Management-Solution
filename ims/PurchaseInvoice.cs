using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ims
{
    public partial class PurchaseInvoice : Sample2
    {
        int edit = 0; //This 0 an indication to SaveOperation & 1 is an indication of EditOperation
        int proID,q;
        int supID;
        short stat;
        float gt, tot;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        retrival r = new retrival(); //Making a global obj of Retrival Class
        insertion i = new insertion();
        updation u = new updation();
        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            r.showList("st_getCompanyList", compDD, "Company_Name", "compID");
           

        }

        public override void addBtn_Click(object sender, EventArgs e)
        {

            MainClass.enable_reset(leftPanel);
            edit = 0;
            r.showList("st_getCompanyList", compDD, "Company_Name", "compID");
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
           
        }
        int co;
        public override void saveBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Int64 purchaseInvoiceID;
               
                using (TransactionScope sc = new TransactionScope())
                {
                    try
                    {
                        purchaseInvoiceID = i.insertPurchaseInvoice(DateTime.Today, Convert.ToInt32(supplierDD.SelectedValue), Convert.ToInt32(compDD.SelectedValue));
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            co += i.insertPurchaseInvoiceDetails(purchaseInvoiceID, Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["proQtyGV"].Value.ToString()), Convert.ToSingle(row.Cells["totalGV"].Value.ToString()));
                            if (r.checkExistingPriceExistance(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString())))
                            {
                                u.updateProductPrice(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["perUnitPriceGV"].Value.ToString()));
                            }
                            else
                            {
                                i.insertProductPrice(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["perUnitPriceGV"].Value.ToString()));
                            }
                            object ob = r.getProductQty(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()));
                            if (ob != null)
                            {
                                q = Convert.ToInt32(ob);
                                q += Convert.ToInt32(row.Cells["proQtyGV"].Value.ToString());
                                u.updatetStock(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), q);
                            }
                            else
                            {
                                i.insertStock(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["proQtyGV"].Value.ToString()));
                            }
                        }
                        if (co > 0)
                        {
                            MainClass.showMSG("Purchase Invoice Create Succesfully...", "Success", "Success");
                        }
                        else
                        {
                            MainClass.showMSG("Unable to Create Purchase Invoice", "Error", "Error");
                        }
                        sc.Complete();
                    }
                    catch (Exception ex)
                    {
                        MainClass.showMSG(ex.Message, "Error..", "Erorr");
                    }
                    
                }
                
                
            }

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceDetails pid = new PurchaseInvoiceDetails();
            MainClass.ShowWindow(pid, this, MDI.ActiveForm);
        }


        private void qtyTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (qtyTxtBox.Text != "")
            {
                if (rg.Match(qtyTxtBox.Text).Success)
                {
                    float quan, price, total;
                    quan = Convert.ToSingle(qtyTxtBox.Text);
                    price = Convert.ToSingle(pupTxtBox.Text);
                    total = quan * price;
                    totalLabel.Text = total.ToString("##########.##");
                    
                    
                }
                else
                {
                    qtyTxtBox.SelectAll();
                }
            }
            else
            {
                totalLabel.Text = "0.00";

            }
        }

        private void compDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (compDD.ValueMember != null)
            {

                r.showList("st_getSupplierList", supplierDD, "supplierName", "supplierID");
            }
        }

        private void pupTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (pupTxtBox.Text != null)
            {
                if (!rg.Match(pupTxtBox.Text).Success)
                {
                    pupTxtBox.Text = "";
                    pupTxtBox.Focus();
                }
            }
        }
        string[] prodArr = new string[3];
        private void modelNoTxt_Validating(object sender, CancelEventArgs e)
        {
            if (modelNoTxt.Text != "")
            {
                prodArr = r.showProductsWRTModelNo(modelNoTxt.Text);
                proID = Convert.ToInt32(prodArr[0]);
                productNameTxtBox.Text = prodArr[1];
                string mdNo = prodArr[2];
                productNameTxtBox.Enabled = false;

            }
            else
            {
                proID = 0;
                pupTxtBox.Text = "";
                qtyTxtBox.Text = "";
                Array.Clear(prodArr, 0, prodArr.Length);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    gt -= Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                    GrossTotalLabel.Text = gt.ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (compDD.SelectedIndex == -1 || compDD.SelectedIndex == 0) { cpNameErrorLabel.Visible = true; } else { cpNameErrorLabel.Visible = false; }
            if (supplierDD.SelectedIndex == -1 || supplierDD.SelectedIndex == 0) { supNameErrorLabel.Visible = true; } else { supNameErrorLabel.Visible = false; }
            if (modelNoTxt.Text == "") { modelErrorLAbel.Visible = true; } else { modelErrorLAbel.Visible = false; }
            if (productNameTxtBox.Text == "") { proNameErrorLabel.Visible = true;} else { proNameErrorLabel.Visible = false; }
            if (pupTxtBox.Text == "") { pupErrorLabel.Visible = true; } else { pupErrorLabel.Visible = false; }
            if (qtyTxtBox.Text == "") { qtyErrorLabel.Visible = true; } else { qtyErrorLabel.Visible = false; }
            if (cpNameErrorLabel.Visible || supNameErrorLabel.Visible || modelErrorLAbel.Visible || proNameErrorLabel.Visible || pupErrorLabel.Visible || qtyErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with stars are Mandatory", "Stop", "Error"); //Error is the type of message in show message Method
            }
            else
            {
                dataGridView1.Rows.Add(proID,productNameTxtBox.Text,qtyTxtBox.Text, pupTxtBox.Text,totalLabel.Text);
                gt += Convert.ToSingle(totalLabel.Text);
                GrossTotalLabel.Text = gt.ToString();
                proID = 0;
                pupTxtBox.Text = "";
                qtyTxtBox.Text = "";
                modelNoTxt.Text = "";
                productNameTxtBox.Text = "";
                totalLabel.Text = "0.00";

                Array.Clear(prodArr,0,prodArr.Length);
             
                
            }
        }
    }
}
