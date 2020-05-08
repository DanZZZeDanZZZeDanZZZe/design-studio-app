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
    public partial class AddExternalOrders : Form
    {
        public mainForm main;
        public DateTime date;
        public AddExternalOrders(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            this.date = Helper.getDate();
        } 

        private void AddExternalOrders_Load(object sender, EventArgs e)
        {
            customerComboBox.DataSource = Helper.getFieldList("customers", "ID");
            List<string> list = Helper.getFieldListFromDataTable(DatabaseAPI.getTeamsWithouOrders());
            teamComboBox.DataSource = list;
            dateBox.Text = date.ToString("dd.MM.yyyy"); ;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(teamComboBox.SelectedValue.ToString());
            int code = DatabaseAPI.checkByID(ID, "orders");
            if (Convert.ToBoolean(code))
            {
                MessageBox.Show("A order with that id already exists", "Error message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int customersID = int.Parse(customerComboBox.SelectedValue.ToString());
                string dateStr = dateBox.Text;
                int dayCount = int.Parse(durationBox.Text);
                string deadline = date.AddDays(dayCount).ToString("dd.MM.yyyy");
                DatabaseAPI.addExternalOrders(ID, dateStr, deadline, customersID);
                this.Close();
                main.FillGrids();
            }
        }
    }
}
