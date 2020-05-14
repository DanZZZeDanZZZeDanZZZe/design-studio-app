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
    public partial class AddSumForm : Form
    {
        public int ID;
        public mainForm main;
        public AddSumForm()
        {
            InitializeComponent();
        }
        public AddSumForm(mainForm main, int ID)
        {
            this.ID = ID;
            this.main = main;
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DatabaseAPI.markExOrder(this.ID, int.Parse(textBoxSum.Text));
            main.FillGrids();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
