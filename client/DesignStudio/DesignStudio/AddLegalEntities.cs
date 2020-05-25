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
            bool flag = true;
            string name = "";
            float inn = 0;
            int ID = 0;
            try
            {
                ID = int.Parse(IDBox.Text);
                name = nameBox.Text;
                inn = float.Parse(innBox.Text);
                if (ID <= 0) throw new Exception();
            } catch
            {
                Helper.reportWrongFieldFormat();
                flag = false;
            }
            if (inn < 12)
            {
                MessageBox.Show("ИНН должен содержать 12 символов", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (flag)
            {
                int code = DatabaseAPI.checkByID(ID, "legal entities");
                if (Convert.ToBoolean(code))
                {
                    MessageBox.Show("Юр. лицо с таким ID уже существует", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DatabaseAPI.addLegalEntities(ID, name, inn);
                    this.Close();
                    main.FillGrids();
                }
            }
        }

    }
}
