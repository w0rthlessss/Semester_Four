using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;

namespace Lab_3
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
            image = new Bitmap(500, 500);
        }

        public TableForm(double[] x, double[] y, Bitmap image)
        {
            InitializeComponent();
            abscisse = x;
            ordinate = y;
            this.image = image;
        }

        public double[] abscisse = new double[0];


        public double[] ordinate = new double[0];

        private string imgPath = "img\\tempGraph";
        private Bitmap image;


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
                string index = DateTime.Now.ToString("yyyyMMddHHmmss");
                imgPath += index + ".png";
                image.Save(imgPath, ImageFormat.Png);

                string filepath = saveFileDialog.FileName;
                if (File.Exists(filepath)){
                    try
                    {
                        FileStream fileStream = File.Open(filepath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                        fileStream.Close();
                    }
                    catch (IOException)
                    {
                        MessageBox.Show($"File is already open by another process!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    FileInfo file = new FileInfo(filepath);
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Coordinates");
                    worksheet.Cells[1, 1].Value = 'x';
                    worksheet.Cells[1, 2].Value = 'y';
                    for (int i = 0; i < abscisse.Length; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = abscisse[i];
                        worksheet.Cells[i + 2, 2].Value = ordinate[i];
                    }

                    FileInfo img = new FileInfo(imgPath);
                    ExcelPicture excelImage = worksheet.Drawings.AddPicture("Sinusoid", img);
                    excelImage.SetPosition(1, 0, 3, 0);
                    excelPackage.SaveAs(file);
                }    
                MessageBox.Show($"Results were successfully saved in file!", "", MessageBoxButtons.OK);
               
            }
        }
    }
}
