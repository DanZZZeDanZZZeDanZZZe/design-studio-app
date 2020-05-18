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
            leadersComboBox.DataSource = Helper.getFieldList("designers", "personnel number");
            dateBox.Text = Helper.getDate().ToString("dd.MM.yyyy"); ;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int teamLeaders = int.Parse(leadersComboBox.SelectedValue.ToString());
            int ID = 0;
            bool flag = true; 
            try
            {
                ID = int.Parse(IDBox.Text);
                if (ID <= 0) throw new Exception();
            } catch
            {
                Helper.reportWrongFieldFormat();
                flag = false;
            }

            if (flag)
            {
                int code = DatabaseAPI.checkDevelopmentTeamID(ID);
                if (Convert.ToBoolean(code))
                {
                    MessageBox.Show("A team with that id already exists", "Error message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string date = dateBox.Text;
                    DatabaseAPI.addDevelopmentTeams(ID, teamLeaders, date);
                    this.Close();
                    main.FillGrids();
                }
            }
        }
    }

}
