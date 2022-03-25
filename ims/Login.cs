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
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //HomeScreen hm = new HomeScreen();
            //MainClass.ShowWindow(hm, this, MDI.ActiveForm);
            if (unTxtBox.Text == "") { unErrorLabel.Visible = true; } else { unErrorLabel.Visible = false; }
            if (pwdTxtBox.Text == "") { pwdErrorLabel.Visible = true; } else { pwdErrorLabel.Visible = false; }
            if (unErrorLabel.Visible || pwdErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with stars are Mandatory", "Stop", "Error"); //Error is the type of message in show message Method

            }
            else
            {
                if (retrival.getUserDetails(unTxtBox.Text, pwdTxtBox.Text))
                {
                    HomeScreen hm = new HomeScreen();
                    MainClass.ShowWindow(hm, this, MDI.ActiveForm);
                }

            }

        }

        private void unTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (unTxtBox.Text == "") { unErrorLabel.Visible = true; } else { unErrorLabel.Visible = false; }
        }

        private void pwdTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (pwdTxtBox.Text == "") { pwdErrorLabel.Visible = true; } else { pwdErrorLabel.Visible = false; }
        }
    }
}
