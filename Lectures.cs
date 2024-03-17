using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectricReg.Models;
using ElectricReg.Repository;
using MySqlConnector;
using Supabase.Gotrue;

namespace ElectricReg
{
    public partial class Lectures : Form
    {
        public Lectures()
        {
            InitializeComponent();
            PopulateModules();
        }
        LecturerRepository repository = new LecturerRepository();
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
                var data = await repository.getStudents(DateTime.UtcNow);

                DataTable studentTable = new DataTable();
                studentTable.Columns.Add("Id");
                studentTable.Columns.Add("StudentID");
                studentTable.Columns.Add("CreatedAt");
                studentTable.Columns.Remove("BaseUrl");

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
                var data = await repository.getStudents(DateTime.UtcNow);
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

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                try
                {
                    List<RegisterModel> students = await repository.getStudent(searchText);

                    if (students.Count > 0)
                    {
                        // Assuming you want to display the first student found
                        DataTable studentTable = new DataTable();
                        studentTable.Columns.Add("id");
                        studentTable.Columns.Add("StudentID");
                        studentTable.Columns.Add("CreatedAt");

                        // Adding rows to the DataTable
                        foreach (var student in students)
                        {
                            studentTable.Rows.Add(student.Id, student.StudentID, student.CreatedAt);
                        }

                        dataGridViewStudents.DataSource = studentTable;
                    }
                    else
                    {
                        MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    textBoxSearch.Text = searchText;
                }
                catch (Exception error)
                {
                    MessageBox.Show("An error occurred: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter search details.", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void btnMA_Click(object sender, EventArgs e)
        {

            try
            {
                List<RegisterModel> students = await repository.getMostAttendantStudents();

                UpdateDataGridView(students);
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occurred: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAA_Click(object sender, EventArgs e)
        {
            try
            {
                List<RegisterModel> students = await repository.getAverageAttendantStudents();

                UpdateDataGridView(students);
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occurred: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnPA_Click(object sender, EventArgs e)
        {
            try
            {
                List<RegisterModel> students = await repository.getPoorAttendantStudents();

                UpdateDataGridView(students);
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occurred: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnNA_Click(object sender, EventArgs e)
        {
            try
            {
                List<RegisterModel> students = await repository.getNeverAttendedStudents();

                UpdateDataGridView(students);
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occurred: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UpdateDataGridView(List<RegisterModel> students)
        {
            if (students.Count > 0)
            {
                DataTable studentTable = new DataTable();
                studentTable.Columns.Add("ID");
                studentTable.Columns.Add("StudentID");
                studentTable.Columns.Add("CreatedAt");

                foreach (var student in students)
                {
                    studentTable.Rows.Add(student.Id, student.StudentID, student.CreatedAt);
                }

                dataGridViewStudents.DataSource = studentTable;
            }
            else
            {
                MessageBox.Show("No students found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private async void refreshIcon_Click(object sender, EventArgs e)
        {
            try
            {
                var data = await repository.getStudents(DateTime.UtcNow);
                DataTable studentTable = new DataTable();

                dataGridViewStudents.DataSource = data;
            }
            catch (Exception error)
            {
                // Handle the exception in a user-friendly way, e.g., displaying a message box
                MessageBox.Show("Error: Unable to convert date/time value to System.DateTime. Please check the data in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // You can also log the error or perform other actions here as needed
            }
            textBoxSearch.Text = "";
            textBoxStudentName.Text = "";
            textBoxStudentID.Text = "";
            pictureBoxprofile.Refresh();
        }

        private async Task LoadImageFromUrlAsync(string imageUrl, PictureBox pictureBox)
        {
            using (HttpClient client = new HttpClient())
            {
                // Get the image data as a stream
                Stream stream = await client.GetStreamAsync(imageUrl);

                // Create an Image object from the stream
                Image image = Image.FromStream(stream);

                // Set the PictureBox's Image property to this image
                pictureBox.Image = image;
            }
        }

        private async void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string studentID = dataGridViewStudents.Rows[e.RowIndex].Cells[1].Value.ToString();


            Console.WriteLine(dataGridViewStudents.Rows[e.RowIndex].Cells[1].Value.ToString());

            try
            {
                var data = await repository.getStudentByID(studentID);
                Console.WriteLine(data);
                textBoxStudentName.Text = data.StudnetName;
                textBoxStudentID.Text = data.StudentID;
                
                await LoadImageFromUrlAsync(data.AvatarUrl, pictureBoxprofile);

            }
            catch (Exception error)
            {
                // Handle the exception in a user-friendly way, e.g., displaying a message box
                MessageBox.Show("Error: Unable to convert date/time value to System.DateTime. Please check the data in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // You can also log the error or perform other actions here as needed
            }

            pictureBoxprofile.Refresh();

        }
    }
}
