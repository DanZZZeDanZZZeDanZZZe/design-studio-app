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
    public partial class AddIndividualas : Form
    {
        public mainForm main;
        public AddIndividualas(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string name = "";
            string suname = "";
            string patronymic = "";
            float passportID = 0;
            float phoneNumber = 0;
            int ID = 0;


            try
            {
                ID = int.Parse(IDBox.Text);
                name = nameBox.Text;
                suname = sunameBox.Text;
                patronymic = patronymicBox.Text;
                passportID = float.Parse(PIDBox.Text);
                phoneNumber = float.Parse(numberBox.Text);
            }
            catch
            {
                Helper.reportWrongFieldFormat();
                flag = false;
            }
            if (flag)
            {
                int code = DatabaseAPI.checkByID(ID, "customers");
                if (Convert.ToBoolean(code))
                {
                    MessageBox.Show("A customer with that id already exists", "Error message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    DatabaseAPI.addIndividualas(ID, passportID, name, suname, patronymic, phoneNumber);
                    this.Close();
                    main.FillGrids();
                }
            }
        }
    }
}
