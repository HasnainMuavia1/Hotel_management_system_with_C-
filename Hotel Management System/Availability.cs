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

namespace Hotel_Management_System
{
    public partial class Availability : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public Availability()
        {
            InitializeComponent();
            InitializeDatabase();
        }
        private void InitializeDatabase()
        {
            string connectionString = "server=localhost;uid=root;pwd=7861;database=sample";
            connection = new MySqlConnection(connectionString);
            dataAdapter = new MySqlDataAdapter("select * from room ", connection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            grid.DataSource = dataTable;
        }
        private void SaveChanges()
        {
            dataAdapter.Update(dataTable);

        }
        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Availability_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChanges();
            connection.Close();
        }

        private void grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SaveChanges();
           
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Availability_Load(object sender, EventArgs e)
        {

        }
    }
}
