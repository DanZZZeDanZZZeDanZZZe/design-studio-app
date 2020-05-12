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
    public partial class SendToTheTeam : Form
    {
        public int PN;
        public mainForm main;
        public SendToTheTeam(mainForm main, int PN)
        {
            this.PN = PN;
            this.main = main;
            InitializeComponent();
        }

        private void SendToTheTeam_Load(object sender, EventArgs e)
        {
            teamsComboBox.DataSource = Helper.getFieldList("development teams", "ID");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DatabaseAPI.sendToTheTeam(this.PN, int.Parse(teamsComboBox.SelectedValue.ToString()));
            main.FillGrids();
            this.Close();
        }
    }
}
