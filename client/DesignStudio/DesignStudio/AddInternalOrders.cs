using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignStudio
{
    public partial class AddInternalOrders : Form
    {
        public mainForm main;
        public AddInternalOrders(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(teamComboBox.SelectedValue.ToString());
            int code = DatabaseAPI.checkOrdersID(ID);
            if (Convert.ToBoolean(code))
            {
                MessageBox.Show("Внутренний заказ с таким ID уже существует", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string date = dateBox.Text;
                DatabaseAPI.addInternalOrders(ID, date);
                this.Close();
                main.FillGrids();
            }
        }

        private void AddInternalOrders_Load(object sender, EventArgs e)
        {
            dateBox.Text = Helper.getDate().ToString("dd.MM.yyyy");
            List<string> list = Helper.getFieldListFromDataTable(DatabaseAPI.getTeamsWithouOrders());
            teamComboBox.DataSource = list;
        }
    }
}
