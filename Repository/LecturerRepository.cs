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
        public async Task<List<RegisterModel>> getMostAttendantStudents()
        {
            // Implement your logic to retrieve students with most attendance
            throw new NotImplementedException();
        }

        public async Task<List<RegisterModel>> getAverageAttendantStudents()
        {
            // Implement your logic to retrieve students with average attendance
            throw new NotImplementedException();
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

        public async Task<string> getProfilePicture(string Image)
        {
            try
            {
                int timeexp = 60;
                string Url = await DatabaseService.getClient.Storage.From("uploads").CreateSignedUrl("public/"+Image, timeexp);
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
                var results = await DatabaseService.getClient.From<ProfileModel>().Select(column => new object[] { column.StudentID, column.UpdatedAt, column.StudnetName, column.AvatarUrl}).Where(row => row.StudentID == StudentID).Get();

                var student = results.Model;

                Console.WriteLine(results.Model.AvatarUrl.ToString());

               
                return student;

            }
            catch (Exception error)
            {

                throw;
            }
        }
    }

}
    

