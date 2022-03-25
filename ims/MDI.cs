using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ims
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(Path + "\\connect"))
            {
                Login log = new Login();
                MainClass.ShowWindow(log, this);
            }
            else
            {
                Settings set = new Settings();
                MainClass.ShowWindow(set, this);
            }
           
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            MainClass.ShowWindow(set, this);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.logoutToolStripMenuItem.Enabled = true;
            Login lg = new Login();
            MainClass.ShowWindow(lg, this);
        }
    }
}
 