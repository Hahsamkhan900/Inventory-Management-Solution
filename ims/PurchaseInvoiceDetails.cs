using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ims
{
    
    public partial class PurchaseInvoiceDetails : Sample2
    {
        int q;
        float gt = 0;
        insertion i = new insertion();
        updation u = new updation();
        deletion d = new deletion();
        public PurchaseInvoiceDetails()
        {
            InitializeComponent();
        }

        private void PurchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            r.showListWithTwoParameters("st_getPurchaseInvoiceList", purInvSelectDD, "Company Name", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);

        }
        retrival r = new retrival();
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            r.showListWithTwoParameters("st_getPurchaseInvoiceList",purInvSelectDD, "Company Name", "ID", "@month",datePicker.Value.Month, "@year",datePicker.Value.Year);
        }
        public override void backBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice obj = new PurchaseInvoice();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete From Purchase Invoice ?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ( dr == DialogResult.Yes)
                {
                    d.delete(Convert.ToInt64(purInvSelectDD.SelectedValue.ToString()), "st_deletePurchaseInvoice", "@piID");
                }
                r.showListWithTwoParameters("st_getPurchaseInvoiceList", purInvSelectDD, "Company Name", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);



            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message,"Error...","Error");
                throw;
            }
        }
        private void purInvSelectDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (purInvSelectDD.SelectedIndex != -1 && purInvSelectDD.SelectedIndex != 0)
            { 
                r.showPurchaseInvoiceDetails(Convert.ToInt64(purInvSelectDD.SelectedValue.ToString()),dataGridView1,mPIDGV,prodIDGV, prodNameGV,proQtyGV,perUnitPriceGV,totalGV);
               
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                }
                GrossTotalLabel.Text = gt.ToString();
                gt = 0; 
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DialogResult dr = MessageBox.Show("Are you sure, you want to delete " + row.Cells["prodNameGV"].Value.ToString() + " From Purchase Invoice ? \n\t\t WARNING \n Deletion of Product will effecr on Stock as well", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            i.insertDeletedItem(Convert.ToInt64(purInvSelectDD.SelectedValue.ToString()), Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["proQtyGV"].Value.ToString()), retrival.user_Id, DateTime.Today);
                            object ob = r.getProductQty(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()));
                            if (ob != null)
                            {
                                q = Convert.ToInt32(ob);
                                q -= Convert.ToInt32(row.Cells["proQtyGV"].Value.ToString());
                                u.updatetStock(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), q);
                                float total = Convert.ToSingle(GrossTotalLabel.Text) - Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                                GrossTotalLabel.Text = total.ToString();
                                d.delete(Convert.ToInt64(row.Cells["mPIDGV"].Value.ToString()), "st_deleteProductFromPID","@mPID");
                                dataGridView1.Rows.Remove(row);
                            }
                            sc.Complete();
                        }
                    }
                }
                catch (Exception)
                {


                }
               
                    
                }
            }
        }
}

