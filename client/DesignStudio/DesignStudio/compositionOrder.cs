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
                addFontsFromForm(false);
                fontStatus = true;
                Helper.useButtons(fontStatus, fontsDeleteButton, fontsAddButton, fontsSaveButton);
            } catch
            {
                Helper.reportWrongFieldFormat();
            }

        }

        private void logosAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                addLogosFromForm(false);
                logoStatus = true;
                Helper.useButtons(logoStatus, logosDeleteButton, logosAddButton, logosSaveButton);
            }
            catch 
            {
                Helper.reportWrongFieldFormat();
            }
        }

        private void clothesAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                addClothesFromForm(false);
                clothesStatus = true;
                Helper.useButtons(clothesStatus, clothesDeleteButton, clothesAddButton, clothesSaveButton);
            }
            catch 
            {
                Helper.reportWrongFieldFormat();
            }
        }

        private void coversAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                addCoversFromForm(false);
                coverStatus = true;
                Helper.useButtons(coverStatus, coversDeleteButton, coversAddButton, coversSaveButton);
            }
            catch
            {
                Helper.reportWrongFieldFormat();
            }
        }

        private void cupsAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                addCupsFromForm(false);
                cupStatus = true;
                Helper.reportWrongFieldFormat();
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
                fontSerifBox.Checked = false;
                fontMarkBox.Clear();
                fontWidthBox.Clear();
                fontBoldBox.Checked = false;
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
                logoImageLinkBox.Clear();
                logoDescriptionBox.Clear();
                logoTextBox.Clear();
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
                clothesTypeBox.Clear();
                clothesColorBox.Clear();
                clothesSizeBox.Clear();
                clothesTextBox.Clear();
                clothesStatus = false;
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
                coverTypeBox.Clear();
                coverColorBox.Clear();
                coverDeviceBox.Clear();
                coverStatus = false;
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
                cupColorBox.Clear();
                cupVolumeBox.Clear();
                cupStatus = false;
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void addFontsFromForm(bool updateStatus)
        {
            DatabaseAPI.addFonts(id, fontSerifBox.Checked, fontMarkBox.Text, fontWidthBox.Text, fontBoldBox.Checked, updateStatus);
        }

        private void addLogosFromForm(bool updateStatus)
        {
            DatabaseAPI.addLogos(id, logoImageLinkBox.Text, logoDescriptionBox.Text, logoTextBox.Text, updateStatus);
        }

        private void addClothesFromForm(bool updateStatus)
        {
            DatabaseAPI.addClothes(id, clothesTypeBox.Text, clothesColorBox.Text, clothesSizeBox.Text, clothesTextBox.Text, updateStatus);
        }

        private void addCoversFromForm(bool updateStatus)
        {
            DatabaseAPI.addCovers(id, coverTypeBox.Text, coverColorBox.Text, coverDeviceBox.Text, updateStatus);
        }

        private void addCupsFromForm(bool updateStatus)
        {
            DatabaseAPI.addCups(id, cupColorBox.Text, int.Parse(cupVolumeBox.Text), updateStatus);
        }

        private void logosSaveButton_Click(object sender, EventArgs e)
        {
            addLogosFromForm(true);
            MessageBox.Show("Data updated");
        }

        private void clothesSaveButton_Click(object sender, EventArgs e)
        {
            addClothesFromForm(true);
            MessageBox.Show("Data updated");
        }

        private void coversSaveButton_Click(object sender, EventArgs e)
        {
            addCoversFromForm(true);
            MessageBox.Show("Data updated");
        }

        private void cupsSaveButton_Click(object sender, EventArgs e)
        {
            addCupsFromForm(true);
            MessageBox.Show("Data updated");
        }

        private void fontsSaveButton_Click(object sender, EventArgs e)
        {
            addFontsFromForm(true);
            MessageBox.Show("Data updated");
        }


    }
}
