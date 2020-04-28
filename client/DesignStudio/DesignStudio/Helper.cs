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
        public static int getDataGridSelectedKey(DataGridView grid, int keyIndex)
        {
            int rowNum = grid.CurrentCell.RowIndex;
            int keyValue = int.Parse(grid.Rows[rowNum].Cells[keyIndex].Value.ToString());
            return keyValue;
        }

        public static string getDate()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.ToString("dd.MM.yyyy");
        }

    }
}
