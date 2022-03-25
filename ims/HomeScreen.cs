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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            MDI md = new MDI();
            md.logoutToolStripMenuItem.Enabled = true;
            topRightLabel.Text = retrival.emp_Name + "  Welcome to Home Page";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stocks st = new Stocks();
            MainClass.ShowWindow(st, this, MDI.ActiveForm);
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void catBtn_Click(object sender, EventArgs e)
        {
            Categories obj = new Categories();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            products obj = new products();
            MainClass.ShowWindow(obj,this,MDI.ActiveForm);
          
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            Supplier sp = new Supplier();
            MainClass.ShowWindow(sp, this, MDI.ActiveForm);
        }

        private void purchInvBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice pi = new PurchaseInvoice();
            MainClass.ShowWindow(pi, this, MDI.ActiveForm);
        }

        private void compBTN_Click(object sender, EventArgs e)
        {
            Company cp = new Company();
            MainClass.ShowWindow(cp, this, MDI.ActiveForm);
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            MainClass.ShowWindow(s, this, MDI.ActiveForm);
        }

        private void proPricingBtn_Click(object sender, EventArgs e)
        {
            ProductPricing pp = new ProductPricing();
            MainClass.ShowWindow(pp, this, MDI.ActiveForm);
        }

        private void saleReturnBtn_Click(object sender, EventArgs e)
        {
            SaleReturn sr = new SaleReturn();
            MainClass.ShowWindow(sr, this, MDI.ActiveForm);
        }
    }
}
