using Postgrest;
using Supabase.Gotrue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricReg.Repository
{
    internal class AuthRepository
    {
        public AuthRepository() {
        }

        DatabaseService DatabaseService = new DatabaseService();

        public async Task<Session> SignIn(String email, String password) {
          try {
                var session = await DatabaseService.getClient.Auth.SignIn(email, password);

                Console.WriteLine(session.User.Email);
                return session;

            } catch (Exception error){

                throw;
            }
        }

    }
}
