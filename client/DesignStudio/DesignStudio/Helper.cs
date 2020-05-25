﻿using System;
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
            try {
                int rowNum = grid.CurrentCell.RowIndex;
                int keyValue = int.Parse(grid.Rows[rowNum].Cells[keyIndex].Value.ToString());
                return keyValue;
            } catch
            {
                return -1;
            }
        }
        public static DateTime getDate()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime;
        }

        public static int deleteAdapter(int id, string tableName)
        {
            int code;
            code = DatabaseAPI.checkByID(id, tableName);
            if (code == 0) return 1;
            code = DatabaseAPI.deleteByID(id, tableName);
            if (code == 1) return 2;
            return 0;
        }

        public static int deleteAdapter(int id, string childTableName, string tableName)
        {
            int code;
            code = DatabaseAPI.checkByID(id, childTableName);
            if (code == 0) return 1;
            code = DatabaseAPI.deleteByID(id, childTableName);
            if (code == 1) return 2;
            code = DatabaseAPI.deleteByID(id, tableName);
            if (code == 1) return 2;
            return 0;
        }

        public static void callDeleteMessage(int code, int id)
        {
            switch (code)
            {
                case 0:
                    MessageBox.Show("удалён элемент по номеру " + id.ToString(), "Ошибка");
                    break;
                case 1:
                    MessageBox.Show("Выбранный элемент не существует", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Выбранный элемент имеент связанные записи", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public static List<string> getFieldList(string tableName, string fieldName)
        {
            DataTable data = DatabaseAPI.getTableField(tableName, fieldName);
            List<string> list = new List<string>();
            foreach (DataRow row in data.Rows)
            {
                list.Add(row.ItemArray[0].ToString());
            }
            return list;
        }

        public static List<string> getFieldListFromDataTable(DataTable data)
        {
            List<string> list = new List<string>();
            foreach (DataRow row in data.Rows)
            {
                list.Add(row.ItemArray[0].ToString());
            }
            return list;
        }

        public static void generateDelete(DataGridView grid, string tableName)
        {
            int id = getDataGridSelectedKey(grid, 0);
            if (id == -1)
            {
                reportTheAbsenceOfAKey();
            }
            else
            {
                int code = deleteAdapter(id, tableName);
                if (code == 0)
                    DatabaseAPI.GenerateGrid(grid, tableName);
                callDeleteMessage(code, id);
            }
        }

        public static void generateDelete(DataGridView grid, string tableName, string parentTableName)
        {
       
            int id = getDataGridSelectedKey(grid, 0);
            if (id == -1)
            {
                reportTheAbsenceOfAKey();
            } else
            {
                int code = deleteAdapter(id, tableName, parentTableName);
                if (code == 0)
                    DatabaseAPI.GenerateGrid(grid, tableName);
                callDeleteMessage(code, id);
            }
        }
        public static int deleteLegalEntities(int id)
        {
            return deleteAdapter(id, "legal entities", "customers");
        }

        public static int internalOrders(int id)
        {
            return deleteAdapter(id, "internal orders", "orders");
        }

        public static void tryToRemoveTheProduct(int id, List<string> tables)
        {
            foreach (string table in tables)
            {
                try 
                {
                    deleteAdapter(id, table);
                } catch { }
            }
        }

        public static void useButtons(bool status, Button deleteB, Button addB, Button saveB)
        {
            if (status == true)
            {
                deleteB.Visible = true;
                addB.Visible = false;
                saveB.Visible = true;
            } else
            {
                deleteB.Visible = false;
                addB.Visible = true;
                saveB.Visible = false;
            }
        }

        public static string checkUpdateStatus(bool status, string table1, string table2) 
        {
            if (status == true) return table2;
            return table1;
        }

        public static void reportTheAbsenceOfAKey()
        {
            MessageBox.Show("Элемент не выбран!", "Ошибка" , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void reportWrongFieldFormat()
        {
            MessageBox.Show("Поле иммет неверный формат!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
