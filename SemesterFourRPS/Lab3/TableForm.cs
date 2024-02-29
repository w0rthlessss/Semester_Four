using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Lab_3
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }

        public TableForm(double[] x, double[] y)
        {
            InitializeComponent();
            abscisse = x;
            ordinate = y;
        }

        public double[] abscisse = new double[0];


        public double[] ordinate = new double[0];


        private void TableForm_Load(object sender, EventArgs e)
        {
            coordinateTable.Rows.Clear();
            int size = abscisse.Length;
            coordinateTable.RowCount = size;
            for (int i = 0; i < size; i++)
            {
                coordinateTable.Rows[i].Cells[0].Value = i + 1;
                coordinateTable.Rows[i].Cells[1].Value = abscisse[i];
                coordinateTable.Rows[i].Cells[2].Value = ordinate[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PointF[] coordinates = new PointF[abscisse.Length];
            for(int i = 0; i <abscisse.Length; i++)
            {
                coordinates[i].X = (float)abscisse[i];
                coordinates[i].Y = (float)ordinate[i];
            }

            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(PointF[]));

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "xlsx (*xlsx)|*.xlsx|Все файлы (*.*)|*.* ";
            saveFileDialog.Title = "Save data";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFileDialog.FileName;
                //using (StreamWriter writer = new StreamWriter(filepath))
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Coordinates");
                    for(int i = 0; i < abscisse.Length; i++)
                    {
                        worksheet.Cells[i+1, 1].Value = abscisse[i];
                        worksheet.Cells[i + 1, 2].Value = ordinate[i];
                    }

                    FileInfo file = new FileInfo(filepath);
                    excelPackage.SaveAs(file);

                }
                MessageBox.Show($"Results were successfully saved in file!", "", MessageBoxButtons.OK);
            }
        }
    }
}
