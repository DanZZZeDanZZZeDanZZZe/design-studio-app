﻿using System;
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

        bool ContactTheDB(bool flag)
        {
            
            bool chekintConnection;
            DatabaseAPI.CreateConnection();

            try
            {
                if (flag)
                {
                    DatabaseAPI.ConnectionOpen();
                    MessageBox.Show("База данных подключена", "Успешное выполнение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillGrids();
                }
                else
                {
                    DatabaseAPI.ConnectionClose();
                    MessageBox.Show("База данных отключена", "Успешное выполнение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                chekintConnection = true;

            }
            catch (SqlException ex)
            {
                string title;

                switch (ex.Number)
                {
                    case -1:
                        title = "Неправильное имя сервера";
                        break;
                    case 4060:
                        title = "Неправильное имя базы";
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

            bool con  = ContactTheDB(flagConnectionButton);
            if (con == true)
            {
                flagConnectionButton = !flagConnectionButton;
                Pages.Visible = !flagConnectionButton;
                label.Visible = flagConnectionButton;
            }
            SetEnableButtons();
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
            DatabaseAPI.GenerateGrid(individualsDataGrid, "individuals");
            DatabaseAPI.GenerateGrid(legalEntitiesDataGrid, "legal entities");
            renderExOrders(externalOrdersDataGrid, "external orders");
            renderIntOrders(internalOrdersDataGrid, "internal orders");
            DatabaseAPI.GenerateGrid(developmentTeamsDataGrid, "development teams");
            DatabaseAPI.GenerateGrid(designersDataGrid, "designers");
            DatabaseAPI.GenerateGrid(employeesDataGrid, "employees");
            translateHeaders();
        }

        public void translateHeaders()
        {
            individualsDataGrid.Columns[1].HeaderText = "Номер пасспорта";
            individualsDataGrid.Columns[2].HeaderText = "Имя";
            individualsDataGrid.Columns[3].HeaderText = "Фамилия";
            individualsDataGrid.Columns[4].HeaderText = "Отчество";
            individualsDataGrid.Columns[5].HeaderText = "Номер телефона";

            legalEntitiesDataGrid.Columns[1].HeaderText = "Имя";
            legalEntitiesDataGrid.Columns[2].HeaderText = "ИНН";

            externalOrdersDataGrid.Columns[1].HeaderText = "Дата формирования";
            externalOrdersDataGrid.Columns[2].HeaderText = "Деделайн";
            externalOrdersDataGrid.Columns[3].HeaderText = "Сумма";
            externalOrdersDataGrid.Columns[4].HeaderText = "Выполненность";
            externalOrdersDataGrid.Columns[5].HeaderText = "Заказчик";

            internalOrdersDataGrid.Columns[1].HeaderText = "Дата формирования";
            internalOrdersDataGrid.Columns[2].HeaderText = "Выполненность";

            developmentTeamsDataGrid.Columns[1].HeaderText = "Командный лидер";
            developmentTeamsDataGrid.Columns[2].HeaderText = "Дата формирования";

            designersDataGrid.Columns[0].HeaderText = "Персональный номер";
            designersDataGrid.Columns[1].HeaderText = "Команды разработки"; 
            designersDataGrid.Columns[2].HeaderText = "Специализация";

            employeesDataGrid.Columns[0].HeaderText = "Персональный номер";
            employeesDataGrid.Columns[1].HeaderText = "Имя";
            employeesDataGrid.Columns[2].HeaderText = "Фамилия";
            employeesDataGrid.Columns[3].HeaderText = "Отчество";
            employeesDataGrid.Columns[4].HeaderText = "Опыт";
        }
        private void individualsDeleteButton_Click(object sender, EventArgs e)
        {
            Helper.generateDelete(individualsDataGrid, "individuals", "customers");
            /*int id = Helper.getDataGridSelectedKey(individualsDataGrid, 0);
            if (id >= 0)
            {
                int code = DatabaseAPI.IndividualsDelete(id);
                DatabaseAPI.GenerateGrid(individualsDataGrid, "individuals");
                Helper.callDeleteMessage(code, id);
            }
            else
            {
                Helper.reportTheAbsenceOfAKey();
            }*/
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
            if (id >= 0)
            {
                DatabaseAPI.deleteOrderById(id);
                Helper.generateDelete(externalOrdersDataGrid, "external orders", "orders");
            }
            else
            {
                Helper.reportTheAbsenceOfAKey();
            }
        }

        private void showProductsButton_Click(object sender, EventArgs e)
        {
            int id = Helper.getDataGridSelectedKey(developmentTeamsDataGrid, 0);
            if (id >= 0)
            {
                compositionOrder compositionOrderForm = new compositionOrder(id);
                compositionOrderForm.ShowDialog();
            }
            else
            {
                Helper.reportTheAbsenceOfAKey();
            }
        }

        private void sendToTheTeamButton_Click(object sender, EventArgs e)
        {
            int id = Helper.getDataGridSelectedKey(designersDataGrid, 0);
            if (id >= 0)
            {
                SendToTheTeam sendToTheTeam = new SendToTheTeam(this, id);
                sendToTheTeam.ShowDialog();
            }
            else
            {
                Helper.reportTheAbsenceOfAKey();
            } 
        }

        private void renderExOrders(DataGridView grid, string name)
        {
            if (radioButtonExUndone.Checked == true)
            {
                DatabaseAPI.GenerateGrid(grid, "getUndoneExOrders", true);
                exOrderBtnControl(true, true, false, false);
            } else
            {
                DatabaseAPI.GenerateGrid(grid, "getDoneExOrders", true);
                exOrderBtnControl(false, false, true, true);
            }
        }

        private void radioButtonEx_CheckedChanged(object sender, EventArgs e)
        {
            renderExOrders(externalOrdersDataGrid, "external orders");
        }
        private void radioButtonIn_CheckedChanged(object sender, EventArgs e)
        {
            renderIntOrders(internalOrdersDataGrid, "internal orders");
        }
        private void renderIntOrders(DataGridView grid, string name)
        {
            if (radioButtonIntUndone.Checked == true)
            {
                DatabaseAPI.GenerateGrid(grid, "getUndoneInOrders", true);
                intOrderBtnControl(true, false, true);
            }
            else
            {
                DatabaseAPI.GenerateGrid(grid, "getDoneInOrders", true);
                intOrderBtnControl(false, true, false);
            }
        }

        public void intOrderBtnControl(bool btnAdd, bool btnDelete, bool btnMark)
        {
            internalOrdersDeleteButton.Enabled = btnDelete;
            internalOrdersAddButton.Enabled = btnAdd;
            internalOrdersMarkButton.Enabled = btnMark;
        }

        public void exOrderBtnControl(bool btnMark, bool btnAdd, bool btnDelete, bool btncheck)
        {
            externalOrdersDeleteButton.Enabled = btnDelete;
            externalOrdersMarkButton.Enabled = btnMark;
            externalOrdersAddButton.Enabled = btnAdd;
            openCheckButton.Enabled = btncheck;
        }


        private void externalOrdersMarkButton_Click(object sender, EventArgs e)
        {
            int id = Helper.getDataGridSelectedKey(externalOrdersDataGrid, 0);
            if (id >= 0)
            {
                AddSumForm addSumForm = new AddSumForm(this, id);
                addSumForm.ShowDialog();
            }
            else
            {
                Helper.reportTheAbsenceOfAKey();
            }
        }

        private void openCheckButton_Click(object sender, EventArgs e)
        {
            int id = Helper.getDataGridSelectedKey(externalOrdersDataGrid, 0);
            if (id >= 0)
            {
                Report report = new Report(id);
                report.Show();
            } else
            {
                Helper.reportTheAbsenceOfAKey();
            }
        }

        private void internalOrdersMarkButton_Click(object sender, EventArgs e)
        {
            int id = Helper.getDataGridSelectedKey(internalOrdersDataGrid, 0);
            if (id >= 0)
            {
                DatabaseAPI.markInOrder(id);
                renderIntOrders(internalOrdersDataGrid, "internal orders");
            }
            else
            {
                Helper.reportTheAbsenceOfAKey();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }   
}
