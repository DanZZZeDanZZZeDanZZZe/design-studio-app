using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignStudio
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        bool flagConnectionButton = true;
        public SqlConnection con;
        public List<string[]> CurrentData;
        /*  public DataSet ds;
          SqlDataAdapter sqlDataAdapter;*/

        bool ContactTheDB(bool flag)
        {
            
            bool chekintConnection;

            // con = new SqlConnection(connectionString);
            /*sqlDataAdapter = new SqlDataAdapter("SELECT * FROM fonts", con);
            ds = new DataSet();*/
            DatabaseAPI.CreateConnection();

            try
            {
                if (flag)
                {
                    // con.Open();
                    DatabaseAPI.ConnectionOpen();
                    MessageBox.Show("База данных подключена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillGrids();
                }
                else
                {
                    DatabaseAPI.ConnectionClose();
                    MessageBox.Show("База данных отключена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                chekintConnection = true;

            }
            catch (SqlException ex)
            {
                string title;

                switch (ex.Number)
                {
                    case -1:
                        title = "Неверное имя сервера";
                        break;
                    case 4060:
                        title = "Неверное название базы данных";
                        break;
                    case 18456:
                        title = "Неверное имя пользователя или пароль";
                        break;
                    default:
                        title = "Ошибка";
                        break;
                }

                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                chekintConnection = false;
            }

            return chekintConnection;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            SetEnableButtons();
            if (flagConnectionButton)
            {
                connectButton.Text = "Отключить";
            }
            else
            {
                connectButton.Text = "Подключить";
            }

            ContactTheDB(flagConnectionButton);
            SetEnableButtons();
            flagConnectionButton = !flagConnectionButton;
        }

        private void SetEnableButtons()
        {
            connectButton.Enabled = !connectButton.Enabled;
            settingButton.Enabled = !settingButton.Enabled;
        }
        private void settingButton_Click(object sender, EventArgs e)
        {
            ConnectionSetupForm DialogF = new ConnectionSetupForm(this);
            DialogF.ShowDialog();
        }

        public void FillGrids()
        {
            DatabaseAPI.GenerateGrid(fontsDataGrid, "fonts");
            DatabaseAPI.GenerateGrid(logosDataGrid, "logos");
            DatabaseAPI.GenerateGrid(individualsDataGrid, "individuals");
            DatabaseAPI.GenerateGrid(legalEntitiesDataGrid, "legal entities");
            DatabaseAPI.GenerateGrid(externalOrdersDataGrid, "external orders");
            DatabaseAPI.GenerateGrid(internalOrdersDataGrid, "internal orders");
            DatabaseAPI.GenerateGrid(developmentTeamsDataGrid, "development teams");
            DatabaseAPI.GenerateGrid(designersDataGrid, "designers");
            DatabaseAPI.GenerateGrid(employeesDataGrid, "employees");
            DatabaseAPI.GenerateGrid(clothesDataGrid, "clothes");
            DatabaseAPI.GenerateGrid(circlesDataGrid, "circles");
            DatabaseAPI.GenerateGrid(coversDataGrid, "covers");
        }

        private void individualsDeleteButton_Click(object sender, EventArgs e)
        {
            int id = Helper.getDataGridSelectedKey(individualsDataGrid, 0);
            MessageBox.Show(id.ToString());
            int code = DatabaseAPI.IndividualsDelete(id);
            DatabaseAPI.GenerateGrid(individualsDataGrid, "individuals");
            switch (code)
            {
                case 0:
                    MessageBox.Show("deleted item with key " + id.ToString());
                    break;
                case 1:
                    MessageBox.Show("Item does not exist", "Error message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Item has related records", "Error message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
