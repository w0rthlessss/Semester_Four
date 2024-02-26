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
    public partial class AddForm : Form
    { private DBForm main;
        public AddForm(DBForm main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            idTextBox.Text = (ListForm.values.Last().Id + 1).ToString();
            firstNameTextBox.Clear();
            secondNameTextBox.Clear();
            amountTextBox.Clear();
            loanDatePicker.Value = DateTime.Now;
            expirationDatePicker.Value = DateTime.Now;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string firstName = firstNameTextBox.Text;
            string lastName = secondNameTextBox.Text;
            int value = Convert.ToInt32(amountTextBox.Text);
            string loanDate = loanDatePicker.Text;
            string expirationDate = expirationDatePicker.Text;
            string status = "Active";

            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First name field cannot be empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Second name field cannot be empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (value == 0)
            {
                MessageBox.Show("Amount field cannot be zero!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DateTime.Compare(
                DateTime.Parse(loanDate), 
                DateTime.Parse(expirationDate)) >= 0)
            {
                MessageBox.Show("Expiration date cannot be equal or earlier than loan date!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Array.Resize(ref ListForm.values, ListForm.values.Length+1);
            DatabaseValues _new = new DatabaseValues(id, firstName, lastName, value, loanDate, expirationDate, status);
            ListForm.values[ListForm.values.Length - 1] = _new;
            DBForm.database.InsertValue(_new);

            ClearFields();
            main.OpenDebtListForm();
        }
        
    }
}
