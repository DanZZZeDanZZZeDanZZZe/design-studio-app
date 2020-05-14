using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static DataTable getTableField(string tableName, string fieldName)
        {
            CreateSqlCommand("getTableField");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@tableName", SqlDbType.NVarChar).Value = tableName;
            command.Parameters.Add("@fieldName", SqlDbType.NVarChar).Value = fieldName;
            reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        public static DataTable getTeamsWithouOrders()
        {
            CreateSqlCommand("getTeamsWithouOrders");
            command.CommandType = CommandType.StoredProcedure;
            reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        public static DataTable getProductsByID(int ID, int param)
        {
            CreateSqlCommand("getProductsByID");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID;
            command.Parameters.Add("@param", SqlDbType.NVarChar).Value = param;
            reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        public static int IndividualsDelete(int id)
        {
            CreateSqlCommand("deleteIndividuals");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@returnCode", SqlDbType.Int);
            command.Parameters["@returnCode"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            int returnCode = int.Parse(command.Parameters["@returnCode"].Value.ToString());
            return returnCode;
        }

        public static int deleteByID(int id, string tableName)
        {
            CreateSqlCommand("deleteByID");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@tableName", SqlDbType.NVarChar).Value = tableName;
            command.Parameters.Add("@returnCode", SqlDbType.Int);
            command.Parameters["@returnCode"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            int returnCode = int.Parse(command.Parameters["@returnCode"].Value.ToString());
            return returnCode;
        }

        public static int checkByID(int id, string tableName)
        {
            CreateSqlCommand("checkID");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@tableName", SqlDbType.NVarChar).Value = tableName;
            command.Parameters.Add("@returnCode", SqlDbType.Int);
            command.Parameters["@returnCode"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            int returnCode = int.Parse(command.Parameters["@returnCode"].Value.ToString());
            return returnCode;
        }

        public static void addDevelopmentTeams(int id, int teamLeaders, string datetime)
        {
            CreateSqlCommand("addDevelopmentTeams");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@teamLeaders", SqlDbType.Int).Value = teamLeaders;
            command.Parameters.Add("@dateOfFormation", SqlDbType.DateTime2).Value = datetime;
            command.ExecuteNonQuery();
        }

        public static void addInternalOrders(int id, string datetime)
        {
            CreateSqlCommand("addInternalOrders");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@dateOfFormation", SqlDbType.DateTime2).Value = datetime;
            command.ExecuteNonQuery();
        }

        public static void addExternalOrders(int id, string datetime, string deadline, int customersID)
        {
            CreateSqlCommand("addExternalOrders");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@dateOfFormation", SqlDbType.DateTime2).Value = datetime;
            command.Parameters.Add("@deadline", SqlDbType.DateTime2).Value = deadline;
            command.Parameters.Add("@customersID", SqlDbType.Int).Value = customersID;
            command.ExecuteNonQuery();
        }

        public static void addLegalEntities(int id, string name, float inn)
        {
            CreateSqlCommand("addLegalEntities");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@inn", SqlDbType.Float).Value = inn;

            command.ExecuteNonQuery();
        }

        public static void addIndividualas(int id, float passportID, string name, string suname, string patronymic, float phoneNumber)
        {
            CreateSqlCommand("addIndividualas");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@passportID", SqlDbType.Float).Value = passportID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@suname", SqlDbType.NVarChar).Value = suname;
            command.Parameters.Add("@patronymic", SqlDbType.NVarChar).Value = patronymic;
            command.Parameters.Add("@phoneNumber", SqlDbType.Float).Value = phoneNumber;
            command.ExecuteNonQuery();
        }

        public static void addFonts(int id, bool serif, string mark, string width, bool bold, bool updateStatus)
        {
            string tableName = Helper.checkUpdateStatus(updateStatus, "addFonts", "updateFontsByID");

            CreateSqlCommand(tableName);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@serif", SqlDbType.Bit).Value = serif;
            command.Parameters.Add("@mark", SqlDbType.NVarChar).Value = mark;
            command.Parameters.Add("@width", SqlDbType.NVarChar).Value = width;
            command.Parameters.Add("@bold", SqlDbType.Bit).Value = bold;

            command.ExecuteNonQuery();
        }

        public static void addLogos(int id, string imageLink, string description, string text, bool updateStatus)
        {
            string tableName = Helper.checkUpdateStatus(updateStatus, "addLogos", "updateLogosByID");

            CreateSqlCommand(tableName);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@imageLink", SqlDbType.NVarChar).Value = imageLink;
            command.Parameters.Add("@description", SqlDbType.Text).Value = description;
            command.Parameters.Add("@text", SqlDbType.NVarChar).Value = text;

            command.ExecuteNonQuery();
        }
        public static void addCups(int id, string color, int volume, bool updateStatus)
        {
            string tableName = Helper.checkUpdateStatus(updateStatus, "addCups", "updateCupsByID");

            CreateSqlCommand(tableName);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@color", SqlDbType.NVarChar).Value = color;
            command.Parameters.Add("@volume", SqlDbType.NVarChar).Value = volume;

            command.ExecuteNonQuery();
        }

        public static void addClothes(int id, string type, string color, string size, string text, bool updateStatus)
        {
            string tableName = Helper.checkUpdateStatus(updateStatus, "addClothes", "updateClothesByID");

            CreateSqlCommand(tableName);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            command.Parameters.Add("@color", SqlDbType.NVarChar).Value = color;
            command.Parameters.Add("@size", SqlDbType.NVarChar).Value = size;
            command.Parameters.Add("@text", SqlDbType.NVarChar).Value = text;

            command.ExecuteNonQuery();
        }

        public static void addCovers(int id, string type, string color, string model, bool updateStatus)
        {
            string tableName = Helper.checkUpdateStatus(updateStatus, "addCovers", "updateCoversByID");

            CreateSqlCommand(tableName);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            command.Parameters.Add("@color", SqlDbType.NVarChar).Value = color;
            command.Parameters.Add("@model", SqlDbType.NVarChar).Value = model;

            command.ExecuteNonQuery();
        }

        public static int checkDevelopmentTeamID(int id)
        {
            CreateSqlCommand("checkDevelopmentTeamID");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@returnCode", SqlDbType.Int);
            command.Parameters["@returnCode"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            int returnCode = int.Parse(command.Parameters["@returnCode"].Value.ToString());
            return returnCode;
        }

        public static int checkOrdersID(int id)
        {
            CreateSqlCommand("checkOrdersID");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@returnCode", SqlDbType.Int);
            command.Parameters["@returnCode"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            int returnCode = int.Parse(command.Parameters["@returnCode"].Value.ToString());
            return returnCode;
        }

        public static DataTable LoadAllDataFromTable(string name)
        {
            return LoadDataTableFromQuery("SELECT * FROM [" + name + "]");
        }

        public static DataTable LoadAllDataFromSP(string sp)
        {
            CreateSqlCommand(sp);
            command.CommandType = CommandType.StoredProcedure;
            reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        public static void GenerateGrid(DataGridView grid, string name)
        {
            DataTable dt = DatabaseAPI.LoadAllDataFromTable(name);
            grid.DataSource = dt;
            grid.Update();
        }

        public static void GenerateGrid(DataGridView grid, string name, bool spMode)
        {
            if (spMode == true)
            {
                grid.DataSource = LoadAllDataFromSP(name);
                grid.Update();
            } else
            {
                GenerateGrid(grid, name);
            }
        }

        public static void deleteOrderById(int id)
        {
            CreateSqlCommand("deleteOrderById");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;

            command.ExecuteNonQuery();
        }

        public static void sendToTheTeam(int PN, int ID)
        {
            CreateSqlCommand("sendToTheTeam");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@teamId", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@PN", SqlDbType.Int).Value = PN;

            command.ExecuteNonQuery();
        }

        public static void markExOrder(int ID, int sum)
        {
            CreateSqlCommand("markExOrder");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@sum", SqlDbType.Int).Value = sum;

            command.ExecuteNonQuery();
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
