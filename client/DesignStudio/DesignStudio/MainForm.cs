using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignStudio
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        bool flagConnectionButton = true;
        string serverName = ConfigurationManager.ConnectionStrings["ServerName"].ConnectionString;
        string dBName = ConfigurationManager.ConnectionStrings["DBName"].ConnectionString;
        string settings = ConfigurationManager.ConnectionStrings["Settings"].ConnectionString;

        public string ServerName { get => serverName; set => serverName = value; }
        public string DBName { get   => dBName; set => dBName = value; }
        public string Settings { get => settings; set => settings = value; }

        public SqlConnection con;
        public DataSet ds;
        SqlDataAdapter sqlDataAdapter;

        bool ContactTheDB(bool flag)
        {
            string connectionString = ServerName + DBName + Settings;
            bool chekintConnection;

            con = new SqlConnection(connectionString);
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM fonts", con);
            ds = new DataSet();

            try
            {
                if (flag)
                {
                    con.Open();
                    MessageBox.Show("База данных подключена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con.Close();
                    MessageBox.Show("База данных отключена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                chekintConnection = true;

            }
            catch (SqlException ex)
            {
                string title;

                switch (ex.Number)
                {
                    case -1:
                        title = "Неверное имя сервера";
                        break;
                    case 4060:
                        title = "Неверное название базы данных";
                        break;
                    case 18456:
                        title = "Неверное имя пользователя или пароль";
                        break;
                    default:
                        title = "Ошибка";
                        break;
                }

                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                chekintConnection = false;
            }

            return chekintConnection;
        }

        /*DataSet InitDataset()
        {

        }*/

        private void connectButton_Click(object sender, EventArgs e)
        {
            SetEnableButtons();
            if (flagConnectionButton)
            {
                connectButton.Text = "Отключить";
            }
            else
            {
                connectButton.Text = "Подключить";
            }

            ContactTheDB(flagConnectionButton);
            SetEnableButtons();
            flagConnectionButton = !flagConnectionButton;
        }

        private void SetEnableButtons()
        {
            connectButton.Enabled = !connectButton.Enabled;
            settingButton.Enabled = !settingButton.Enabled;
        }
        private void settingButton_Click(object sender, EventArgs e)
        {
            ConnectionSetupForm DialogF = new ConnectionSetupForm(this);
            DialogF.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            ds.Tables.Clear();
            sqlDataAdapter.Fill(ds, "fonts");

            mainDataGrid.DataSource = ds.Tables[0];

        }
    }
}
