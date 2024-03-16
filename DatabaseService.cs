using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Supabase;
using System.Security.Policy;


namespace ElectricReg
{
    public class DatabaseService
    {
        private static string url = "https://csqaiejkcporxddqwans.supabase.co";
        private static string key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImNzcWFpZWprY3BvcnhkZHF3YW5zIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MDUwNDc2OTEsImV4cCI6MjAyMDYyMzY5MX0.zAws4FCnjfEaPJZJ-iNAAX0LlkqZS6F0xVfxvNM9zdU";

        

        private static SupabaseOptions options = new Supabase.SupabaseOptions
        {
            AutoConnectRealtime = true
        };

        private Client supabase = new Supabase.Client(url, key, options);

        //Init Supabase
        public async void initSupabase()
        {
                await supabase.InitializeAsync();
        }

        public Client getClient {
            get
            {
                return supabase;
            }
        
        }



    }
}
