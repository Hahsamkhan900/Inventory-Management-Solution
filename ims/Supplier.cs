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
    public partial class Supplier : Sample2
    {
        int edit = 0; //This 0 an indication to SaveOperation & 1 is an indication of EditOperation
        int supID;
        short stat;
        retrival r = new retrival(); //Making a global obj of Retrival Class
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            r.showList("st_getCompanyList", supCompDD, "Company_Name", "compID");
        }

        private void topRightLabel_Click(object sender, EventArgs e)
        {

        }

        public override void addBtn_Click(object sender, EventArgs e)
        {

            MainClass.enable_reset(leftPanel);
            edit = 0;
            r.showList("st_getCompanyList", supCompDD, "Company_Name", "compID");
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
            r.showList("st_getCompanyList", supCompDD, "Company_Name", "compID");
        }

        public override void saveBTN_Click(object sender, EventArgs e)
        {

            insertion i = new insertion();
            updation u = new updation();
            if (supCompDD.SelectedIndex == -1) { spNameErrorLabel.Visible = true; } else { spNameErrorLabel.Visible = false; }
            if (contactTxtBox.Text == "") { spContactNameErrorLabel.Visible = true; } else { spContactNameErrorLabel.Visible = false; }
            if (phone1TxtBox.Text == "") { phoneNo1ErrorLabel.Visible = true; } else { phoneNo1ErrorLabel.Visible = false; }
            if (emailTxtBox.Text == "") { emailErrorLabel.Visible = true; } else { emailErrorLabel.Visible = false; }
            if (spStatusDD.SelectedIndex == -1) { spStatusErrorLabel.Visible = true; } else { spStatusErrorLabel.Visible = false; }

            if (spNameErrorLabel.Visible || spContactNameErrorLabel.Visible || phoneNo1ErrorLabel.Visible || phoneNo2ErrorLabel.Visible || emailErrorLabel.Visible  || spStatusErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with stars are Mandatory", "Stop", "Error"); //Error is the type of message in show message Method
            }
            else
            {
                if (spStatusDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (spStatusDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) //Code for SaveOperation
                {                                       
                    if (emailTxtBox.Text == "" && phone2TxtBox.Text == "")
                    {
                        i.insertSupplier(Convert.ToInt32(supCompDD.SelectedValue),contactTxtBox.Text, phone1TxtBox.Text, stat);

                    }
                    else if (emailTxtBox.Text != "" && phone2TxtBox.Text == "")
                    {
                        i.insertSupplier(Convert.ToInt32(supCompDD.SelectedValue), contactTxtBox.Text, phone1TxtBox.Text, stat, emailTxtBox.Text);

                    }
                    else if (emailTxtBox.Text == "" && phone2TxtBox.Text != "")
                    {
                        i.insertSupplier(Convert.ToInt32(supCompDD.SelectedValue), contactTxtBox.Text, phone1TxtBox.Text, stat,phone2TxtBox.Text);

                    }
                    else
                    {
                        i.insertSupplier(Convert.ToInt32(supCompDD.SelectedValue), contactTxtBox.Text, phone1TxtBox.Text, stat,  emailTxtBox.Text, phone2TxtBox.Text);
                    }
                    r.showSuppliers(dataGridView1, supIDGV, supNameGV, compIDGV, compNameGV, phone1GV, phone2GV, emailGV, spStatusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) //Code for UpdateOperation
                {

                    DialogResult dr = MessageBox.Show("Are you sure, You want to update the Record ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        if (spStatusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (spStatusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        if (emailTxtBox.Text == "" && phone2TxtBox.Text == "")
                        {
                            u.updateSupplier(supID, contactTxtBox.Text, phone1TxtBox.Text, stat, Convert.ToInt32(supCompDD.SelectedValue),null,null);
                        }
                        else if (emailTxtBox.Text != "" && phone2TxtBox.Text == "")
                        {
                            u.updateSupplier(supID, contactTxtBox.Text, phone1TxtBox.Text, stat, Convert.ToInt32(supCompDD.SelectedValue), null, emailTxtBox.Text);

                        }
                        else if (emailTxtBox.Text == "" && phone2TxtBox.Text != "")
                        {
                            u.updateSupplier(supID, contactTxtBox.Text, phone1TxtBox.Text, stat, Convert.ToInt32(supCompDD.SelectedValue), phone2TxtBox.Text, null);

                        }
                        else
                        {
                            u.updateSupplier(supID, contactTxtBox.Text, phone1TxtBox.Text, stat, Convert.ToInt32(supCompDD.SelectedValue), emailTxtBox.Text, phone2TxtBox.Text);
                        }
                        r.showSuppliers(dataGridView1, supIDGV, supNameGV, compIDGV, compNameGV, phone1GV, phone2GV, emailGV, spStatusGV);
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
                    d.delete(supID, "st_deleteSupplier", "@id");
                    r.showSuppliers(dataGridView1, supIDGV, supNameGV, compIDGV, compNameGV, phone1GV, phone2GV, emailGV,spStatusGV);

                }
            }
        }
        public override void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showSuppliers(dataGridView1, supIDGV, supNameGV, compIDGV, compNameGV, phone1GV, phone2GV, emailGV, spStatusGV);

        }

        private void searchBox_TextChanged_1(object sender, EventArgs e)
        {
            if (searchBox.Text != null)
            {
                r.showSuppliers(dataGridView1, supIDGV, supNameGV, compIDGV, compNameGV, phone1GV, phone2GV, emailGV, spStatusGV,searchBox.Text);
            }
            else
            {
                r.showSuppliers(dataGridView1, supIDGV, supNameGV, compIDGV, compNameGV, phone1GV, phone2GV, emailGV, spStatusGV);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                supID = Convert.ToInt32(row.Cells["supIDGV"].Value.ToString());
                supCompDD.SelectedValue = row.Cells["compIDGV"].Value;
                contactTxtBox.Text = row.Cells["supNameGV"].Value.ToString();
                phone1TxtBox.Text = row.Cells["phone1GV"].Value.ToString();
                phone2TxtBox.Text = row.Cells["phone2GV"].Value.ToString();
                emailTxtBox.Text = row.Cells["emailGV"].Value.ToString();
                spStatusDD.SelectedItem = row.Cells["spStatusGV"].Value.ToString();
                MainClass.disable(leftPanel);

            }
        }
    }
}
