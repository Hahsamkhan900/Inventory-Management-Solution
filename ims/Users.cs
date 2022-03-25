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
    public partial class Users : Sample2
    {
        int edit = 0; //This 0 an indication to SaveOperation & 1 is an indication of EditOperation
        int userID;
        short stat;
        retrival r = new retrival(); //Making a global obj of Retrival Class
        public Users()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
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
            if (nameTxtBox.Text == "") { NameErrorLabel.Visible = true; } else { NameErrorLabel.Visible = false; }
            if (usernameTxtBox.Text == "") { UsernameErrorLabel.Visible = true; } else { UsernameErrorLabel.Visible = false; }
            if (pwdTxtBox.Text == "") { PassErrorLabel.Visible = true; } else { PassErrorLabel.Visible = false; }
            if (phoneTxtBox.Text == "") { PhoneErrorLabel.Visible = true; } else { PhoneErrorLabel.Visible = false; }
            if (emailTxtBox.Text == "") { EmailErrorLabel.Visible = true; } else { EmailErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }



            if (NameErrorLabel.Visible || UsernameErrorLabel.Visible || PassErrorLabel.Visible || PhoneErrorLabel.Visible || EmailErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with stars are Mandatory", "Stop", "Error"); //Error is the type of message in show message Method
            }
            else
            {
                if (statusDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) //Code for SaveOperation
                {

                    insertion i = new insertion();
                    i.insertUser(nameTxtBox.Text, usernameTxtBox.Text, pwdTxtBox.Text, emailTxtBox.Text, phoneTxtBox.Text, stat);
                    r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, passwordGV, EmailGV, PhoneGV, StatusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) //Code for UpdateOperation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, You want to update the Record ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();

                        if (statusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        u.updateUser(userID, nameTxtBox.Text, usernameTxtBox.Text, pwdTxtBox.Text, emailTxtBox.Text, phoneTxtBox.Text, stat);
                        r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, passwordGV, EmailGV, PhoneGV, StatusGV);
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
                    d.delete(userID, "st_deleteUser", "@id");
                    r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, passwordGV, EmailGV, PhoneGV, StatusGV);
                }
            }
        }

        public override void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != null)
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, passwordGV, EmailGV, PhoneGV, StatusGV, searchBox.Text);
            }
            else
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, passwordGV, EmailGV, PhoneGV, StatusGV);
            }
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, passwordGV, EmailGV, PhoneGV, StatusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTxtBox.Text = row.Cells["NameGV"].Value.ToString();
                usernameTxtBox.Text = row.Cells["UserNameGV"].Value.ToString();
                pwdTxtBox.Text = row.Cells["passwordGV"].Value.ToString();
                emailTxtBox.Text = row.Cells["EmailGV"].Value.ToString();
                phoneTxtBox.Text = row.Cells["PhoneGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);


            }
        }
    }
}
