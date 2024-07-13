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
using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace Hotel_Management_System
{
    public partial class Receptionist : Form
    {
        Receptionist instance;
        Thread th;
        private MySqlConnection connection;
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public Receptionist()
        {
            InitializeComponent();
            InitializeDatabase();
            instance = this;
        }
        private void InitializeDatabase()
        {
            string connectionString = "server=localhost;uid=root;pwd=7861;database=sample";
            connection = new MySqlConnection(connectionString);
            
            dataAdapter = new MySqlDataAdapter("select room_id,booking_id,name,cnic,phone,check_in,check_out from booking left join room using (room_id)", connection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            grid.DataSource = dataTable;
        }
        public void openform(object obj)
        {
            Application.Run(new AddBooking());
        }
        // public MySqlDataAdapter mydtadp = new MySqlDataAdapter();
        //public  BindingSource bindingSource1 = new BindingSource();
        //public MySqlCommandBuilder cmbl;
        
        private void Receptionist_Load(object sender, EventArgs e)
        {
             
            
            User.Text = Form1.instance.User;
            bunifuLabel6.Text = DateTime.Now.ToString();
            //string constring = "server=localhost;uid=root;pwd=7861;database=sample";
            //MySqlConnection conn = new MySqlConnection(constring);
            //MySqlDataAdapter ad = new MySqlDataAdapter();
           // conn.Open();
           // mydtadp.SelectCommand= new MySqlCommand("select booking_id,name,cnic,phone,check_in,check_out from booking", conn);

            //cmbl = new MySqlCommandBuilder(mydtadp);

            //DataTable table = new DataTable();
            //mydtadp.Fill(table);

           // bindingSource1.DataSource = table;
            //grid.DataSource = bindingSource1;
           



        }

        

        private void iconButton1_Click(object sender, EventArgs e)
        {
            th = new Thread(openform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        //delete button
        public int id;
        private void iconButton2_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=7861;database=sample";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            MySqlCommand cmd2 = new MySqlCommand("Delete from booking where booking_id=" + id + "", conn);
            cmd2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfull!", "deleted");
            Receptionist_Load(null, null);
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
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sid = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["booking_id"].Value);
            id = sid;
        }
        private void SaveChanges()
        {
                dataAdapter.Update(dataTable);
            
        }

       

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            SaveChanges();
            
        }

        private void Receptionist_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChanges();
            connection.Open();
            MySqlCommand cmd1 = new MySqlCommand("Update room set isAvailable=0 where room_id In(select room_id from booking)",connection);
            cmd1.ExecuteNonQuery();

           connection.Close();
           
        }

        private void Availability_Click(object sender, EventArgs e)
        {
            btnBookings_Leave(sender, e);
            Availability.BackColor = Color.FromArgb(6, 156, 49);
            Availability.ForeColor = Color.FromArgb(255, 255, 255);
            Availability.IconColor = Color.FromArgb(255, 255, 255);
            openchildform(new Availability());
        }

        private void Availability_Leave(object sender, EventArgs e)
        {
            Availability.BackColor = Color.FromArgb(236, 243, 243);
            Availability.ForeColor = Color.DimGray;
            Availability.IconColor = Color.DimGray;
        }

        private void btnBookings_Leave(object sender, EventArgs e)
        {
            btnBookings.BackColor = Color.FromArgb(236, 243, 243);
            btnBookings.ForeColor = Color.DimGray;
            btnBookings.IconColor = Color.DimGray;
        }

        private void Housekeeping_Click(object sender, EventArgs e)
        {
            btnBookings_Leave(sender, e);
            Housekeeping.BackColor = Color.FromArgb(6, 156, 49);
            Housekeeping.ForeColor = Color.FromArgb(255, 255, 255);
            Housekeeping.IconColor = Color.FromArgb(255, 255, 255);
            openchildform(new Tasks());
        }

        private void Housekeeping_Leave(object sender, EventArgs e)
        {
            Housekeeping.BackColor = Color.FromArgb(236, 243, 243);
            Housekeeping.ForeColor = Color.DimGray;
            Housekeeping.IconColor = Color.DimGray;
        }

        private void childpanel_Click(object sender, EventArgs e)
        {

        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            activeform.Close();
            btnBookings.BackColor = Color.FromArgb(6, 156, 49);
            btnBookings.ForeColor = Color.FromArgb(255, 255, 255);
            btnBookings.IconColor = Color.FromArgb(255, 255, 255);
        }
    }
}
