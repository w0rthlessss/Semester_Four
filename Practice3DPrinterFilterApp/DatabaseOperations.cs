using Microsoft.Data.Sqlite;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Practice3DPrinterFilterApp
{
    internal class DatabaseOperations
    {
        private const string dbPath = "../../../database.db";
        private SqliteConnection connection;
        //private SqliteCommand command = new SqliteCommand();

        private List<PrinterClass> printers = new List<PrinterClass>();

        public List<PrinterClass> Printers
        {
            get { return printers; }
        }

        public DatabaseOperations()
        {
            connection = new SqliteConnection($"Data source={dbPath}");
            connection.Open();            
            GetListOfRecords();
            //LoadImage();
            var a = Printers;
        }

       /* private void LoadImage()
        {
            for(int i = 1; i <= 11; i++)
            {
                string imagePath = $"../../../imgs/{i}.png";
                string comText = "UPDATE PRINTERS SET image = @img WHERE id = @ident";
                using(SqliteCommand com = new SqliteCommand(comText, connection))
                {
                    com.Parameters.AddWithValue("@img", File.ReadAllBytes(imagePath));
                    com.Parameters.AddWithValue("@ident", i);
                    com.ExecuteNonQuery();
                }
            }
        }*/

        private void GetListOfRecords()
        {
            string query =
                "SELECT p.id, mf.name, m.title, t.technology, c.type, p.material, pur.purpose, p.height, p.depth, p.image " +
                "FROM Printers p " +
                "JOIN Model m ON p.modelID = m.modelID " +
                "JOIN LayerTechnologies t on t.technologyID = p.technologyID " +
                "JOIN Manufacturers mf ON m.manufacturerID = mf.manufacturerID " +
                "JOIN CaseTypes c on p.caseID = c.caseID " +
                "JOIN Purposes pur on p.purposeID = pur.purposeID";
            using(SqliteCommand com = new SqliteCommand(query, connection))
            {
                using (SqliteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        printers.Add(new PrinterClass(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5).Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList(),
                            reader.GetString(6),
                            reader.GetInt32(7),
                            reader.GetInt32(8),                            
                            (byte[])reader[9]));
                    }
                }
            }

        }
    }
}
