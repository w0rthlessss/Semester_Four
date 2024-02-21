using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            for(int i = 0; i < size; i++)
            {
                coordinateTable.Rows[i].Cells[0].Value = i + 1;
                coordinateTable.Rows[i].Cells[1].Value = abscisse[i];
                coordinateTable.Rows[i].Cells[2].Value = ordinate[i];
            }
        }
    }
}
