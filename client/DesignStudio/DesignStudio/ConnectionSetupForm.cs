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
        public mainForm f;
        public string[] DBNameArr;
        public string[] ServerNameArr;
        public ConnectionSetupForm(mainForm f)
        {
            InitializeComponent();
            this.DBNameArr = DatabaseAPI.dbName.Split('=');
            dBNameTextBox.Text = DBNameArr[1];
            this.ServerNameArr = DatabaseAPI.serverName.Split('=');
            serverNameTextBox.Text = ServerNameArr[1];
            this.f = f;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAndExitButton_Click(object sender, EventArgs e)
        {
            DatabaseAPI.dbName = this.ServerNameArr[0] + "=" + dBNameTextBox.Text;
            DatabaseAPI.serverName = this.DBNameArr[0] + "=" + serverNameTextBox.Text;
            this.Close();
        }

        private void serverNameTextBox_TextChanged(object sender, EventArgs e)
        {
            saveAndExitButton.Enabled = true;
        }

        private void dBNameTextBox_TextChanged(object sender, EventArgs e)
        {
            saveAndExitButton.Enabled = true;
        }
    }
}
