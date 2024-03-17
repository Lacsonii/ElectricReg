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
        public async Task<List<string>> GetMostAttendantStudents()
        {
            try
            {
                // Retrieve all records from the RegisterModel
                var allRecords = await DatabaseService.getClient
                    .From<RegisterModel>()
                    .Get();

                // Group by StudentID and count the number of records for each student
                var groupedRecords = allRecords
                    .GroupBy(record => record.StudentID)
                    .Select(group => new { StudentID = group.Key, Count = group.Count() });

                // Sort by count in descending order and take the top 5 most attended students
                var mostAttendantStudents = groupedRecords
                    .OrderByDescending(group => group.Count)
                    .Take(5)
                    .Select(group => group.StudentID)
                    .ToList();

                return mostAttendantStudents;
            }
            catch (Exception error)
            {
                Console.WriteLine("Error retrieving most attendant students: " + error.Message);
                throw; // Rethrow the exception to propagate it to the caller
            }
        }

        public async Task<List<string>> GetAverageAttendantStudents()
        {
            try
            {
                // Retrieve all records from the RegisterModel
                var allRecords = await DatabaseService.getClient
                    .From<RegisterModel>()
                    .Get();

                // Group by StudentID and count the number of records for each student
                var groupedRecords = allRecords
                    .GroupBy(record => record.StudentID)
                    .Select(group => new { StudentID = group.Key, Count = group.Count() });

                // Sort by count and take 5 students from the middle of the list
                var averageAttendantStudents = groupedRecords
                    .OrderBy(group => group.Count)
                    .Skip(groupedRecords.Count() / 2)
                    .Take(5)
                    .Select(group => group.StudentID)
                    .ToList();

                return averageAttendantStudents;
            }
            catch (Exception error)
            {
                Console.WriteLine("Error retrieving average attendant students: " + error.Message);
                throw; // Rethrow the exception to propagate it to the caller
            }
        }

        // Implement similar methods for getPoorAttendantStudents and getNeverAttendedStudents


        public async Task<List<RegisterModel>> getNeverAttendedStudents()
        {
            try
            {
                // Retrieve students with attendance count equal to 0
                var results = await DatabaseService.getClient
                    .From<RegisterModel>()
                    .Where(row => row.AttendanceCount == 0)
                    .Get();

                return results.Models;
            }
            catch (Exception error)
            {
                Console.WriteLine("Error retrieving never attended students: " + error.Message);
                throw; // Rethrow the exception to propagate it to the caller
            }
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
    }

}


