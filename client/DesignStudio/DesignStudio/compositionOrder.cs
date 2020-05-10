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
    public partial class compositionOrder : Form
    {
        public int id;
        public compositionOrder(int id)
        {
            this.id = id; 
            InitializeComponent();
        }

        private void compositionOrder_Load(object sender, EventArgs e)
        {      
            DataTable dt;
            dt = DatabaseAPI.getProductsByID(id, 1);
            try
            {
                fontSerifBox.Checked = dt.Rows[0].Field<bool>(1);
                fontMarkBox.Text = dt.Rows[0].Field<String>(2);
                fontWidthBox.Text = dt.Rows[0].Field<String>(3);
                fontBoldBox.Checked = dt.Rows[0].Field<bool>(4);
            }
            catch { }
            try
            {
                logoImageLinkBox.Text = dt.Rows[0].Field<String>(1);
                logoDescriptionBox.Text = dt.Rows[0].Field<String>(2);
                logoTextBox.Text = dt.Rows[0].Field<String>(3);

            }
            catch { }
        /*    try
            {
                logoImageLinkBox.Text = dt.Rows[0].Field<String>(1);
                logoDescriptionBox.Text = dt.Rows[0].Field<String>(2);
                logoTextBox.Text = dt.Rows[0].Field<String>(3);

            }
            catch { }*/
            /*.Find(id).Field<String>(2);*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
