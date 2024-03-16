using ElectricReg.Models;
using Postgrest;
using Supabase.Gotrue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

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
                var results = await DatabaseService.getClient.From<RegisterModel>().Select(row => new object[] { row.Id, row.StudentID }).Where(row => row.CreatedAt == date.ToUniversalTime()).Get();

                var students = results.Models;




                return students;

            }
            catch (Exception error)
            {

                throw;
            }
        }

    }
}
