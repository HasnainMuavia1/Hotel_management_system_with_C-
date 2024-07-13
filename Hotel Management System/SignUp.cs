using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management_System
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
            password.Enter += password_Enter;
            confirmpass.Enter += confirmpass_Enter;
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
            signupChild.Controls.Add(childform);
            signupChild.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }



        private void signin_Click(object sender, EventArgs e)
        {
            openchildform(new Form1());
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //if(Name.Text==""||email.Text==""||password.Text==""||confirmpass.Text=="")
            //{
             //   MessageBox.Show("Empty feilds", "Error");
              //  this.Close();
            //}else
            //{
                string constring = "server=localhost;uid=root;pwd=7861;database=sample";
                MySqlConnection con = new MySqlConnection(constring);
                if (password.Text != confirmpass.Text)
                    MessageBox.Show("Password do not match", "Error");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from credentials where email = '" + email.Text + "' and password = '" + password.Text + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                    MessageBox.Show("Credentials Already Exist", "Duplicate credentials");
                else
                {
                    reader.Close();
                    MySqlCommand cmd2 = new MySqlCommand("Insert into credentials (Name,email,password) Values ('" + Name.Text + "','" + email.Text + "','" + password.Text + "')", con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfull", "Done");
                }

            //}



            // Execute the query





        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("www.hotelion.me");
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void password_Enter(object sender, EventArgs e)
        {
            password.Text = string.Empty;
            password.PasswordChar = '●';

        }

        private void confirmpass_Enter(object sender, EventArgs e)
        {
            confirmpass.Text = string.Empty;
            confirmpass.PasswordChar = '●';
        }
    }
}
