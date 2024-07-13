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
    public partial class Booking : Form
    {
        public static Booking instance;
        public Bunifu.UI.WinForms.BunifuLabel dlabel;
        public Bunifu.UI.WinForms.BunifuLabel Tlabel;

        public Booking()
        {
            InitializeComponent();
            instance = this;
           

        }
        public bool ispressed1=false;
        public bool ispressed2=false;
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
      

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bookT_Click(object sender, EventArgs e)
        {
            ispressed1 = false;
            openchildform(new booksingle());
        }

        private void bookD_Click_1(object sender, EventArgs e)
        {
            ispressed1 = true;
            openchildform(new booksingle());


        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }
    }
}
