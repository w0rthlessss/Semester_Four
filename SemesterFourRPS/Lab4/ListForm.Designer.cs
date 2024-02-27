namespace Lab4
{
    partial class ListForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            debtTable = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            firstName = new DataGridViewTextBoxColumn();
            SecondName = new DataGridViewTextBoxColumn();
            Sum = new DataGridViewTextBoxColumn();
            LoanDate = new DataGridViewTextBoxColumn();
            ExpirationDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            saveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)debtTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(850, 50);
            label1.TabIndex = 0;
            label1.Text = "List of Debts";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // debtTable
            // 
            debtTable.AllowUserToAddRows = false;
            debtTable.AllowUserToDeleteRows = false;
            debtTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            debtTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            debtTable.BackgroundColor = SystemColors.ButtonFace;
            debtTable.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            debtTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            debtTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            debtTable.Columns.AddRange(new DataGridViewColumn[] { id, firstName, SecondName, Sum, LoanDate, ExpirationDate, Status });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            debtTable.DefaultCellStyle = dataGridViewCellStyle9;
            debtTable.Dock = DockStyle.Fill;
            debtTable.GridColor = Color.FromArgb(40, 40, 40);
            debtTable.Location = new Point(0, 50);
            debtTable.Margin = new Padding(10, 10, 10, 3);
            debtTable.Name = "debtTable";
            debtTable.ReadOnly = true;
            debtTable.RowHeadersVisible = false;
            debtTable.RowHeadersWidth = 51;
            debtTable.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            debtTable.RowTemplate.DefaultCellStyle.BackColor = Color.DimGray;
            debtTable.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            debtTable.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            debtTable.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            debtTable.Size = new Size(850, 400);
            debtTable.TabIndex = 1;
            debtTable.CellMouseDoubleClick += debtTable_CellMouseDoubleClick;
            // 
            // id
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = "0";
            id.DefaultCellStyle = dataGridViewCellStyle8;
            id.HeaderText = "id";
            id.MinimumWidth = 50;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // firstName
            // 
            firstName.HeaderText = "First Name";
            firstName.MinimumWidth = 100;
            firstName.Name = "firstName";
            firstName.ReadOnly = true;
            // 
            // SecondName
            // 
            SecondName.HeaderText = "Second Name";
            SecondName.MinimumWidth = 100;
            SecondName.Name = "SecondName";
            SecondName.ReadOnly = true;
            // 
            // Sum
            // 
            Sum.HeaderText = "Amount";
            Sum.MinimumWidth = 100;
            Sum.Name = "Sum";
            Sum.ReadOnly = true;
            // 
            // LoanDate
            // 
            LoanDate.HeaderText = "Loan Date";
            LoanDate.MinimumWidth = 100;
            LoanDate.Name = "LoanDate";
            LoanDate.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            ExpirationDate.HeaderText = "Expiration Date";
            ExpirationDate.MinimumWidth = 100;
            ExpirationDate.Name = "ExpirationDate";
            ExpirationDate.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 50;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(saveBtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 393);
            panel1.Margin = new Padding(3, 3, 20, 20);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 20, 20);
            panel1.Size = new Size(850, 57);
            panel1.TabIndex = 2;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Gray;
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.Dock = DockStyle.Right;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(591, 0);
            saveBtn.Margin = new Padding(10, 3, 10, 3);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(239, 37);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Save to file";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // ListForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(850, 450);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(debtTable);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ListForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ListForm";
            Activated += ListForm_Activated;
            Load += ListForm_Load;
            ((System.ComponentModel.ISupportInitialize)debtTable).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView debtTable;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn SecondName;
        private DataGridViewTextBoxColumn Sum;
        private DataGridViewTextBoxColumn LoanDate;
        private DataGridViewTextBoxColumn ExpirationDate;
        private DataGridViewTextBoxColumn Status;
        private Panel panel1;
        private Button saveBtn;
    }
}