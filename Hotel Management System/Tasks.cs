using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Tasks : Form
    {
        private MySqlConnection connection;
        private DataSet dataSet;
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public Tasks()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            string connectionString = "server=localhost;uid=root;pwd=7861;database=sample";
            connection = new MySqlConnection(connectionString);

            dataTable = new DataTable();

            string selectQuery = "SELECT Us_id, Name, Task, Schedule, room_id " +
                                 "FROM credentials " +
                                 "LEFT JOIN Tasks USING (Us_id) " +
                                 "LEFT JOIN room USING (room_id) " +
                                 "WHERE Role='Housekeeping Staff'";

            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectCommand);

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

            dataAdapter.Fill(dataTable);

            grid.DataSource = dataTable;

            FormClosing += Tasks_FormClosing;
        }

       

        private void SaveChanges()
        {
            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter())
            {
                dataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM Tasks", connection);
                                                     
                 MySqlCommand insertCommand = new MySqlCommand(
                 "INSERT INTO Tasks (Task, Schedule, room_id) " +
                 "VALUES (@Task, @Schedule, @Room_id)",
                 connection);

                insertCommand.Parameters.Add("@Task", MySqlDbType.VarChar, 30, "Task");
                insertCommand.Parameters.Add("@Schedule", MySqlDbType.Time, 0, "Schedule");
                insertCommand.Parameters.Add("@Room_id", MySqlDbType.Int32, 11, "room_id");

                dataAdapter.InsertCommand = insertCommand;

                
            }
        }

        private void Tasks_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChanges();
            connection.Close();
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Only save changes if the cell value is changed and not a new row
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                SaveChanges();
        }

        private void Tasks_Load(object sender, EventArgs e)
        {

        }
    }
}
