using MySql.Data.MySqlClient;
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
    public partial class Staff : Form
    {
       
        public Staff()
        {
            InitializeComponent();
            

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
        public int id;
        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=7861;database=sample";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select Us_id,Name,email,password,Role from credentials", conn);

            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            grid.DataSource = dt;
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
        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {

        }

        private void AddBooking_Click(object sender, EventArgs e)
        {
            openchildform(new AddUser());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
         
            string constring = "server=localhost;uid=root;pwd=7861;database=sample";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            MySqlCommand cmd2 = new MySqlCommand("Delete from credentials where Us_id="+id+"", conn);
            cmd2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfull!", "deleted");
            Staff_Load(null, null);

        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sid = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["Us_id"].Value);
            id = sid;
           

        }
    }
}
