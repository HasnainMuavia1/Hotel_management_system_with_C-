using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    
    public partial class booksingle : Form
    {
        public static booksingle instance;
        public booksingle()
        {
            InitializeComponent();
            instance = this;
        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
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
            bunifuPanel1.Controls.Add(childform);

            bunifuPanel1.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void Book_Click(object sender, EventArgs e)
        {
            int adult1 = Int32.Parse(adult.Text);
            int child1 = Int32.Parse(child.Text);
            if (Name.Text == "" || cnic.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Input All feilds ! ", "Error");
            }
            else
            {
                string constring = "server=localhost;uid=root;pwd=7861;database=sample";
                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();
                //MySqlCommand cmd = new MySqlCommand("INSERT INTO booking (check_in,check_out,name,cnic,phone,adult,child)  ('"+check_in.Text+"','"+check_out.Text+"','"+Name.Text+"','"+cnic.Text+"','"+phone.Text+"',"+adult1+","+child1+")", conn);
                MySqlCommand cmd = new MySqlCommand("INSERT INTO booking (check_in, check_out, name, cnic, phone, adult, child) VALUES (@check_in, @check_out, @name, @cnic, @phone, @adult, @child)", conn);
                cmd.Parameters.AddWithValue("@check_in", check_in.Text);
                cmd.Parameters.AddWithValue("@check_out", check_out.Text);
                cmd.Parameters.AddWithValue("@name", Name.Text);
                cmd.Parameters.AddWithValue("@cnic", cnic.Text);
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue("@adult", adult1);
                cmd.Parameters.AddWithValue("@child", child1);
                cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking SuccessFull ! ", "Success");
               // openchildform(new Receipt());
                

            }
        }

        private void booksingle_Load(object sender, EventArgs e)
        {
            DateTime dt = Customer.instance.Check_in1.Value;
            DateTime dt2 = Customer.instance.Check_out2.Value;
            check_in.Value = dt;
            check_out.Value = dt2;
            
            if(Customer.instance.notchanged==false)
           {
                if (Booking.instance.ispressed1)
                {
                    label1.Text = "Double Room";
                    btnback.Text = "Double Room";
                }
                else 
                {
                    label1.Text = "Triple Room";
                    btnback.Text = "Triple Room";
                }
            }
            
                
                
            

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
