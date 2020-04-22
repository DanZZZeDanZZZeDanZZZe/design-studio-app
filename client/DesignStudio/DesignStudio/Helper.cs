using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignStudio
{
    class Helper
    {
        public static void GenerateGrid(DataGridView grid, string name) 
        {
            DataTable dt = DatabaseAPI.LoadAllDataFromTable(name);
            grid.DataSource = dt;
           // grid.Rows[0].Colums[0].HeaderText =
            grid.Update();
        }
        public static string ConvertTableName(string str)
        {
            string newStr;
            switch (str)
            {
                case "Шрифты":
                    newStr = "fonts";
                    break;
                case "Логотипы":
                    newStr = "logos";
                    break;
                default:
                    newStr = "error";
                    break;
            }

            return newStr;
        }
    }
}
