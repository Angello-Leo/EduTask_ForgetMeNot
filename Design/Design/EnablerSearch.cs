using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    public class EnablerSearch : Search
    {
        private string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";
        public override List<string> AlphabeticalSearch()
        {
            var list = new List<string>();

            using (var conn = new MySqlConnection(conString))
            {
                conn.Open();
                string query = "SELECT name FROM enablers ORDER BY name ASC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                    }
                }
            }
            return list;
        }

        public override List<string> DateSearch()
        {
            var list = new List<string>();

            using (var conn = new MySqlConnection(conString))
            {
                conn.Open();
                string query = "SELECT name FROM enablers ORDER BY created_at ASC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                    }
                }
            }
            return list;
        }

        public override List<string> ReverseAlphabeticalSearch()
        {
            var list = new List<string>();

            using (var conn = new MySqlConnection(conString))
            {
                conn.Open();
                string query = "SELECT name FROM enablers ORDER BY name DESC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                    }
                }
            }
            return list;
        }
    }
}
