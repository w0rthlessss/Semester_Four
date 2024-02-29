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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            coordinateTable = new DataGridView();
            N = new DataGridViewTextBoxColumn();
            x = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            savePanel = new Panel();
            saveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)coordinateTable).BeginInit();
            savePanel.SuspendLayout();
            SuspendLayout();
            // 
            // coordinateTable
            // 
            coordinateTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coordinateTable.Columns.AddRange(new DataGridViewColumn[] { N, x, Y });
            coordinateTable.Dock = DockStyle.Top;
            coordinateTable.Location = new Point(0, 0);
            coordinateTable.Name = "coordinateTable";
            coordinateTable.RowHeadersVisible = false;
            coordinateTable.RowHeadersWidth = 51;
            coordinateTable.ScrollBars = ScrollBars.Vertical;
            coordinateTable.Size = new Size(301, 484);
            coordinateTable.TabIndex = 0;
            coordinateTable.Tag = "double";
            // 
            // N
            // 
            dataGridViewCellStyle4.BackColor = Color.DimGray;
            dataGridViewCellStyle4.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = Color.White;
            N.DefaultCellStyle = dataGridViewCellStyle4;
            N.HeaderText = "N";
            N.MinimumWidth = 50;
            N.Name = "N";
            N.ReadOnly = true;
            N.Width = 50;
            // 
            // x
            // 
            dataGridViewCellStyle5.BackColor = Color.DimGray;
            dataGridViewCellStyle5.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            x.DefaultCellStyle = dataGridViewCellStyle5;
            x.HeaderText = "X";
            x.MinimumWidth = 6;
            x.Name = "x";
            x.ReadOnly = true;
            x.Width = 125;
            // 
            // Y
            // 
            dataGridViewCellStyle6.BackColor = Color.DimGray;
            dataGridViewCellStyle6.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            Y.DefaultCellStyle = dataGridViewCellStyle6;
            Y.HeaderText = "Y";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.ReadOnly = true;
            Y.Width = 125;
            // 
            // savePanel
            // 
            savePanel.BackColor = SystemColors.ControlDark;
            savePanel.Controls.Add(saveBtn);
            savePanel.Dock = DockStyle.Top;
            savePanel.Location = new Point(0, 484);
            savePanel.Name = "savePanel";
            savePanel.Size = new Size(301, 42);
            savePanel.TabIndex = 1;
            // 
            // saveBtn
            // 
            saveBtn.Dock = DockStyle.Right;
            saveBtn.Location = new Point(185, 0);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(116, 42);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "Save table";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += button1_Click;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 523);
            Controls.Add(savePanel);
            Controls.Add(coordinateTable);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TableForm";
            Text = "TableForm";
            Load += TableForm_Load;
            ((System.ComponentModel.ISupportInitialize)coordinateTable).EndInit();
            savePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView coordinateTable;
        private DataGridViewTextBoxColumn N;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn Y;
        private Panel savePanel;
        private Button saveBtn;
    }
}