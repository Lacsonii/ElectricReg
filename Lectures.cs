using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace ElectricReg
{
    public partial class Lectures : Form
    {
        MySqlConnection connection;
        public Lectures()
        {
            InitializeComponent();
            PopulateModules();
            connection = new MySqlConnection();
            connection.ConnectionString = "Server = http://aws-0-eu-central-1.pooler.supabase.com; userID = postgres.csqaiejkcporxddqwans; password = UKFiSAiIKkAjjFoi; Port = 5432; database = postgres";

        }

        private void PopulateModules()
        {
            string[] program = { "DDW", "UBO", "DDOOCP", "CN", "CS", "DBMS", "EBU", "OSD" };

            comboBoxPrograms.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxPrograms.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Bind the array of gender to the ComboBox.
            comboBoxPrograms.Items.AddRange(program);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
        private void Lectures_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connect = new MySqlConnection("Server = http://aws-0-eu-central-1.pooler.supabase.com; userID = postgres.csqaiejkcporxddqwans; password = UKFiSAiIKkAjjFoi; Port = 5432; database = postgres");
                MySqlDataAdapter MDA = new MySqlDataAdapter("Select * from  ", connect);
                DataTable Dt = new DataTable();
                MDA.Fill(Dt);
                dataGridViewStudents.DataSource = Dt;
                DataGridViewCheckBoxColumn Select = new DataGridViewCheckBoxColumn();
                Select.HeaderText = "Select";
                dataGridViewStudents.Columns.Insert(0, Select);

            }
            catch (MySqlConversionException)
            {
                // Handle the exception in a user-friendly way, e.g., displaying a message box
                MessageBox.Show("Error: Unable to convert date/time value to System.DateTime. Please check the data in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // You can also log the error or perform other actions here as needed
            }
        }
    }
}
