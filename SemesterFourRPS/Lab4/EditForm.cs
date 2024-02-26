using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class EditForm : Form
    {
        private bool databaseContainsThisId = false;
        private DBForm main;
        public EditForm(DBForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        public EditForm(DBForm main, int id)
        {
            InitializeComponent();
            this.main = main;
            this.id = id;
            //Пофиксить чтоб работало
            idTextBox.Text = id.ToString();
            idTextBox_TextChanged(null, null);
        }

        private int id;
        private int index;

        private void ClearFields()
        {
            firstNameTextBox.Clear();
            secondNameTextBox.Clear();
            amountTextBox.Clear();
            loanDatePicker.Value = DateTime.Now;
            expirationDatePicker.Value = DateTime.Now.AddDays(1);
        }

        private void LoadDatabaseRecord()
        {
            index = Array.FindIndex(ListForm.values, obj => obj.Id == id);

            firstNameTextBox.Text = ListForm.values[index].FirstName;
            secondNameTextBox.Text = ListForm.values[index].LastName;
            amountTextBox.Text = ListForm.values[index].Value.ToString();
            loanDatePicker.Value = ListForm.values[index].LoanDate;
            expirationDatePicker.Value = ListForm.values[index].ExpirationDate;
        }

        private void idTextBox_TextChanged(object? sender, EventArgs? e)
        {
            databaseContainsThisId = false;
            if (!Regex.IsMatch(idTextBox.Text, $"^[1-9][0-9]*$") && idTextBox.Text != "")
            {
                idTextBox.Focus();
                idTextBox.Text = idTextBox.Text.Substring(0, idTextBox.Text.Length - 1);
                idTextBox.Select(idTextBox.Text.Length, 0);
                return;
            }
            if (idTextBox.Text == "")
            {
                ClearFields();
                return;
            }

            id = Convert.ToInt32(idTextBox.Text);
            if (!ListForm.values.Any(obj => obj.Id == id))
            {
                ClearFields();
                idTextBox.Focus();
                return;
            }
            databaseContainsThisId = true;
            LoadDatabaseRecord();
        }

        private bool CheckIfContainsThisId()
        {
            if (!databaseContainsThisId)
            {
                MessageBox.Show("Database does not contain any record with this id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                idTextBox.Focus();
                idTextBox.SelectAll();
            }
            return databaseContainsThisId;
        }

        private void IfDatabaseContainsThisId(object sender, MouseEventArgs e)
        {
            CheckIfContainsThisId();
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(amountTextBox.Text, $"^[1-9]*[0-9]+$") && amountTextBox.Text != "")
            {
                amountTextBox.Focus();
                amountTextBox.Text = amountTextBox.Text.Substring(0, amountTextBox.Text.Length - 1);
                amountTextBox.Select(amountTextBox.Text.Length, 0);
                return;
            }
        }

        private void EditForm_Deactivate(object sender, EventArgs e)
        {
            ClearFields();
            idTextBox.Clear();
        }

        private void firstNameTextBox_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Select(0, 0);
        }

        private void secondNameTextBox_Click(object sender, EventArgs e)
        {
            secondNameTextBox.Select(0, 0);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            ClearFields();
        }

        private bool CheckIfThereAnyChanges()
        {
            int amountOld = ListForm.values[index].Value;
            string firstNameOld = ListForm.values[index].FirstName;
            string secondNameOld = ListForm.values[index].LastName;
            DateTime loanDateOld = ListForm.values[index].LoanDate;
            DateTime expirationDateOld = ListForm.values[index].ExpirationDate;

            int amount = Convert.ToInt32(amountTextBox.Text);
            string firstName = firstNameTextBox.Text;
            string secondName = secondNameTextBox.Text;
            DateTime loanDate = loanDatePicker.Value;
            DateTime expirationDate = expirationDatePicker.Value;

            if (!(amount == amountOld && firstNameOld == firstName &&
                secondNameOld == secondName && loanDateOld == loanDate &&
                expirationDateOld == expirationDate))
                return true;

            return false;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if(!CheckIfContainsThisId()) return;
            if (CheckIfThereAnyChanges())
            {
                int amount = Convert.ToInt32(amountTextBox.Text);
                string firstName = firstNameTextBox.Text;
                string secondName = secondNameTextBox.Text;
                string loanDate = loanDatePicker.Value.ToString("dd/MM/yyyy");
                string expirationDate = expirationDatePicker.Value.ToString("dd/MM/yyyy");
                string status;
                if (DateTime.Compare(expirationDatePicker.Value, DateTime.Now) > 0) status = "Active";
                else status = "Expired";

                DatabaseValues _new = new DatabaseValues(id, firstName, secondName, amount, loanDate, expirationDate, status);
                ListForm.values[index] = _new;
                DBForm.database.UpdateValue(_new);
                MessageBox.Show("Database record was successfully updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.OpenDebtListForm();
            }
            else
            {
                MessageBox.Show("No updates recorded!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DatabaseValues[] RemoveElement()
        {
            DatabaseValues[] newValues = new DatabaseValues[ListForm.values.Length-1];

            for(int i = 0, j = 0; i < ListForm.values.Length; i++)
            {
                if(i!=index) newValues[j++] = ListForm.values[i];
            }

            return newValues;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!CheckIfContainsThisId()) return;
            DialogResult res = MessageBox.Show("Are you sure you want to delete this record?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                DBForm.database.DeleteValue(ListForm.values[index]);
                ListForm.values = RemoveElement();
                MessageBox.Show("Database record was successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.OpenDebtListForm();
            }
        }
    }
}
