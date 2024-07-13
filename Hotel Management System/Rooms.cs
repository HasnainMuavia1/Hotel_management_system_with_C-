using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Rooms : Form
    {
        public static Rooms form1Instance;
        public Rooms()
        {
            InitializeComponent();
            form1Instance = this;
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }
        private Form activeform = null;
        private void openchildform(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            childpanel.Controls.Add(childform);
           
            childpanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            openchildform(new single());
         

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            openchildform(new Double());
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            openchildform(new Triple());
        }
    }
}
