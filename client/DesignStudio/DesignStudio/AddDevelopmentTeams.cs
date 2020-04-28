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
    public partial class AddDevelopmentTeam : Form
    {
        public DataTable leaders;
        public mainForm main;
        public AddDevelopmentTeam(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void AddDevelopmentTeam_Load(object sender, EventArgs e)
        {
            leaders = DatabaseAPI.LoadDataTableFromQuery("SELECT [personnel number] FROM designers");
            List<string> leadersList = new List<string>();
            foreach (DataRow row in leaders.Rows)
            {
                leadersList.Add(row.ItemArray[0].ToString());
            }
            leadersComboBox.DataSource = leadersList;
            dateBox.Text = Helper.getDate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int teamLeaders = int.Parse(leadersComboBox.SelectedValue.ToString());
            int ID = int.Parse(IDBox.Text);
            string date = dateBox.Text;
            DatabaseAPI.addDevelopmentTeams(ID, teamLeaders, date);
            this.Close();
            main.FillGrids();
        }
    }

}
