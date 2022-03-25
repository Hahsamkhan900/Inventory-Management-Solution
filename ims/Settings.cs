using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string s;
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (isChkBox.Checked)
            {
                if (serverTxtBox.Text != "" && databaseTxt.Text != "")
                {
                    s = "Data Source = " + serverTxtBox.Text + "; Initial Catalog = " + databaseTxt.Text + "; Integrated Security = True; MultipleActiveResultSets=true";
                    File.WriteAllText(Path + "\\connect",s);
                    DialogResult dr = MessageBox.Show("Setting Saved Succesfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.ShowWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill all Fields Properly...");
                }
            }
            else
            {
                    if (serverTxtBox.Text !="" && databaseTxt.Text != "" && userTxtBox.Text != "" && pwdTxtBox.Text != "")
                {
                    s = "Data Source = " + serverTxtBox.Text + "; Initial Catalog = " + databaseTxt.Text + "; User ID ="+ userTxtBox.Text + "; Password = " +pwdTxtBox.Text +";MultipleActiveResultSets=true";
                    File.WriteAllText(Path + "\\connect" , s);
                    DialogResult dr = MessageBox.Show("Setting Saved Succesfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.ShowWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill all Fields Properly...");
                }
            }

          
            
        }

        private void isChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isChkBox.Checked)
            {
                userTxtBox.Enabled = false;
                pwdTxtBox.Enabled = false;
                userTxtBox.Text = "";
                pwdTxtBox.Text = "";
            }
            else
            {
                userTxtBox.Enabled = true;
                pwdTxtBox.Enabled = true;
            }
        }
    }
}
