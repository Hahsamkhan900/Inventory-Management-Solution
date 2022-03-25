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
    
    public partial class Stocks : Sample2
    {
        retrival r = new retrival();
        public Stocks()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            base.addBtn.Enabled = false;
            base.saveBTN.Enabled = false;
            base.editBtn.Enabled = false;
            base.searchBox.Enabled = false;
            base.deleteBtn.Enabled = false;
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showStockDetails(dataGridView1, prdtIDGV, prdtNameGv, catNameGV, modelNoGV, productPriceGV, prdtSellPriveGV,avStockGV, StatusGV, finalGV);
        }
    }
}
