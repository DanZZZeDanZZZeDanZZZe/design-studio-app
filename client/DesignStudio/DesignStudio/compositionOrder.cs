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
        public bool fontStatus = false;
        public bool logoStatus = false;
        public bool clothesStatus = false;
        public bool coverStatus = false;
        public bool cupStatus = false;

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
                fontStatus = true;
            }
            catch { }
            finally
            {
                Helper.useButtons(fontStatus, fontsDeleteButton, fontsAddButton, fontsSaveButton);
            }
            dt = DatabaseAPI.getProductsByID(id, 2);
            try
            {
                logoImageLinkBox.Text = dt.Rows[0].Field<String>(1);
                logoDescriptionBox.Text = dt.Rows[0].Field<String>(2);
                logoTextBox.Text = dt.Rows[0].Field<String>(3);
                logoStatus = true;    
            }
            catch { }
            finally
            {
                Helper.useButtons(logoStatus, logosDeleteButton, logosAddButton, logosSaveButton);
            }
            dt = DatabaseAPI.getProductsByID(id, 4);
            try
            {
                clothesTypeBox.Text = dt.Rows[0].Field<String>(1);
                clothesColorBox.Text = dt.Rows[0].Field<String>(2);
                clothesSizeBox.Text = dt.Rows[0].Field<String>(3);
                clothesTextBox.Text = dt.Rows[0].Field<String>(4);
                clothesStatus = true;
            }
            catch { }
            finally
            {
                Helper.useButtons(clothesStatus, clothesDeleteButton, clothesAddButton, clothesSaveButton);
            }
            dt = DatabaseAPI.getProductsByID(id, 5);
            try
            {
                coverTypeBox.Text = dt.Rows[0].Field<String>(1);
                coverColorBox.Text = dt.Rows[0].Field<String>(2);
                coverDeviceBox.Text = dt.Rows[0].Field<String>(3);
                coverStatus = true;
            }
            catch { }
            finally
            {
                Helper.useButtons(coverStatus, coversDeleteButton, coversAddButton, coversSaveButton);
            }
            dt = DatabaseAPI.getProductsByID(id, 3);
            try
            {
                cupColorBox.Text = dt.Rows[0].Field<String>(2);
                cupVolumeBox.Text = dt.Rows[0].Field<int>(3).ToString();
                cupStatus = true;
            }
            catch { }
            finally
            {
                Helper.useButtons(cupStatus, cupsDeleteButton, cupsAddButton, cupsSaveButton);
            }
        }

        private void fontsAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseAPI.addFonts(id, fontSerifBox.Checked, fontMarkBox.Text, fontWidthBox.Text, fontBoldBox.Checked);
                fontStatus = true;
                Helper.useButtons(fontStatus, fontsDeleteButton, fontsAddButton, fontsSaveButton);
            } catch
            {
                MessageBox.Show("Something went wrong");
            }

        }

        private void logosAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseAPI.addLogos(id, logoImageLinkBox.Text, logoDescriptionBox.Text, logoTextBox.Text);
                logoStatus = true;
                Helper.useButtons(logoStatus, logosDeleteButton, logosAddButton, logosSaveButton);
            }
            catch 
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void clothesAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseAPI.addClothes(id, clothesTypeBox.Text, clothesColorBox.Text, clothesSizeBox.Text, clothesTextBox.Text);
                clothesStatus = true;
                Helper.useButtons(clothesStatus, clothesDeleteButton, clothesAddButton, clothesSaveButton);
            }
            catch 
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void coversAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseAPI.addCovers(id, coverTypeBox.Text, coverColorBox.Text, coverDeviceBox.Text);
                coverStatus = true;
                Helper.useButtons(coverStatus, coversDeleteButton, coversAddButton, coversSaveButton);
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void cupsAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseAPI.addCups(id, cupColorBox.Text, int.Parse(cupVolumeBox.Text));
                cupStatus = true;
                Helper.useButtons(cupStatus, cupsDeleteButton, cupsAddButton, cupsSaveButton);
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void fontsDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> tables = new List<string>() {"fonts", "products"};
                Helper.tryToRemoveTheProduct(id, tables);
                fontStatus = false;
                Helper.useButtons(fontStatus, fontsDeleteButton, fontsAddButton, fontsSaveButton);
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void logosDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> tables = new List<string>() { "logos", "products" };
                Helper.tryToRemoveTheProduct(id, tables);
                logoStatus = false;
                Helper.useButtons(logoStatus, logosDeleteButton, logosAddButton, logosSaveButton);
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void clothesDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> tables = new List<string>() { "clothes", "symbolic products", "products" };
                Helper.tryToRemoveTheProduct(id, tables);
                clothesStatus = false;
                Helper.useButtons(clothesStatus, clothesDeleteButton, clothesAddButton, clothesSaveButton);
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void coversDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> tables = new List<string>() { "covers", "symbolic products", "products" };
                Helper.tryToRemoveTheProduct(id, tables);
                coverStatus = false;
                Helper.useButtons(coverStatus, coversDeleteButton, coversAddButton, coversSaveButton);
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void cupsDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> tables = new List<string>() { "cups", "symbolic products", "products" };
                Helper.tryToRemoveTheProduct(id, tables);
                cupStatus = false;
                Helper.useButtons(cupStatus, cupsDeleteButton, cupsAddButton, cupsSaveButton);
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
