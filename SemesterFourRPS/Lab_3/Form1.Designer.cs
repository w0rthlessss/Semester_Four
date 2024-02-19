namespace Lab_3
{
    partial class GraphForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            drawGraphBtn = new Button();
            splitter2 = new Splitter();
            splitter1 = new Splitter();
            panel4 = new Panel();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            leftBorderValue = new TextBox();
            rightBorderValue = new TextBox();
            aValue = new TextBox();
            bValue = new TextBox();
            cValue = new TextBox();
            dValue = new TextBox();
            stepValue = new TextBox();
            leftBorder = new Label();
            rightBorder = new Label();
            aLabel = new Label();
            bLabel = new Label();
            cLabel = new Label();
            dLabel = new Label();
            stepLabel = new Label();
            panel2 = new Panel();
            func = new Label();
            panel1 = new Panel();
            grahPlane = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grahPlane).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.DimGray;
            splitContainer1.Panel1.Controls.Add(drawGraphBtn);
            splitContainer1.Panel1.Controls.Add(splitter2);
            splitContainer1.Panel1.Controls.Add(splitter1);
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(func);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(grahPlane);
            splitContainer1.Size = new Size(965, 501);
            splitContainer1.SplitterDistance = 357;
            splitContainer1.TabIndex = 0;
            // 
            // drawGraphBtn
            // 
            drawGraphBtn.BackColor = Color.FromArgb(64, 64, 64);
            drawGraphBtn.CausesValidation = false;
            drawGraphBtn.Dock = DockStyle.Bottom;
            drawGraphBtn.FlatAppearance.BorderColor = Color.White;
            drawGraphBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(54, 54, 54);
            drawGraphBtn.FlatStyle = FlatStyle.Flat;
            drawGraphBtn.Font = new Font("Impact", 11F);
            drawGraphBtn.ForeColor = Color.White;
            drawGraphBtn.Location = new Point(58, 425);
            drawGraphBtn.Name = "drawGraphBtn";
            drawGraphBtn.Size = new Size(237, 37);
            drawGraphBtn.TabIndex = 8;
            drawGraphBtn.Text = "Draw Graph";
            drawGraphBtn.UseVisualStyleBackColor = false;
            drawGraphBtn.Click += drawGraphBtn_Click;
            // 
            // splitter2
            // 
            splitter2.BackColor = Color.DimGray;
            splitter2.Dock = DockStyle.Right;
            splitter2.Location = new Point(295, 425);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(62, 37);
            splitter2.TabIndex = 7;
            splitter2.TabStop = false;
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.DimGray;
            splitter1.Location = new Point(0, 425);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(58, 37);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 462);
            panel4.Name = "panel4";
            panel4.Size = new Size(357, 39);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 377);
            panel3.Name = "panel3";
            panel3.Size = new Size(357, 48);
            panel3.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.DimGray;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(leftBorderValue, 1, 1);
            tableLayoutPanel1.Controls.Add(rightBorderValue, 2, 1);
            tableLayoutPanel1.Controls.Add(aValue, 1, 3);
            tableLayoutPanel1.Controls.Add(bValue, 2, 3);
            tableLayoutPanel1.Controls.Add(cValue, 1, 5);
            tableLayoutPanel1.Controls.Add(dValue, 2, 5);
            tableLayoutPanel1.Controls.Add(stepValue, 2, 6);
            tableLayoutPanel1.Controls.Add(leftBorder, 1, 0);
            tableLayoutPanel1.Controls.Add(rightBorder, 2, 0);
            tableLayoutPanel1.Controls.Add(aLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(bLabel, 2, 2);
            tableLayoutPanel1.Controls.Add(cLabel, 1, 4);
            tableLayoutPanel1.Controls.Add(dLabel, 2, 4);
            tableLayoutPanel1.Controls.Add(stepLabel, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 147);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(357, 230);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // leftBorderValue
            // 
            leftBorderValue.BackColor = Color.FromArgb(64, 64, 64);
            leftBorderValue.Dock = DockStyle.Fill;
            leftBorderValue.Font = new Font("Impact", 10.2F);
            leftBorderValue.ForeColor = Color.White;
            leftBorderValue.Location = new Point(74, 23);
            leftBorderValue.Name = "leftBorderValue";
            leftBorderValue.Size = new Size(101, 28);
            leftBorderValue.TabIndex = 0;
            leftBorderValue.Text = "-100";
            leftBorderValue.TextAlign = HorizontalAlignment.Center;
            leftBorderValue.Leave += leftBorderValue_Check;
            // 
            // rightBorderValue
            // 
            rightBorderValue.BackColor = Color.FromArgb(64, 64, 64);
            rightBorderValue.Dock = DockStyle.Fill;
            rightBorderValue.Font = new Font("Impact", 10.2F);
            rightBorderValue.ForeColor = Color.White;
            rightBorderValue.Location = new Point(181, 23);
            rightBorderValue.Name = "rightBorderValue";
            rightBorderValue.Size = new Size(101, 28);
            rightBorderValue.TabIndex = 1;
            rightBorderValue.Text = "100";
            rightBorderValue.TextAlign = HorizontalAlignment.Center;
            rightBorderValue.Leave += rightBorderValue_Check;
            // 
            // aValue
            // 
            aValue.BackColor = Color.FromArgb(64, 64, 64);
            aValue.Dock = DockStyle.Fill;
            aValue.Font = new Font("Impact", 10.2F);
            aValue.ForeColor = Color.White;
            aValue.Location = new Point(74, 84);
            aValue.Name = "aValue";
            aValue.Size = new Size(101, 28);
            aValue.TabIndex = 2;
            aValue.Text = "0";
            aValue.TextAlign = HorizontalAlignment.Center;
            aValue.Leave += aValue_Leave;
            // 
            // bValue
            // 
            bValue.BackColor = Color.FromArgb(64, 64, 64);
            bValue.Dock = DockStyle.Fill;
            bValue.Font = new Font("Impact", 10.2F);
            bValue.ForeColor = Color.White;
            bValue.Location = new Point(181, 84);
            bValue.Name = "bValue";
            bValue.Size = new Size(101, 28);
            bValue.TabIndex = 3;
            bValue.Text = "1";
            bValue.TextAlign = HorizontalAlignment.Center;
            bValue.Leave += bValue_Leave;
            // 
            // cValue
            // 
            cValue.BackColor = Color.FromArgb(64, 64, 64);
            cValue.Dock = DockStyle.Fill;
            cValue.Font = new Font("Impact", 10.2F);
            cValue.ForeColor = Color.White;
            cValue.Location = new Point(74, 145);
            cValue.Name = "cValue";
            cValue.Size = new Size(101, 28);
            cValue.TabIndex = 4;
            cValue.Text = "1";
            cValue.TextAlign = HorizontalAlignment.Center;
            cValue.Leave += cValue_Leave;
            // 
            // dValue
            // 
            dValue.BackColor = Color.FromArgb(64, 64, 64);
            dValue.Dock = DockStyle.Fill;
            dValue.Font = new Font("Impact", 10.2F);
            dValue.ForeColor = Color.White;
            dValue.Location = new Point(181, 145);
            dValue.Name = "dValue";
            dValue.Size = new Size(101, 28);
            dValue.TabIndex = 5;
            dValue.Text = "1";
            dValue.TextAlign = HorizontalAlignment.Center;
            dValue.Leave += dValue_Leave;
            // 
            // stepValue
            // 
            stepValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stepValue.BackColor = Color.FromArgb(64, 64, 64);
            stepValue.Font = new Font("Impact", 10.2F);
            stepValue.ForeColor = Color.White;
            stepValue.Location = new Point(181, 199);
            stepValue.Name = "stepValue";
            stepValue.Size = new Size(101, 28);
            stepValue.TabIndex = 6;
            stepValue.Text = "50";
            stepValue.TextAlign = HorizontalAlignment.Center;
            stepValue.Leave += stepValue_Leave;
            // 
            // leftBorder
            // 
            leftBorder.AutoSize = true;
            leftBorder.BackColor = Color.DimGray;
            leftBorder.Dock = DockStyle.Fill;
            leftBorder.Font = new Font("Impact", 10.8F);
            leftBorder.ForeColor = Color.White;
            leftBorder.Location = new Point(74, 0);
            leftBorder.Name = "leftBorder";
            leftBorder.Size = new Size(101, 20);
            leftBorder.TabIndex = 7;
            leftBorder.Text = "Left Border";
            leftBorder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rightBorder
            // 
            rightBorder.AutoSize = true;
            rightBorder.BackColor = Color.DimGray;
            rightBorder.Dock = DockStyle.Fill;
            rightBorder.Font = new Font("Impact", 10.8F);
            rightBorder.ForeColor = Color.White;
            rightBorder.Location = new Point(181, 0);
            rightBorder.Name = "rightBorder";
            rightBorder.Size = new Size(101, 20);
            rightBorder.TabIndex = 8;
            rightBorder.Text = "Right Border";
            rightBorder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.BackColor = Color.DimGray;
            aLabel.Dock = DockStyle.Fill;
            aLabel.Font = new Font("Impact", 10.8F);
            aLabel.ForeColor = Color.White;
            aLabel.Location = new Point(74, 61);
            aLabel.Name = "aLabel";
            aLabel.Size = new Size(101, 20);
            aLabel.TabIndex = 9;
            aLabel.Text = "A";
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.BackColor = Color.DimGray;
            bLabel.Dock = DockStyle.Fill;
            bLabel.Font = new Font("Impact", 10.8F);
            bLabel.ForeColor = Color.White;
            bLabel.Location = new Point(181, 61);
            bLabel.Name = "bLabel";
            bLabel.Size = new Size(101, 20);
            bLabel.TabIndex = 10;
            bLabel.Text = "B";
            bLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.BackColor = Color.DimGray;
            cLabel.Dock = DockStyle.Fill;
            cLabel.Font = new Font("Impact", 10.8F);
            cLabel.ForeColor = Color.White;
            cLabel.Location = new Point(74, 122);
            cLabel.Name = "cLabel";
            cLabel.Size = new Size(101, 20);
            cLabel.TabIndex = 11;
            cLabel.Text = "C";
            cLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.BackColor = Color.DimGray;
            dLabel.Dock = DockStyle.Fill;
            dLabel.Font = new Font("Impact", 10.8F);
            dLabel.ForeColor = Color.White;
            dLabel.Location = new Point(181, 122);
            dLabel.Name = "dLabel";
            dLabel.Size = new Size(101, 20);
            dLabel.TabIndex = 12;
            dLabel.Text = "D";
            dLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stepLabel
            // 
            stepLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stepLabel.AutoSize = true;
            stepLabel.BackColor = Color.DimGray;
            stepLabel.Font = new Font("Impact", 10.8F);
            stepLabel.ForeColor = Color.White;
            stepLabel.Location = new Point(74, 201);
            stepLabel.Margin = new Padding(3, 0, 3, 7);
            stepLabel.Name = "stepLabel";
            stepLabel.Size = new Size(101, 22);
            stepLabel.TabIndex = 13;
            stepLabel.Text = "Step (px)";
            stepLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 39);
            panel2.TabIndex = 2;
            // 
            // func
            // 
            func.BackColor = Color.DimGray;
            func.Dock = DockStyle.Top;
            func.Font = new Font("Impact", 19F);
            func.ForeColor = Color.White;
            func.Location = new Point(0, 62);
            func.Name = "func";
            func.Size = new Size(357, 46);
            func.TabIndex = 0;
            func.Text = "y = a + bsin(cx + d)";
            func.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 62);
            panel1.TabIndex = 1;
            // 
            // grahPlane
            // 
            grahPlane.BackColor = SystemColors.Control;
            grahPlane.Dock = DockStyle.Fill;
            grahPlane.Location = new Point(0, 0);
            grahPlane.Name = "grahPlane";
            grahPlane.Size = new Size(604, 501);
            grahPlane.TabIndex = 0;
            grahPlane.TabStop = false;
            grahPlane.Resize += grahPlane_Resize;
            // 
            // GraphForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 501);
            Controls.Add(splitContainer1);
            Name = "GraphForm";
            Text = "Lab3";
            Shown += GraphForm_Shown;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grahPlane).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label func;
        private PictureBox grahPlane;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel1;
        private TextBox leftBorderValue;
        private TextBox rightBorderValue;
        private TextBox aValue;
        private TextBox bValue;
        private TextBox cValue;
        private TextBox dValue;
        private TextBox stepValue;
        private Label leftBorder;
        private Label rightBorder;
        private Label aLabel;
        private Label bLabel;
        private Label cLabel;
        private Label dLabel;
        private Label stepLabel;
        private Panel panel3;
        private Button drawGraphBtn;
        private Splitter splitter2;
        private Splitter splitter1;
        private Panel panel4;
    }
}
