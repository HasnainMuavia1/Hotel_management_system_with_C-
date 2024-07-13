using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using MySql.Data.MySqlClient;
using System.Threading;
namespace Hotel_Management_System
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        Thread th;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            password.Enter += password_Enter;
        }
        public void openform(object obj)
        {
            Application.Run(new Customer());
        }
        private Form activeform = null;
       

        private void openchildform(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            //current = childform;
           childform.TopLevel = false;
            childform.FormBorderStyle= FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            childpanel.Controls.Add(childform);
           childpanel.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void signup_Click(object sender, EventArgs e)
        {
            
            openchildform(new signup());
        }
        public string User;
        private void signin_Click(object sender, EventArgs e)
        {
                
                string constring = "server=localhost;uid=root;pwd=7861;database=sample";
                MySqlConnection con = new MySqlConnection(constring);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from credentials where username = '" + username.Text + "' and password = '" + password.Text + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    User = reader["Name"].ToString();
                    if ((string)reader["Role"]=="Manager")
                        openchildform(new Manager());
                    else if((string)reader["Role"] == "Receptionist")
                        openchildform(new Receptionist());
                }else
                {
                    MessageBox.Show("Wrong Username and password ! ", "Error");
                }

            
                con.Close();
            


        }

       
        private void customer_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("www.hotelion.me");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void password_Enter(object sender, EventArgs e)
        {
            password.Text = string.Empty;
            password.PasswordChar = '●';
        }

        private void password_Click(object sender, EventArgs e)
        {
            password.Text = string.Empty;
            password.PasswordChar = '●';

        }
    }
}
