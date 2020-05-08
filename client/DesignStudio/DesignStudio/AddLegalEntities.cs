﻿using System;
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
    public partial class AddLegalEntities : Form
    {

        public mainForm main;
        public AddLegalEntities(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDBox.Text);
            int code = DatabaseAPI.checkByID(ID, "customers");
            if (Convert.ToBoolean(code))
            {
                MessageBox.Show("A customer with that id already exists", "Error message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = nameBox.Text;
                float inn = float.Parse(innBox.Text);
                DatabaseAPI.addLegalEntities(ID, name, inn);                
                this.Close();
                main.FillGrids();
            }
        }

    }
}
