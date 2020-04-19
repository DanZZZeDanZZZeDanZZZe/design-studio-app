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
    public partial class ConnectionSetupForm : Form
    {

        public ConnectionSetupForm(mainForm f)
        {
            InitializeComponent();
            string[] DBNameArr = f.DBName.Split('=');
            dBNameTextBox.Text = DBNameArr[1];
            string[] ServerNameArr = f.ServerName.Split('=');
            serverNameTextBox.Text = ServerNameArr[1];
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAndExitButton_Click(object sender, EventArgs e)
        {
            // ConnectionSetupForm settingsForm = (ConnectionSetupForm)Application.OpenForms["SettingsForm"];
            // settingsForm.Close();
            this.Close();
        }
    }
}
