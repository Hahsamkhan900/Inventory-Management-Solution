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
    public partial class Company : Sample2
    {

        int edit = 0; //This 0 an indication to SaveOperation & 1 is an indication of EditOperation
        int compID;
        short stat;
        retrival r = new retrival(); //Making a global obj of Retrival Class
        public Company()
        {
            InitializeComponent();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {

            MainClass.enable_reset(leftPanel);
            edit = 0;
        }
        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveBTN_Click(object sender, EventArgs e)
        {

            insertion i = new insertion();
            updation u = new updation();
            if (CcompNameTxtBox.Text == "") { compNameErrorLabel.Visible = true; } else { compNameErrorLabel.Visible = false; }
            if (CcompAddressTxtBox.Text == "") { CompAddressErrorLabel.Visible = true; } else { CompAddressErrorLabel.Visible = false; }
            if (Cphone1TxtBox.Text == "") { CphoneNo1ErrorLabel.Visible = true; } else { CphoneNo1ErrorLabel.Visible = false; }
            if (CStatusDD.SelectedIndex == -1) { cStatusErrorLabel.Visible = true; } else { cStatusErrorLabel.Visible = false; }

            if (compNameErrorLabel.Visible || CompAddressErrorLabel.Visible || CphoneNo1ErrorLabel.Visible || CphoneNo2ErrorLabel.Visible || cStatusErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with stars are Mandatory", "Stop", "Error"); //Error is the type of message in show message Method
            }
            else
            {
                if (CStatusDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (CStatusDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) //Code for SaveOperation
                {
                    if (CNtnTextBox.Text == "" && Cphone2TxtBox.Text == "")
                    {
                        i.insertComp(CcompNameTxtBox.Text, CcompAddressTxtBox.Text, Cphone1TxtBox.Text, stat);

                    }
                    else if (CNtnTextBox.Text != "" && Cphone2TxtBox.Text == "")
                    {
                        i.insertComp(CcompNameTxtBox.Text, CcompAddressTxtBox.Text, Cphone1TxtBox.Text, stat, CntnErrorLabel.Text);

                    }
                    else if (CNtnTextBox.Text == "" && Cphone2TxtBox.Text != "")
                    {
                        i.insertComp(CcompNameTxtBox.Text, CcompAddressTxtBox.Text, Cphone1TxtBox.Text, stat, Cphone2TxtBox.Text);

                    }
                    else
                    {
                        i.insertComp(CcompNameTxtBox.Text, CcompAddressTxtBox.Text, Cphone1TxtBox.Text, stat, CntnErrorLabel.Text, Cphone2TxtBox.Text);
                    }
                    r.showCompany(dataGridView1, compIDGV, compNameGV, compAddressGV, Cphone1GV, Cphone2GV, CntnGV, CStatusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) //Code for UpdateOperation
                {

                    DialogResult dr = MessageBox.Show("Are you sure, You want to update the Record ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (CStatusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (CStatusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        if (CNtnTextBox.Text == "" && Cphone2TxtBox.Text == "")
                        {
                            u.updateCompany(compID, CcompNameTxtBox.Text, CcompAddressTxtBox.Text, Cphone1TxtBox.Text, stat, null, null);
                        }
                        else if (CNtnTextBox.Text != "" && Cphone2TxtBox.Text == "")
                        {
                            u.updateCompany(compID, CcompNameTxtBox.Text, CcompAddressTxtBox.Text, Cphone1TxtBox.Text, stat, CNtnTextBox.Text, null);

                        }
                        else if (CNtnTextBox.Text == "" && Cphone2TxtBox.Text != "")
                        {
                            u.updateCompany(compID, CcompNameTxtBox.Text, CcompAddressTxtBox.Text, Cphone1TxtBox.Text, stat, Cphone2TxtBox.Text, null);

                        }
                        else
                        {
                            u.updateCompany(compID, CcompNameTxtBox.Text, CcompAddressTxtBox.Text, Cphone1TxtBox.Text, stat, Cphone2TxtBox.Text, CNtnTextBox.Text);
                        }
                        r.showCompany(dataGridView1, compIDGV, compNameGV, compAddressGV, Cphone1GV, Cphone2GV, CntnGV, CStatusGV);
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
                            d.delete(compID, "st_deleteCompany", "@id");
                            r.showCompany(dataGridView1, compIDGV, compNameGV, compAddressGV, Cphone1GV, Cphone2GV, CntnGV, CStatusGV);
                        }
                    }
                 }
                public override void searchBox_TextChanged(object sender, EventArgs e)
                {
                    if (searchBox.Text != null)
                    {
                        r.showCompany(dataGridView1, compIDGV, compNameGV, compAddressGV, Cphone1GV, Cphone2GV, CntnGV, CStatusGV, searchBox.Text);
                    }
                    else
                    {
                         r.showCompany(dataGridView1, compIDGV, compNameGV, compAddressGV, Cphone1GV, Cphone2GV, CntnGV, CStatusGV);
                    }
                }
                public override void viewBtn_Click(object sender, EventArgs e)
                {
                    r.showCompany(dataGridView1, compIDGV, compNameGV, compAddressGV, Cphone1GV, Cphone2GV, CntnGV, CStatusGV);

                }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                compID = Convert.ToInt32(row.Cells["compIDGV"].Value.ToString());
                CcompNameTxtBox.Text = row.Cells["compNameGV"].Value.ToString();
                CcompAddressTxtBox.Text = row.Cells["compAddressGV"].Value.ToString();
                Cphone1TxtBox.Text = row.Cells["Cphone1GV"].Value.ToString();
                Cphone2TxtBox.Text = row.Cells["Cphone2GV"].Value.ToString();
                CNtnTextBox.Text = row.Cells["CntnGV"].Value.ToString();
                CStatusDD.SelectedItem = row.Cells["CStatusGV"].Value.ToString();

                MainClass.disable(leftPanel);


            }
        }
    }
}

