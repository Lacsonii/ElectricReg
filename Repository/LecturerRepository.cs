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
using ElectricReg.Models.ElectricReg.Models;

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

        // Example method to retrieve students by ID
        public async Task<List<RegisterModel>> getStudentByID(int studentId)
        {
            // Implement your logic to retrieve students by ID
            throw new NotImplementedException();
        }
    }

}
    

