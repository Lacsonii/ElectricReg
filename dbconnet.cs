using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ElectricReg
{
    public class dbconnet
    {
        //Init Supabase
        public async void initSupabase()
        {
            var url = Environment.GetEnvironmentVariable("SUPABASE_URL");
            var key = Environment.GetEnvironmentVariable("SUPABASE_KEY");

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            var supabase = new Supabase.Client(url, key, options);
            await supabase.InitializeAsync();

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }



        MySqlConnection connection = new MySqlConnection("Server = http://aws-0-eu-central-1.pooler.supabase.com; userID = postgres.csqaiejkcporxddqwans; password = UKFiSAiIKkAjjFoi; Port = 5432; database = postgres");

        public MySqlConnection getconnection()
        {
            return connection;
        }

        public void openconnect()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeconnect()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

        }

    }
}
