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
    public partial class Categories : Sample2
    {
        int edit = 0; //This 0 an indication to SaveOperation & 1 is an indication of EditOperation
        int catID;
        short stat;
        retrival r = new retrival(); //Making a global obj of Retrival Class
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);
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
            if (catTxtBox.Text == "") { catErrorLabel.Visible = true; } else { catErrorLabel.Visible = false; }

            if (catStatDD.SelectedIndex == -1) { catStatErrorLabel.Visible = true; } else { catStatErrorLabel.Visible = false; }



            if (catErrorLabel.Visible || catStatErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with stars are Mandatory", "Stop", "Error"); //Error is the type of message in show message Method
            }
            else
            {
                if (catStatDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (catStatDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) //Code for SaveOperation
                {
                    insertion i = new insertion();
                    i.insertCategory(catTxtBox.Text, stat);
                    r.showCategory(dataGridView1,catIDGV,catNameGV,StatusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) //Code for UpdateOperation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, You want to update the Record ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (catStatDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (catStatDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        u.updateCategory(catID, catTxtBox.Text, stat);
                        r.showCategory(dataGridView1, catIDGV, catNameGV, StatusGV);
                        MainClass.disable_reset(leftPanel);
                    }

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                catTxtBox.Text = row.Cells["catNameGV"].Value.ToString();
                catStatDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);


            }
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showCategory(dataGridView1, catIDGV, catNameGV, StatusGV);
        }

        private void searchBox_TextChanged_1(object sender, EventArgs e)
        {

            if (searchBox.Text != null)
            {
                r.showCategory(dataGridView1,catIDGV, catNameGV , StatusGV, searchBox.Text);
            }
            else
            {
                r.showCategory(dataGridView1, catIDGV, catNameGV, StatusGV);
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
                    d.delete(catID, "st_deleteCategory", "@id");
                    r.showCategory(dataGridView1, catIDGV, catNameGV, StatusGV);
                }
            }
        }
    }
}


