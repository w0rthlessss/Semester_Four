namespace Lab4
{
    partial class EditForm
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
            applyBtn = new Button();
            expirationDatePicker = new DateTimePicker();
            expirationDateContainer = new Panel();
            expirationDateLabel = new Label();
            loanDatePicker = new DateTimePicker();
            loanDateLabel = new Label();
            loanDateContainer = new Panel();
            dateLayout = new FlowLayoutPanel();
            amountLabel = new Label();
            amountContainer = new Panel();
            amountTextBox = new MaskedTextBox();
            amountLayout = new FlowLayoutPanel();
            secondNameLabel = new Label();
            firstNameLabel = new Label();
            firstNameContainer = new Panel();
            firstNameTextBox = new MaskedTextBox();
            idLayout = new FlowLayoutPanel();
            idContainer = new Panel();
            idTextBox = new MaskedTextBox();
            idLabel = new Label();
            fullNameLayout = new FlowLayoutPanel();
            secondNameContainer = new Panel();
            secondNameTextBox = new MaskedTextBox();
            mainLayout = new FlowLayoutPanel();
            formLabel = new Label();
            btnContainer = new Panel();
            deleteBtn = new Button();
            splitter1 = new Splitter();
            expirationDateContainer.SuspendLayout();
            loanDateContainer.SuspendLayout();
            dateLayout.SuspendLayout();
            amountContainer.SuspendLayout();
            amountLayout.SuspendLayout();
            firstNameContainer.SuspendLayout();
            idLayout.SuspendLayout();
            idContainer.SuspendLayout();
            fullNameLayout.SuspendLayout();
            secondNameContainer.SuspendLayout();
            mainLayout.SuspendLayout();
            btnContainer.SuspendLayout();
            SuspendLayout();
            // 
            // applyBtn
            // 
            applyBtn.BackColor = Color.FromArgb(0, 192, 0);
            applyBtn.Cursor = Cursors.Hand;
            applyBtn.Dock = DockStyle.Right;
            applyBtn.FlatStyle = FlatStyle.Flat;
            applyBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            applyBtn.ForeColor = Color.White;
            applyBtn.Location = new Point(719, 0);
            applyBtn.Margin = new Padding(10, 3, 10, 3);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(239, 37);
            applyBtn.TabIndex = 0;
            applyBtn.Text = "Apply Changes";
            applyBtn.UseVisualStyleBackColor = false;
            applyBtn.Click += applyBtn_Click;
            // 
            // expirationDatePicker
            // 
            expirationDatePicker.Location = new Point(135, 10);
            expirationDatePicker.Name = "expirationDatePicker";
            expirationDatePicker.Size = new Size(156, 27);
            expirationDatePicker.TabIndex = 1;
            expirationDatePicker.MouseDown += IfDatabaseContainsThisId;
            // 
            // expirationDateContainer
            // 
            expirationDateContainer.Controls.Add(expirationDatePicker);
            expirationDateContainer.Controls.Add(expirationDateLabel);
            expirationDateContainer.Location = new Point(376, 3);
            expirationDateContainer.Margin = new Padding(100, 3, 3, 3);
            expirationDateContainer.Name = "expirationDateContainer";
            expirationDateContainer.Size = new Size(300, 49);
            expirationDateContainer.TabIndex = 5;
            // 
            // expirationDateLabel
            // 
            expirationDateLabel.Dock = DockStyle.Left;
            expirationDateLabel.Font = new Font("Segoe UI", 10.2F);
            expirationDateLabel.Location = new Point(0, 0);
            expirationDateLabel.Name = "expirationDateLabel";
            expirationDateLabel.Size = new Size(129, 49);
            expirationDateLabel.TabIndex = 0;
            expirationDateLabel.Text = "Expiration Date";
            expirationDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // loanDatePicker
            // 
            loanDatePicker.Location = new Point(111, 10);
            loanDatePicker.Name = "loanDatePicker";
            loanDatePicker.Size = new Size(156, 27);
            loanDatePicker.TabIndex = 1;
            loanDatePicker.MouseDown += IfDatabaseContainsThisId;
            // 
            // loanDateLabel
            // 
            loanDateLabel.Dock = DockStyle.Left;
            loanDateLabel.Font = new Font("Segoe UI", 10.2F);
            loanDateLabel.Location = new Point(0, 0);
            loanDateLabel.Name = "loanDateLabel";
            loanDateLabel.Size = new Size(93, 49);
            loanDateLabel.TabIndex = 0;
            loanDateLabel.Text = "Loan Date";
            loanDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // loanDateContainer
            // 
            loanDateContainer.Controls.Add(loanDatePicker);
            loanDateContainer.Controls.Add(loanDateLabel);
            loanDateContainer.Dock = DockStyle.Top;
            loanDateContainer.Location = new Point(3, 3);
            loanDateContainer.Name = "loanDateContainer";
            loanDateContainer.Size = new Size(270, 49);
            loanDateContainer.TabIndex = 0;
            // 
            // dateLayout
            // 
            dateLayout.Controls.Add(loanDateContainer);
            dateLayout.Controls.Add(expirationDateContainer);
            dateLayout.Dock = DockStyle.Left;
            dateLayout.Location = new Point(13, 226);
            dateLayout.Margin = new Padding(3, 10, 3, 10);
            dateLayout.Name = "dateLayout";
            dateLayout.Size = new Size(854, 52);
            dateLayout.TabIndex = 4;
            // 
            // amountLabel
            // 
            amountLabel.Dock = DockStyle.Left;
            amountLabel.Font = new Font("Segoe UI", 10.2F);
            amountLabel.Location = new Point(0, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(80, 49);
            amountLabel.TabIndex = 0;
            amountLabel.Text = "Amount";
            amountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // amountContainer
            // 
            amountContainer.Controls.Add(amountTextBox);
            amountContainer.Controls.Add(amountLabel);
            amountContainer.Dock = DockStyle.Top;
            amountContainer.Location = new Point(3, 3);
            amountContainer.Name = "amountContainer";
            amountContainer.Size = new Size(270, 49);
            amountContainer.TabIndex = 0;
            // 
            // amountTextBox
            // 
            amountTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            amountTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            amountTextBox.ImeMode = ImeMode.NoControl;
            amountTextBox.Location = new Point(111, 12);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.PromptChar = '0';
            amountTextBox.RejectInputOnFirstFailure = true;
            amountTextBox.Size = new Size(156, 27);
            amountTextBox.TabIndex = 2;
            amountTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            amountTextBox.MouseClick += IfDatabaseContainsThisId;
            amountTextBox.TextChanged += amountTextBox_TextChanged;
            // 
            // amountLayout
            // 
            amountLayout.Controls.Add(amountContainer);
            amountLayout.Dock = DockStyle.Left;
            amountLayout.Location = new Point(13, 154);
            amountLayout.Margin = new Padding(3, 10, 3, 10);
            amountLayout.Name = "amountLayout";
            amountLayout.Size = new Size(270, 52);
            amountLayout.TabIndex = 3;
            // 
            // secondNameLabel
            // 
            secondNameLabel.Dock = DockStyle.Left;
            secondNameLabel.Font = new Font("Segoe UI", 10.2F);
            secondNameLabel.Location = new Point(0, 0);
            secondNameLabel.Name = "secondNameLabel";
            secondNameLabel.Size = new Size(118, 49);
            secondNameLabel.TabIndex = 0;
            secondNameLabel.Text = "Second Name";
            secondNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // firstNameLabel
            // 
            firstNameLabel.Dock = DockStyle.Left;
            firstNameLabel.Font = new Font("Segoe UI", 10.2F);
            firstNameLabel.Location = new Point(0, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(105, 49);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            firstNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // firstNameContainer
            // 
            firstNameContainer.Controls.Add(firstNameTextBox);
            firstNameContainer.Controls.Add(firstNameLabel);
            firstNameContainer.Dock = DockStyle.Top;
            firstNameContainer.Location = new Point(3, 3);
            firstNameContainer.Name = "firstNameContainer";
            firstNameContainer.Size = new Size(270, 49);
            firstNameContainer.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(111, 11);
            firstNameTextBox.Mask = ">L<??????????";
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PromptChar = ' ';
            firstNameTextBox.Size = new Size(156, 27);
            firstNameTextBox.TabIndex = 2;
            firstNameTextBox.Click += firstNameTextBox_Click;
            firstNameTextBox.MouseClick += IfDatabaseContainsThisId;
            // 
            // idLayout
            // 
            idLayout.Controls.Add(idContainer);
            idLayout.Dock = DockStyle.Left;
            idLayout.Location = new Point(13, 10);
            idLayout.Margin = new Padding(3, 10, 3, 10);
            idLayout.Name = "idLayout";
            idLayout.Size = new Size(125, 52);
            idLayout.TabIndex = 2;
            // 
            // idContainer
            // 
            idContainer.Controls.Add(idTextBox);
            idContainer.Controls.Add(idLabel);
            idContainer.Dock = DockStyle.Top;
            idContainer.Location = new Point(3, 3);
            idContainer.Name = "idContainer";
            idContainer.Size = new Size(108, 49);
            idContainer.TabIndex = 0;
            // 
            // idTextBox
            // 
            idTextBox.InsertKeyMode = InsertKeyMode.Overwrite;
            idTextBox.Location = new Point(29, 12);
            idTextBox.Name = "idTextBox";
            idTextBox.PromptChar = '0';
            idTextBox.RejectInputOnFirstFailure = true;
            idTextBox.Size = new Size(76, 27);
            idTextBox.TabIndex = 1;
            idTextBox.ValidatingType = typeof(int);
            idTextBox.TextChanged += idTextBox_TextChanged;
            // 
            // idLabel
            // 
            idLabel.Dock = DockStyle.Left;
            idLabel.Font = new Font("Segoe UI", 10.2F);
            idLabel.Location = new Point(0, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(31, 49);
            idLabel.TabIndex = 0;
            idLabel.Text = "id";
            idLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fullNameLayout
            // 
            fullNameLayout.Controls.Add(firstNameContainer);
            fullNameLayout.Controls.Add(secondNameContainer);
            fullNameLayout.Dock = DockStyle.Left;
            fullNameLayout.Location = new Point(13, 82);
            fullNameLayout.Margin = new Padding(3, 10, 3, 10);
            fullNameLayout.Name = "fullNameLayout";
            fullNameLayout.Size = new Size(854, 52);
            fullNameLayout.TabIndex = 1;
            // 
            // secondNameContainer
            // 
            secondNameContainer.Controls.Add(secondNameTextBox);
            secondNameContainer.Controls.Add(secondNameLabel);
            secondNameContainer.Dock = DockStyle.Top;
            secondNameContainer.Location = new Point(376, 3);
            secondNameContainer.Margin = new Padding(100, 3, 3, 3);
            secondNameContainer.Name = "secondNameContainer";
            secondNameContainer.Size = new Size(300, 49);
            secondNameContainer.TabIndex = 1;
            // 
            // secondNameTextBox
            // 
            secondNameTextBox.Location = new Point(135, 11);
            secondNameTextBox.Mask = ">L<??????????";
            secondNameTextBox.Name = "secondNameTextBox";
            secondNameTextBox.PromptChar = ' ';
            secondNameTextBox.Size = new Size(156, 27);
            secondNameTextBox.TabIndex = 2;
            secondNameTextBox.Click += secondNameTextBox_Click;
            secondNameTextBox.MouseClick += IfDatabaseContainsThisId;
            // 
            // mainLayout
            // 
            mainLayout.Controls.Add(idLayout);
            mainLayout.Controls.Add(fullNameLayout);
            mainLayout.Controls.Add(amountLayout);
            mainLayout.Controls.Add(dateLayout);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.FlowDirection = FlowDirection.TopDown;
            mainLayout.Location = new Point(0, 50);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(10, 0, 10, 0);
            mainLayout.Size = new Size(978, 454);
            mainLayout.TabIndex = 5;
            // 
            // formLabel
            // 
            formLabel.Dock = DockStyle.Top;
            formLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            formLabel.Location = new Point(0, 0);
            formLabel.Margin = new Padding(3);
            formLabel.Name = "formLabel";
            formLabel.Size = new Size(978, 50);
            formLabel.TabIndex = 4;
            formLabel.Text = "Edit Debt";
            formLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnContainer
            // 
            btnContainer.Controls.Add(deleteBtn);
            btnContainer.Controls.Add(splitter1);
            btnContainer.Controls.Add(applyBtn);
            btnContainer.Dock = DockStyle.Bottom;
            btnContainer.Location = new Point(0, 504);
            btnContainer.Margin = new Padding(3, 3, 20, 20);
            btnContainer.Name = "btnContainer";
            btnContainer.Padding = new Padding(0, 0, 20, 20);
            btnContainer.Size = new Size(978, 57);
            btnContainer.TabIndex = 6;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(192, 0, 0);
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.Dock = DockStyle.Right;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(453, 0);
            deleteBtn.Margin = new Padding(10, 3, 10, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(239, 37);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Right;
            splitter1.Location = new Point(692, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(27, 37);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // EditForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(978, 561);
            ControlBox = false;
            Controls.Add(mainLayout);
            Controls.Add(formLabel);
            Controls.Add(btnContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditForm";
            Deactivate += EditForm_Deactivate;
            Load += EditForm_Load;
            expirationDateContainer.ResumeLayout(false);
            loanDateContainer.ResumeLayout(false);
            dateLayout.ResumeLayout(false);
            amountContainer.ResumeLayout(false);
            amountContainer.PerformLayout();
            amountLayout.ResumeLayout(false);
            firstNameContainer.ResumeLayout(false);
            firstNameContainer.PerformLayout();
            idLayout.ResumeLayout(false);
            idContainer.ResumeLayout(false);
            idContainer.PerformLayout();
            fullNameLayout.ResumeLayout(false);
            secondNameContainer.ResumeLayout(false);
            secondNameContainer.PerformLayout();
            mainLayout.ResumeLayout(false);
            btnContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button applyBtn;
        private DateTimePicker expirationDatePicker;
        private Panel expirationDateContainer;
        private Label expirationDateLabel;
        private DateTimePicker loanDatePicker;
        private Label loanDateLabel;
        private Panel loanDateContainer;
        private FlowLayoutPanel dateLayout;
        private Label amountLabel;
        private Panel amountContainer;
        private FlowLayoutPanel amountLayout;
        private Label secondNameLabel;
        private Label firstNameLabel;
        private Panel firstNameContainer;
        private FlowLayoutPanel idLayout;
        private Panel idContainer;
        private Label idLabel;
        private FlowLayoutPanel fullNameLayout;
        private Panel secondNameContainer;
        private FlowLayoutPanel mainLayout;
        private Label formLabel;
        private Panel btnContainer;
        private MaskedTextBox firstNameTextBox;
        private MaskedTextBox secondNameTextBox;
        private MaskedTextBox amountTextBox;
        private MaskedTextBox idTextBox;
        private Splitter splitter1;
        private Button deleteBtn;
    }
}