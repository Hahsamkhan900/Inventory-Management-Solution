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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        protected void Sample2_Load(object sender, EventArgs e)
        {

        }

        protected void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        protected void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public virtual void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }


        protected void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void rightTopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public virtual void addBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void editBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void saveBTN_Click(object sender, EventArgs e)
        {

        }

        public virtual void viewBtn_Click(object sender, EventArgs e)
        {

        }
        public virtual void searchBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
