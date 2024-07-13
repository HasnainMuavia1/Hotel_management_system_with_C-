using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class Customer : Form
    {
        public static Customer instance;
        public Bunifu.UI.WinForms.BunifuDatePicker Check_in1;

        public Bunifu.UI.WinForms.BunifuDatePicker Check_out2;
        public int adultVal=1;
        public int childVal=0;
        public Customer()
        {
            InitializeComponent();
            instance=this;
            Check_out2 = Check_out;
            Check_in1 = Check_in;
            //adultVal = Int32.Parse(adult.Text);
            //childVal = Int32.Parse(child.Text);




        }

        private void childScreen_Click(object sender, EventArgs e)
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
        private void Customer_Load(object sender, EventArgs e)
        {
            Check_in.CustomFormat = "yyyy-MM-dd";
            Check_in.Format = DateTimePickerFormat.Custom;
            Check_out.CustomFormat = "yyyy-MM-dd";
            Check_out.Format = DateTimePickerFormat.Custom;
        }

        private void btnbook_Click(object sender, EventArgs e)
        {
            btnbook.BackColor = Color.FromArgb(6, 156, 49);
            btnbook.ForeColor = Color.FromArgb(255, 255, 255);
            btnbook.IconColor= Color.FromArgb(255, 255, 255);
            activeform.Close();
           

        }

        private void btnroom_Click(object sender, EventArgs e)
        {
            btnbook_Leave(sender, e);
            btnroom.BackColor = Color.FromArgb(6, 156, 49);
            btnroom.ForeColor = Color.FromArgb(255, 255, 255);
            btnroom.IconColor = Color.FromArgb(255, 255, 255);
            openchildform(new Rooms());
           
            
            
        }

        

        private void btnbook_Leave(object sender, EventArgs e)
        {
            btnbook.BackColor = Color.FromArgb(236, 243, 243);
            btnbook.ForeColor = Color.DimGray;
            btnbook.IconColor = Color.DimGray;
        }

        private void btnroom_Leave(object sender, EventArgs e)
        {
            btnroom.BackColor = Color.FromArgb(236, 243, 243);
            btnroom.ForeColor = Color.DimGray;
            btnroom.IconColor = Color.DimGray;
        }

        private void btncontact_Leave(object sender, EventArgs e)
        {
            btncontact.BackColor = Color.FromArgb(236, 243, 243);
            btncontact.ForeColor = Color.DimGray;
            btncontact.IconColor = Color.DimGray;
            

        }

        private void btncontact_Click(object sender, EventArgs e)
        {
            btnbook_Leave(sender, e);
            btncontact.BackColor = Color.FromArgb(6, 156, 49);
            btncontact.ForeColor = Color.FromArgb(255, 255, 255);
            btncontact.IconColor = Color.FromArgb(255, 255, 255);
            
            openchildform(new ContactUs());
            

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }
        public bool notchanged = false;

        private void Search_Click(object sender, EventArgs e)
        {

            int adult1 = Int32.Parse(adult.Text);
            int child1 = Int32.Parse(child.Text);
            adultVal = adult1;
            childVal = child1;
            if (Check_in.Text == ""||Check_out.Text == ""||adult1 == 0)
            {
                MessageBox.Show("input All values ", "Empty feilds");
            }else
            {
                if(adult1==1&&child1==0)
                {
                    notchanged = true;
                    openchildform(new booksingle());

                }else
                {
                    notchanged=false;
                    openchildform(new Booking());
                }
               // string constring = "server=localhost;uid=root;pwd=7861;database=sample";
               // MySqlConnection conn = new MySqlConnection(constring);
               // conn.Open();
                //MySqlCommand cmd = new MySqlCommand("INSERT INTO booking VALUES ('"+Check_in.Text+"','"+Check_out.Text+"',"+adult1+","+child1+")", conn);
                
               // cmd.ExecuteNonQuery();

               // MessageBox.Show("Reserved", "Successfull");

                //conn.Close();

            }




        }

        private void Check_out_ValueChanged(object sender, EventArgs e)
        {

        }

        private void namepanel_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void childpanel_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void navbar_Click(object sender, EventArgs e)
        {

        }
    }
}
