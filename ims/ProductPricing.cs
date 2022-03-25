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
    public partial class ProductPricing : Sample2
    {
        retrival r = new retrival();
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        updation u = new updation();
        float disc , profitMargin,bp,sp;
        int proID,check;
        public ProductPricing()
        {
            InitializeComponent();
            r.showList("st_getCategoryList", pCatCBox, "Category", "ID");
        }

        private void ProductPricing_Load(object sender, EventArgs e)
        {

        }

        private void pCatCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pCatCBox.SelectedIndex !=-1 && pCatCBox.SelectedIndex != 0)
            {
                r.showProductWRTCategory(Convert.ToInt32(pCatCBox.SelectedValue.ToString()), dataGridView1, prodIDGV, prodNameGV, buyingPriceGV,profMarginGV,discountGV,finalPriceGV);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex !=  -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                try
                {
                    if (row.Cells["profMarginGV"].Value != null && rg.Match(row.Cells["profMarginGV"].Value.ToString()).Success)
                    {
                        float buyingPrice = Convert.ToSingle(row.Cells["buyingPriceGV"].Value.ToString());
                        float profitMargin = (Convert.ToSingle(row.Cells["profMarginGV"].Value.ToString()) / 100);
                        float amountToIncrease = buyingPrice * profitMargin;
                        float finalSellingPrice = buyingPrice + amountToIncrease;
                        float discountPer;
                        if (row.Cells["discountGV"].Value != null && rg.Match(row.Cells["discountGV"].Value.ToString()).Success)
                        {
                            discountPer = finalSellingPrice * (Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) / 100);

                        }
                        else
                        {
                            discountPer = 0;
                        }
                        row.Cells["finalPriceGV"].Value = finalSellingPrice-discountPer;

                    }
                    else
                    {

                        row.Cells["profMarginGV"].Value = null;
                        row.Cells["discountGV"].Value = null;
                        row.Cells["finalPriceGV"].Value = null;
                    }
                }
                catch (Exception ex)
                {
                    MainClass.showMSG(ex.Message,"Error..","Error");
                }

            }
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        public override void saveBTN_Click(object sender, EventArgs e)
        {
            if (pCatCBox.SelectedIndex != -1 && pCatCBox.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((bool)row.Cells["selectGV"].FormattedValue== true)
                    {
                        check++;
                        proID = Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString());
                        bp = Convert.ToSingle(row.Cells["buyingPriceGV"].Value.ToString());
                        profitMargin = row.Cells["profMarginGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["profMarginGV"].Value.ToString());
                        disc = row.Cells["discountGV"].Value == null?0 : Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                        if (disc == 0 && profitMargin == 0)
                        {
                            sp = bp;
                        }
                        else
                        {
                            sp = Convert.ToSingle(row.Cells["finalPriceGV"].Value.ToString());
                        }
                        u.updateProductPrice(proID,bp,profitMargin,disc,sp);
                        
                    }
                    
                }
            }
            if (check>0)
            {
                MainClass.showMSG("Product Pricing updated Successfully...", "Success", "Success"); 
                check = 0;
            }
            else
            {
                MainClass.showMSG("Please Select any Product first.....", "Error...", "Error");
                check = 0;
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }
        public override void searchBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
