namespace Lab4
{
    partial class AddForm
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
            formLabel = new Label();
            idContainer = new Panel();
            idTextBox = new TextBox();
            idLabel = new Label();
            mainLayout = new FlowLayoutPanel();
            idLayout = new FlowLayoutPanel();
            fullNameLayout = new FlowLayoutPanel();
            firstNameContainer = new Panel();
            firstNameTextBox = new MaskedTextBox();
            firstNameLabel = new Label();
            secondNameContainer = new Panel();
            secondNameTextBox = new MaskedTextBox();
            secondNameLabel = new Label();
            amountLayout = new FlowLayoutPanel();
            amountContainer = new Panel();
            amountTextBox = new MaskedTextBox();
            amountLabel = new Label();
            dateLayout = new FlowLayoutPanel();
            loanDateContainer = new Panel();
            loanDatePicker = new DateTimePicker();
            loanDateLabel = new Label();
            expirationDateContainer = new Panel();
            expirationDatePicker = new DateTimePicker();
            expirationDateLabel = new Label();
            btnContainer = new Panel();
            addBtn = new Button();
            idContainer.SuspendLayout();
            mainLayout.SuspendLayout();
            idLayout.SuspendLayout();
            fullNameLayout.SuspendLayout();
            firstNameContainer.SuspendLayout();
            secondNameContainer.SuspendLayout();
            amountLayout.SuspendLayout();
            amountContainer.SuspendLayout();
            dateLayout.SuspendLayout();
            loanDateContainer.SuspendLayout();
            expirationDateContainer.SuspendLayout();
            btnContainer.SuspendLayout();
            SuspendLayout();
            // 
            // formLabel
            // 
            formLabel.Dock = DockStyle.Top;
            formLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            formLabel.Location = new Point(0, 0);
            formLabel.Margin = new Padding(3);
            formLabel.Name = "formLabel";
            formLabel.Size = new Size(866, 50);
            formLabel.TabIndex = 1;
            formLabel.Text = "Add new Debt";
            formLabel.TextAlign = ContentAlignment.MiddleLeft;
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
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            idTextBox.BackColor = SystemColors.Window;
            idTextBox.Location = new Point(29, 11);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(76, 27);
            idTextBox.TabIndex = 1;
            idTextBox.Text = "0";
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
            mainLayout.Size = new Size(866, 403);
            mainLayout.TabIndex = 2;
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
            firstNameTextBox.TabIndex = 1;
            firstNameTextBox.Click += firstNameTextBox_Click;
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
            secondNameTextBox.Location = new Point(135, 12);
            secondNameTextBox.Mask = ">L<??????????";
            secondNameTextBox.Name = "secondNameTextBox";
            secondNameTextBox.PromptChar = ' ';
            secondNameTextBox.Size = new Size(161, 27);
            secondNameTextBox.TabIndex = 2;
            secondNameTextBox.Click += secondNameTextBox_Click;
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
            amountTextBox.InsertKeyMode = InsertKeyMode.Overwrite;
            amountTextBox.Location = new Point(111, 12);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.PromptChar = '0';
            amountTextBox.RejectInputOnFirstFailure = true;
            amountTextBox.Size = new Size(156, 27);
            amountTextBox.TabIndex = 1;
            amountTextBox.Text = "1";
            amountTextBox.TextChanged += amountTextBox_TextChanged;
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
            // loanDatePicker
            // 
            loanDatePicker.Location = new Point(111, 10);
            loanDatePicker.Name = "loanDatePicker";
            loanDatePicker.Size = new Size(156, 27);
            loanDatePicker.TabIndex = 1;
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
            // expirationDatePicker
            // 
            expirationDatePicker.Location = new Point(135, 10);
            expirationDatePicker.Name = "expirationDatePicker";
            expirationDatePicker.Size = new Size(161, 27);
            expirationDatePicker.TabIndex = 1;
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
            // btnContainer
            // 
            btnContainer.Controls.Add(addBtn);
            btnContainer.Dock = DockStyle.Bottom;
            btnContainer.Location = new Point(0, 396);
            btnContainer.Margin = new Padding(3, 3, 20, 20);
            btnContainer.Name = "btnContainer";
            btnContainer.Padding = new Padding(0, 0, 20, 20);
            btnContainer.Size = new Size(866, 57);
            btnContainer.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(0, 192, 0);
            addBtn.Cursor = Cursors.Hand;
            addBtn.Dock = DockStyle.Right;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(607, 0);
            addBtn.Margin = new Padding(3, 3, 10, 3);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(239, 37);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add new Debt";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // AddForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(866, 453);
            ControlBox = false;
            Controls.Add(btnContainer);
            Controls.Add(mainLayout);
            Controls.Add(formLabel);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "AddForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddForm";
            Deactivate += AddForm_Deactivate;
            Load += AddForm_Load;
            idContainer.ResumeLayout(false);
            idContainer.PerformLayout();
            mainLayout.ResumeLayout(false);
            idLayout.ResumeLayout(false);
            fullNameLayout.ResumeLayout(false);
            firstNameContainer.ResumeLayout(false);
            firstNameContainer.PerformLayout();
            secondNameContainer.ResumeLayout(false);
            secondNameContainer.PerformLayout();
            amountLayout.ResumeLayout(false);
            amountContainer.ResumeLayout(false);
            amountContainer.PerformLayout();
            dateLayout.ResumeLayout(false);
            loanDateContainer.ResumeLayout(false);
            expirationDateContainer.ResumeLayout(false);
            btnContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label formLabel;
        private Panel idContainer;
        private TextBox idTextBox;
        private Label idLabel;
        private FlowLayoutPanel mainLayout;
        private FlowLayoutPanel fullNameLayout;
        private Panel firstNameContainer;
        private Label firstNameLabel;
        private Panel secondNameContainer;
        private Label secondNameLabel;
        private FlowLayoutPanel idLayout;
        private FlowLayoutPanel amountLayout;
        private Panel amountContainer;
        private Label amountLabel;
        private FlowLayoutPanel dateLayout;
        private Panel loanDateContainer;
        private DateTimePicker loanDatePicker;
        private Label loanDateLabel;
        private Panel expirationDateContainer;
        private DateTimePicker expirationDatePicker;
        private Label expirationDateLabel;
        private Panel btnContainer;
        private Button addBtn;
        private MaskedTextBox amountTextBox;
        private MaskedTextBox firstNameTextBox;
        private MaskedTextBox secondNameTextBox;
    }
}