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
using ElectricReg.Repository;
using MySqlConnector;

namespace ElectricReg
{
    public partial class Lectures : Form
    {
        public Lectures()
        {
            InitializeComponent();
            PopulateModules();
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

        private async void Lectures_method()
        {
             try
             {
                LecturerRepository repository = new LecturerRepository();
                var  data = await repository.getStudents(DateTime.UtcNow);
                DataTable studentTable = new DataTable();

                dataGridViewStudents.DataSource = data;
             }
             catch (Exception error)
             {
                // Handle the exception in a user-friendly way, e.g., displaying a message box
                MessageBox.Show("Error: Unable to convert date/time value to System.DateTime. Please check the data in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // You can also log the error or perform other actions here as needed
             }
        }

        private async void Lectures_Load(object sender, EventArgs e)
        {
            try
            {
                LecturerRepository repository = new LecturerRepository();
                var  data = await repository.getStudents(DateTime.UtcNow);
                DataTable studentTable = new DataTable();

                dataGridViewStudents.DataSource = data;
            }
            catch (Exception error)
            {
                // Handle the exception in a user-friendly way, e.g., displaying a message box
                MessageBox.Show("Error: Unable to convert date/time value to System.DateTime. Please check the data in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // You can also log the error or perform other actions here as needed
            }
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lecturer lecturer = new Lecturer();
            lecturer.ShowDialog();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
