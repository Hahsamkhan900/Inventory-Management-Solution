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
    public partial class products : Sample2
    {
        int edit = 0; //This 0 an indication to SaveOperation & 1 is an indication of EditOperation
        int proID;
       
        retrival r = new retrival(); //Making a global obj of Retrival Class
        public products()
        {
            InitializeComponent();
        }
        private void products_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            r.showList("st_getCategoryList", pCatCBox, "Category", "ID");
           
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            
            MainClass.enable_reset(leftPanel);
            edit = 0;

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            r.showList("st_getCategoryList", pCatCBox, "Category", "ID");
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveBTN_Click(object sender, EventArgs e)
        {
            if (pCatCBox.SelectedIndex == -1 || pCatCBox.SelectedIndex == 0) { pCatErrorLabel.Visible = true; } else { pCatErrorLabel.Visible = false; }
            if (pNameTxtBox.Text == "") { pNameErrorLabel.Visible = true; } else { pNameErrorLabel.Visible = false; }
            if (proModelNoTxtBox.Text == "") { modelNoErrorLabel.Visible = true; } else { modelNoErrorLabel.Visible = false; }
            if (purDatePicker.Text == "") { pDateErrorLabel.Visible = true; pDateErrorLabel.Text = "Invalid Date"; } else { pDateErrorLabel.Visible = false; }
            
            if (pCatErrorLabel.Visible || pNameErrorLabel.Visible || modelNoErrorLabel.Visible || pDateErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with stars are Mandatory", "Stop", "Error"); //Error is the type of message in show message Method
            }
            else
            {
                if (edit == 0) //Code for SaveOperation
                {
                    insertion i = new insertion();
                    i.insertProduct(pNameTxtBox.Text, proModelNoTxtBox.Text, purDatePicker.Value, Convert.ToInt32(pCatCBox.SelectedValue));
                    r.showProduct(dataGridView1, prdtIDGV, prdtCatGV, prdtCatIDGV, prdtNameGV, prdtModelNoGV, prdtDateGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) //Code for UpdateOperation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, You want to update the Record ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        u.updateProduct(proID, pNameTxtBox.Text, proModelNoTxtBox.Text, purDatePicker.Text, Convert.ToInt32(pCatCBox.SelectedValue));
                        r.showProduct(dataGridView1, prdtIDGV, prdtCatGV, prdtCatIDGV, prdtNameGV, prdtModelNoGV, prdtDateGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, You want to delete the Record ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.delete(proID, "st_deleteProduct", "@prdt_ID");
                    r.showProduct(dataGridView1, prdtIDGV, prdtCatGV, prdtNameGV, prdtCatIDGV, prdtModelNoGV, prdtDateGV);
                }
            }
        }

        public override void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showProduct(dataGridView1, prdtIDGV, prdtCatGV, prdtCatIDGV, prdtNameGV,prdtModelNoGV, prdtDateGV);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pCatCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pCategoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void pCatErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                pCatCBox.SelectedValue = row.Cells["prdtCatIDGV"].Value;
                proID = Convert.ToInt32(row.Cells["prdtIDGV"].Value.ToString());
                pNameTxtBox.Text = row.Cells["prdtNameGV"].Value.ToString();
                proModelNoTxtBox.Text = row.Cells["prdtModelNoGV"].Value.ToString();
                purDatePicker.Value = Convert.ToDateTime(row.Cells["prdtDateGV"].Value.ToString());
                MainClass.disable(leftPanel);


            }
        }

        private void searchBox_TextChanged_1(object sender, EventArgs e)
        {

            if (searchBox.Text != null)
            {
                r.showProduct(dataGridView1, prdtIDGV, prdtCatGV, prdtCatIDGV, prdtModelNoGV, prdtNameGV, prdtDateGV, searchBox.Text);
                
            }
            else
            {
                r.showProduct(dataGridView1, prdtIDGV, prdtCatGV, prdtCatIDGV, prdtNameGV, prdtModelNoGV, prdtDateGV);

            }
        }
    }
}
