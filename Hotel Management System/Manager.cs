using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class Manager : Form
    {
        public static Manager instance;
        Thread th;
        public Manager()
        {
            InitializeComponent();
            instance = this;
        }
        public void openform(object obj)
        {
            Application.Run(new AddBooking());
        }
        public void openform2(object obj)
        {
            Application.Run(new Form1());
        }

        private void Manager_Load(object sender, EventArgs e)
        {

            User.Text = Form1.instance.User;
            bunifuLabel9.Text = DateTime.Now.ToString();
            string constring = "server=localhost;uid=root;pwd=7861;database=sample";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select name,cnic,phone,check_in,check_out,roomType from booking join room using (room_id)", conn);

            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt=new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            grid.DataSource = dt;
        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuVSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
        {
            grid.FirstDisplayedScrollingColumnIndex = grid.SelectedRows[e.Value].Index;
        }

        private void AddBooking_Click(object sender, EventArgs e)
        {
            th = new Thread(openform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnsales_Click(object sender, EventArgs e)
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

        private void btnstaff_Click(object sender, EventArgs e)
        {
            btnBookings_Leave(sender, e);
            btnstaff.BackColor = Color.FromArgb(6, 156, 49);
            btnstaff.ForeColor = Color.FromArgb(255, 255, 255);
            btnstaff.IconColor = Color.FromArgb(255, 255, 255);
            openchildform(new Staff());
            

        }

        private void btnBookings_Leave(object sender, EventArgs e)
        {
            btnBookings.BackColor = Color.FromArgb(236, 243, 243);
            btnBookings.ForeColor = Color.DimGray;
            btnBookings.IconColor = Color.DimGray;
        }

        private void btnstaff_Leave(object sender, EventArgs e)
        {
            btnstaff.BackColor = Color.FromArgb(236, 243, 243);
            btnstaff.ForeColor = Color.DimGray;
            btnstaff.IconColor = Color.DimGray;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            //th = new Thread(openform2);
            //th.SetApartmentState(ApartmentState.STA);
           // th.Start();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            activeform.Close();
           

        }
    }
}
