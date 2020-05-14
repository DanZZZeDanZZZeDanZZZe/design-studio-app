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
           /* DatabaseAPI.GenerateGrid(fontsDataGrid, "fonts");
            DatabaseAPI.GenerateGrid(logosDataGrid, "logos");*/
            DatabaseAPI.GenerateGrid(individualsDataGrid, "individuals");
            DatabaseAPI.GenerateGrid(legalEntitiesDataGrid, "legal entities");
            renderExOrders(externalOrdersDataGrid, "external orders");
            DatabaseAPI.GenerateGrid(internalOrdersDataGrid, "internal orders");
            DatabaseAPI.GenerateGrid(developmentTeamsDataGrid, "development teams");
            DatabaseAPI.GenerateGrid(designersDataGrid, "designers");
            DatabaseAPI.GenerateGrid(employeesDataGrid, "employees");
          /*  DatabaseAPI.GenerateGrid(clothesDataGrid, "clothes");
            DatabaseAPI.GenerateGrid(circlesDataGrid, "circles");
            DatabaseAPI.GenerateGrid(coversDataGrid, "covers");*/
        }

        private void individualsDeleteButton_Click(object sender, EventArgs e)
        {
            int id = Helper.getDataGridSelectedKey(individualsDataGrid, 0);
            int code = DatabaseAPI.IndividualsDelete(id);
            DatabaseAPI.GenerateGrid(individualsDataGrid, "individuals");
            Helper.callDeleteMessage(code, id);
        }

        private void developmentTeamsAddButton_Click(object sender, EventArgs e)
        {
            AddDevelopmentTeam addDevelopmentTeam = new AddDevelopmentTeam(this);
            addDevelopmentTeam.ShowDialog();
        }

        private void internalOrdersAddButton_Click(object sender, EventArgs e)
        {
            AddInternalOrders addInternalOrders = new AddInternalOrders(this);
            addInternalOrders.ShowDialog();
        }

        private void legalEntitiesDeleteButton_Click(object sender, EventArgs e)
        {
            Helper.generateDelete(legalEntitiesDataGrid, "legal entities", "customers");
        }

        private void internalOrdersDeleteButton_Click(object sender, EventArgs e)
        {
            Helper.generateDelete(internalOrdersDataGrid, "internal orders", "orders");
        }

        private void developmentTeamsDeleteButton_Click(object sender, EventArgs e)
        {
            Helper.generateDelete(developmentTeamsDataGrid, "development Teams");
        }

        private void legalEntitiesAddButton_Click(object sender, EventArgs e)
        {
            AddLegalEntities addLegalEntities = new AddLegalEntities(this);
            addLegalEntities.ShowDialog();
        }

        private void addIndividuals_Click(object sender, EventArgs e)
        {
            AddIndividualas addIndividualas = new AddIndividualas(this);
            addIndividualas.ShowDialog();
        }

        private void externalOrdersAddButton_Click(object sender, EventArgs e)
        {
            AddExternalOrders addExternalOrders = new AddExternalOrders(this);
            addExternalOrders.ShowDialog();
        }

        private void externalOrdersDeleteButton_Click(object sender, EventArgs e)
        {
            int id =  Helper.getDataGridSelectedKey(externalOrdersDataGrid, 0);
            DatabaseAPI.deleteOrderById(id);
            Helper.generateDelete(externalOrdersDataGrid, "external orders", "orders");
        }

        private void showProductsButton_Click(object sender, EventArgs e)
        {
            int id = Helper.getDataGridSelectedKey(developmentTeamsDataGrid, 0);
            compositionOrder compositionOrderForm = new compositionOrder(id);
            compositionOrderForm.ShowDialog();
        }

        private void sendToTheTeamButton_Click(object sender, EventArgs e)
        {
            int id = Helper.getDataGridSelectedKey(designersDataGrid, 0);
            SendToTheTeam sendToTheTeam = new SendToTheTeam(this, id);
            sendToTheTeam.ShowDialog();
        }

        private void renderExOrders(DataGridView grid, string name)
        {
            if (radioButtonExUndone.Checked == true)
            {
                DatabaseAPI.GenerateGrid(grid, "getUndoneExOrders", true);
                exOrderBtnControl(true, true, false);
            } else
            {
                DatabaseAPI.GenerateGrid(grid, "getDoneExOrders", true);
                exOrderBtnControl(false, false, true);
            }
        }

        private void radioButtonEx_CheckedChanged(object sender, EventArgs e)
        {
            renderExOrders(externalOrdersDataGrid, "external orders");
        }

        public void exOrderBtnControl(bool btnMark, bool btnAdd, bool btnDelete)
        {
            externalOrdersDeleteButton.Enabled = btnDelete;
            externalOrdersMarkButton.Enabled = btnMark;
            externalOrdersAddButton.Enabled = btnAdd;
        }

        private void externalOrdersMarkButton_Click(object sender, EventArgs e)
        {
            int id = Helper.getDataGridSelectedKey(externalOrdersDataGrid, 0);
            AddSumForm addSumForm = new AddSumForm(this, id);
            addSumForm.ShowDialog();
        }
    }   
}
