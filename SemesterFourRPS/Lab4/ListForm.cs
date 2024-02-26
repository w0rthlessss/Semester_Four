using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class ListForm : Form
    {
        private DBForm main;
        public static DatabaseValues[] values = new DatabaseValues[0];
        private static DatabaseValues[] oldValues = new DatabaseValues[0];
        public ListForm(DBForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        public void UpdateTableValues()
        {
            values = DBForm.database.ReadTable();
            oldValues = values;
            debtTable.Rows.Clear();
            debtTable.RowCount = values.Length;

            for (int i = 0; i < values.Length; i++)
            {
                debtTable.Rows[i].Cells[0].Value = values[i].Id;
                debtTable.Rows[i].Cells[1].Value = values[i].FirstName;
                debtTable.Rows[i].Cells[2].Value = values[i].LastName;
                debtTable.Rows[i].Cells[3].Value = values[i].Value;
                debtTable.Rows[i].Cells[4].Value = values[i].LoanDate.ToString("dd/MM/yyyy");
                debtTable.Rows[i].Cells[5].Value = values[i].ExpirationDate.ToString("dd/MM/yyyy");

                if (values[i].Status == "Active" && DateTime.Compare(values[i].ExpirationDate, DateTime.Now) < 0)
                {
                    values[i].Status = "Expired";
                    DBForm.database.UpdateStatus(values[i].Id, "Expired");
                }
                
                debtTable.Rows[i].Cells[6].Value = values[i].Status;

                if (values[i].Status == "Active")
                    debtTable.Rows[i].Cells[6].Style.ForeColor = Color.LightGreen;
                else
                    debtTable.Rows[i].Cells[6].Style.ForeColor = Color.Red;
            }
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            UpdateTableValues();
        }

        private void ListForm_Activated(object sender, EventArgs e)
        {
            if(oldValues != values) 
                UpdateTableValues();
        }
    }
}
