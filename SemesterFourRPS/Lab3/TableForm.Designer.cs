namespace Lab_3
{
    partial class TableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            coordinateTable = new DataGridView();
            N = new DataGridViewTextBoxColumn();
            x = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)coordinateTable).BeginInit();
            SuspendLayout();
            // 
            // coordinateTable
            // 
            coordinateTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coordinateTable.Columns.AddRange(new DataGridViewColumn[] { N, x, Y });
            coordinateTable.Dock = DockStyle.Fill;
            coordinateTable.Location = new Point(0, 0);
            coordinateTable.Name = "coordinateTable";
            coordinateTable.RowHeadersVisible = false;
            coordinateTable.RowHeadersWidth = 51;
            coordinateTable.ScrollBars = ScrollBars.Vertical;
            coordinateTable.Size = new Size(301, 523);
            coordinateTable.TabIndex = 0;
            coordinateTable.Tag = "double";
            // 
            // N
            // 
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.White;
            N.DefaultCellStyle = dataGridViewCellStyle1;
            N.HeaderText = "N";
            N.MinimumWidth = 50;
            N.Name = "N";
            N.ReadOnly = true;
            N.Width = 50;
            // 
            // x
            // 
            dataGridViewCellStyle2.BackColor = Color.DimGray;
            dataGridViewCellStyle2.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            x.DefaultCellStyle = dataGridViewCellStyle2;
            x.HeaderText = "X";
            x.MinimumWidth = 6;
            x.Name = "x";
            x.ReadOnly = true;
            x.Width = 125;
            // 
            // Y
            // 
            dataGridViewCellStyle3.BackColor = Color.DimGray;
            dataGridViewCellStyle3.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            Y.DefaultCellStyle = dataGridViewCellStyle3;
            Y.HeaderText = "Y";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.ReadOnly = true;
            Y.Width = 125;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 523);
            Controls.Add(coordinateTable);
            Name = "TableForm";
            Text = "TableForm";
            Load += TableForm_Load;
            ((System.ComponentModel.ISupportInitialize)coordinateTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView coordinateTable;
        private DataGridViewTextBoxColumn N;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn Y;
    }
}