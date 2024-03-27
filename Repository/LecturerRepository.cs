using ElectricReg.Models;
using Postgrest;
using Supabase.Gotrue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static Postgrest.QueryOptions;
using System.Reflection;
using ElectricReg.Models;
using System.Security.Policy;
using Supabase.Interfaces;
using System.Windows.Forms;

namespace ElectricReg.Repository
{
    internal class LecturerRepository
    {
        public LecturerRepository()
        {
        }

        DatabaseService DatabaseService = new DatabaseService();

        public async Task<List<RegisterModel>> getStudents(DateTime date)
        {
            try
            {
                var results = await DatabaseService.getClient.From<RegisterModel>().Get();

                var students = results.Models;




                return students;

            }
            catch (Exception error)
            {

                throw;
            }

        }
        public async Task<List<RegisterModel>> getStudent(String StudentID)
        {
            try
            {
                var results = await DatabaseService.getClient.From<RegisterModel>().Select(column => new object[] { column.StudentID, column.CreatedAt }).Where(row => row.StudentID == StudentID).Get();

                var students = results.Models;




                return students;

            }
            catch (Exception error)
            {

                throw;
            }
        }
      

        public async void getAverageAttendantStudents()
        {

            try
            {

                var listOfStudents = await DatabaseService.getClient
                  .From<RegisterModel>()
                  .Select(column => new object[] { column.StudentID, column.Id }).Get();

                var students = listOfStudents.Models;

                var data = students.GroupBy(record => record.StudentID);

                foreach ( var item in data)
                {
                    var values = item.Select(x => x.StudentID == item.Key).Count();

                    Console.WriteLine(item.Key + " " + values);

                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error retrieving average attendant students: " + error.Message);
                throw; // Rethrow the exception to propagate it to the caller
            }

        }

        public async Task<List<RegisterModel>> getPoorAttendantStudents()
        {
            // Implement your logic to retrieve students with poor attendance
            throw new NotImplementedException();
        }

        public async Task<List<RegisterModel>> getNeverAttendedStudents()
        {
            // Implement your logic to retrieve students who never attended
            throw new NotImplementedException();
        }

        // Example method to retrieve students by ID
        public async Task<List<RegisterModel>> getStudentByID(int studentId)
        {
            // Implement your logic to retrieve students by ID
            throw new NotImplementedException();
        }


        public async Task<string> getProfilePicture(string Image)
        {
            try
            {
                int timeexp = 60;
                string Url = await DatabaseService.getClient.Storage.From("uploads").CreateSignedUrl("public/" + Image, timeexp);
                Console.WriteLine(Url);
                return Url;


            }
            catch (Exception error)
            {

                throw;
            }


        }
        public async Task<ProfileModel> getStudentByID(string StudentID)
        {
            try
            {
                var results = await DatabaseService.getClient.From<ProfileModel>().Select(column => new object[] { column.StudentID, column.UpdatedAt, column.StudnetName, column.AvatarUrl }).Where(row => row.StudentID == StudentID).Get();

                var student = results.Model;


                return student;

            }
            catch (Exception error)
            {

                throw;
            }
        }
        private async void FilterByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                // Construct SQL query to select rows within the specified date range
                string query = @"
                    SELECT *
                    FROM RegisterModel
                    WHERE CreatedAt >= @StartDate AND CreatedAt <= @EndDate;
                ";

                // Execute query with parameters
                var response = await DatabaseService.getClient.From<RegisterModel>()
                    .Get();
                // Convert response to List<RegisterModel>
                List<RegisterModel> filteredRows = new List<RegisterModel>();
                /*foreach (var row in response.Data.Rows)
                {
                    // Assuming RegisterModel has a constructor that accepts the row data
                    RegisterModel model = new RegisterModel
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        // Map other properties accordingly
                    };
                    filteredRows.Add(model);
                }*/

                // Update your UI with the filtered rows
                //UpdateDataGridView(filteredRows);
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occurred: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}


