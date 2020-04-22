﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStudio
{
    class DatabaseAPI
    {
        public static string serverName = ConfigurationManager.ConnectionStrings["ServerName"].ConnectionString;
        public static string dbName = ConfigurationManager.ConnectionStrings["DBName"].ConnectionString;
        public static string settings = ConfigurationManager.ConnectionStrings["Settings"].ConnectionString;

        public static string connectionString;
        public static SqlConnection connection;

        public static SqlCommand command;
        public static SqlDataReader reader;
      //  public static List<string[]> data;
       // public static DataTable dataTable;
        public static void CreateConnectionString()
        {
            connectionString = serverName + dbName + settings;
        }

        public static void CreateConnection()
        {
            CreateConnectionString();
            connection = new SqlConnection(connectionString);
        }

        public static void ConnectionOpen()
        {
            connection.Open();
        }

        public static void ConnectionClose()
        {
            connection.Close();
        }

        public static void CreateSqlCommand(string query)
        {
            command = new SqlCommand(query, connection);
        }
        public static void CreateReader(string query)
        {
            CreateSqlCommand(query);
            reader = command.ExecuteReader();
        }
        
        public static DataTable LoadDataTableFromQuery(string query)
        {
            DataTable dataTable = new DataTable();
            CreateReader(query);
            dataTable.Load(reader);
            return dataTable;
        }

        public static DataTable LoadAllDataFromTable(string name)
        {
            return LoadDataTableFromQuery("SELECT * FROM " + name);
        }

        /*  public List<string[]> LoadData(string query)
          {

              CreateReader(query);
              Console.WriteLine(reader.ToString(), command.ToString());
              data = new List<string[]>();

              while (reader.Read())
              {

                  data.Add(new string[3]);
                  data[data.Count - 1][0] = reader[0].ToString();
                  data[data.Count - 1][1] = reader[1].ToString();
                  data[data.Count - 1][2] = reader[2].ToString();
              }

              reader.Close();
              return data;
              /*foreach (string[] s in data)
                  dataGridView1.Rows.Add(s);*/

    }
}
