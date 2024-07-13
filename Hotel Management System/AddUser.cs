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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management_System
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void signin_Click(object sender, EventArgs e)
        {
            //not allowing duplicate username
            string constring = "server=localhost;uid=root;pwd=7861;database=sample";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from credentials where email = '" + Email.Text + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                MessageBox.Show("Duplicate Entry", "ALready enrolled");
            }else
            {
                reader.Close();
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO credentials (email,Name,password,Role) Values ('"+Email.Text+"','"+Name.Text+"','"+Password.Text+"','"+Role.Text+"')", con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("SuccessFull" ,"Added");

            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
