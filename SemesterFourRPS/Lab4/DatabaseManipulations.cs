using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Lab4
{
    public class DatabaseValues
    {

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string firstName = "";
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName = "";
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private int val;
        public int Value
        {
            get { return val; }
            set { val = value; }
        }

        private DateTime loanDate;
        public DateTime LoanDate
        {
            get { return loanDate; }
            set { loanDate = value; }
        }


        private DateTime expirationDate;
        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }


        private string status = "";
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public DatabaseValues
            (int id, string firstName, string lastName, int value,
            string loanDate, string expirationDate, string status)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Value = value;
            LoanDate = DateTime.Parse(loanDate);
            ExpirationDate = DateTime.Parse(expirationDate);
            Status = status;
        }

    }
    public class DatabaseManipulations
    {
        private SqliteCommand command;
        public DatabaseManipulations()
        {
            SqliteConnection connection = new SqliteConnection("Data source=debtDatabase.db;Mode=ReadWrite");
            connection.Open();
            command = new SqliteCommand("",connection);
        }

        public DatabaseValues[] ReadTable()
        {
            command.CommandText = "SELECT COUNT(*) FROM Debts";
            int size = Convert.ToInt32(command.ExecuteScalar());
            DatabaseValues[] values = new DatabaseValues[size];

            command.CommandText = "SELECT * FROM Debts";
            SqliteDataReader reader = command.ExecuteReader();
            int i = 0;

            while(reader.Read())
            {
                int id = Convert.ToInt32(reader.GetValue(0));
                string firstName = reader.GetString(1);
                string lastName = reader.GetString(2);
                int value = Convert.ToInt32(reader.GetValue(3));
                string loanDate = reader.GetString(4);
                string expirationDate = reader.GetString(5);
                string status = reader.GetString(6);
                values[i] = new DatabaseValues(id, firstName, lastName, value, loanDate, expirationDate, status);
                i++;
            }

            reader.Close();
            
            return values;
        }

        public void UpdateValue(DatabaseValues value)
        {
            command.CommandText = $"UPDATE Debts SET " +
                $"firstName = \"{value.FirstName}\", " +
                $"lastName = \"{value.LastName}\", " +
                $"amount = \"{value.Value}\", " +
                $"loanDate = \"{value.LoanDate:dd/MM/yyyy}\", " +
                $"expirationDate = \"{value.ExpirationDate:dd/MM/yyyy}\"," +
                $"status = \"{value.Status}\"" +
                $"WHERE id = \"{value.Id}\"";

            command.ExecuteNonQuery();

        }

        public void UpdateStatus(int id, string stauts)
        {
            command.CommandText = $"UPDATE Debts SET status = \"{stauts}\" WHERE id = \"{id}\"";
            command.ExecuteNonQuery();
        }

        public void DeleteValue(DatabaseValues value)
        {
            command.CommandText = $"DELETE FROM Debts WHERE id = {value.Id}";

            command.ExecuteNonQuery();
        }

        public void InsertValue(DatabaseValues value)
        {
            command.CommandText = $"INSERT INTO Debts (" +
                $"firstName, " +
                $"secondName, " +
                $"amount, " +
                $"loanDate, " +
                $"expirationDate, " +
                $"status) " +
                $"VALUES (" +
                $"\"{value.FirstName}\", " +
                $"\"{value.LastName}\", " +
                $"\"{value.Value}\", " +
                $"\"{value.LoanDate:dd/MM/yyyy}\", " +
                $"\"{value.ExpirationDate:dd/MM/yyyy}\", " +
                $"\"{value.Status}\")";

            command.ExecuteNonQuery();
        }
    }
}
