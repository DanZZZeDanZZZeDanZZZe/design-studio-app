using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStudio
{
    class DatabaseAPI
    {
        public string serverName = ConfigurationManager.ConnectionStrings["ServerName"].ConnectionString;
        public string dbName = ConfigurationManager.ConnectionStrings["DBName"].ConnectionString;
        public string settings = ConfigurationManager.ConnectionStrings["Settings"].ConnectionString;

        public string connectionString;
        public SqlConnection connection;
 
        public void CreateConnectionString()
        {
            connectionString = serverName + dbName + settings;
        }

        public void CreateConnection()
        {
            CreateConnectionString();
            connection = new SqlConnection(connectionString);
        }

        public SqlCommand CreateSqlCommand(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            return command;
        }
        public SqlDataReader CreateReader(string query)
        {
            SqlCommand command = CreateSqlCommand(query);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        
        public void ConnectionOpen()
        {
            connection.Open();
        }

        public void ConnectionClose()
        {
            connection.Close();
        }
        public List<string[]> LoadData(string query)
        {
           // connection.Open();

            //string query = "SELECT * FROM Faculty ORDER BY fac_id";

            // SqlCommand command = new SqlCommand(query, connection);

            // SqlDataReader reader = command.ExecuteReader();

            SqlDataReader reader = CreateReader(query);

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            connection.Close();
            return data;
            /*foreach (string[] s in data)
                dataGridView1.Rows.Add(s);*/
        }
    }
}
