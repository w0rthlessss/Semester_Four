namespace Lab4
{
    partial class DBForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBForm));
            sideBarMenu = new FlowLayoutPanel();
            showMenu = new Panel();
            menuIcon = new PictureBox();
            listPanel = new Panel();
            listOfDebts = new Label();
            listIcon = new PictureBox();
            addPanel = new Panel();
            addNewDebt = new Label();
            addIcon = new PictureBox();
            editDebtPanel = new Panel();
            editDebt = new Label();
            editIcon = new PictureBox();
            menuTransition = new System.Windows.Forms.Timer(components);
            sideBarMenu.SuspendLayout();
            showMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuIcon).BeginInit();
            listPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listIcon).BeginInit();
            addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addIcon).BeginInit();
            editDebtPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editIcon).BeginInit();
            SuspendLayout();
            // 
            // sideBarMenu
            // 
            sideBarMenu.BackColor = Color.DimGray;
            sideBarMenu.Controls.Add(showMenu);
            sideBarMenu.Controls.Add(listPanel);
            sideBarMenu.Controls.Add(addPanel);
            sideBarMenu.Controls.Add(editDebtPanel);
            sideBarMenu.Dock = DockStyle.Left;
            sideBarMenu.FlowDirection = FlowDirection.TopDown;
            sideBarMenu.Location = new Point(0, 0);
            sideBarMenu.Name = "sideBarMenu";
            sideBarMenu.Size = new Size(280, 564);
            sideBarMenu.TabIndex = 0;
            // 
            // showMenu
            // 
            showMenu.BackColor = Color.DarkGray;
            showMenu.Controls.Add(menuIcon);
            showMenu.Location = new Point(3, 3);
            showMenu.Name = "showMenu";
            showMenu.Size = new Size(280, 50);
            showMenu.TabIndex = 0;
            // 
            // menuIcon
            // 
            menuIcon.Dock = DockStyle.Left;
            menuIcon.Image = Properties.Resources.menu;
            menuIcon.Location = new Point(0, 0);
            menuIcon.Name = "menuIcon";
            menuIcon.Size = new Size(50, 50);
            menuIcon.TabIndex = 0;
            menuIcon.TabStop = false;
            menuIcon.Click += menuIcon_Click;
            // 
            // listPanel
            // 
            listPanel.BackColor = SystemColors.AppWorkspace;
            listPanel.Controls.Add(listOfDebts);
            listPanel.Controls.Add(listIcon);
            listPanel.Location = new Point(3, 59);
            listPanel.Name = "listPanel";
            listPanel.Size = new Size(280, 50);
            listPanel.TabIndex = 1;
            // 
            // listOfDebts
            // 
            listOfDebts.Dock = DockStyle.Fill;
            listOfDebts.Location = new Point(50, 0);
            listOfDebts.Margin = new Padding(3);
            listOfDebts.Name = "listOfDebts";
            listOfDebts.Size = new Size(230, 50);
            listOfDebts.TabIndex = 1;
            listOfDebts.Text = "Show list";
            listOfDebts.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listIcon
            // 
            listIcon.Dock = DockStyle.Left;
            listIcon.Image = (Image)resources.GetObject("listIcon.Image");
            listIcon.Location = new Point(0, 0);
            listIcon.Name = "listIcon";
            listIcon.Size = new Size(50, 50);
            listIcon.TabIndex = 0;
            listIcon.TabStop = false;
            // 
            // addPanel
            // 
            addPanel.BackColor = SystemColors.AppWorkspace;
            addPanel.Controls.Add(addNewDebt);
            addPanel.Controls.Add(addIcon);
            addPanel.Location = new Point(3, 115);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(280, 50);
            addPanel.TabIndex = 2;
            // 
            // addNewDebt
            // 
            addNewDebt.Dock = DockStyle.Fill;
            addNewDebt.Location = new Point(50, 0);
            addNewDebt.Margin = new Padding(3);
            addNewDebt.Name = "addNewDebt";
            addNewDebt.Size = new Size(230, 50);
            addNewDebt.TabIndex = 1;
            addNewDebt.Text = "Add New Debt";
            addNewDebt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addIcon
            // 
            addIcon.Dock = DockStyle.Left;
            addIcon.Image = (Image)resources.GetObject("addIcon.Image");
            addIcon.Location = new Point(0, 0);
            addIcon.Name = "addIcon";
            addIcon.Size = new Size(50, 50);
            addIcon.TabIndex = 0;
            addIcon.TabStop = false;
            // 
            // editDebtPanel
            // 
            editDebtPanel.BackColor = SystemColors.AppWorkspace;
            editDebtPanel.Controls.Add(editDebt);
            editDebtPanel.Controls.Add(editIcon);
            editDebtPanel.Location = new Point(3, 171);
            editDebtPanel.Name = "editDebtPanel";
            editDebtPanel.Size = new Size(280, 50);
            editDebtPanel.TabIndex = 2;
            // 
            // editDebt
            // 
            editDebt.Dock = DockStyle.Fill;
            editDebt.Location = new Point(50, 0);
            editDebt.Margin = new Padding(3);
            editDebt.Name = "editDebt";
            editDebt.Size = new Size(230, 50);
            editDebt.TabIndex = 1;
            editDebt.Text = "Edit Debt";
            editDebt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editIcon
            // 
            editIcon.Dock = DockStyle.Left;
            editIcon.Image = (Image)resources.GetObject("editIcon.Image");
            editIcon.Location = new Point(0, 0);
            editIcon.Name = "editIcon";
            editIcon.Size = new Size(50, 50);
            editIcon.TabIndex = 0;
            editIcon.TabStop = false;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // DBForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 564);
            Controls.Add(sideBarMenu);
            Name = "DBForm";
            Text = "Lab4";
            sideBarMenu.ResumeLayout(false);
            showMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuIcon).EndInit();
            listPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listIcon).EndInit();
            addPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addIcon).EndInit();
            editDebtPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)editIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sideBarMenu;
        private Panel showMenu;
        private PictureBox menuIcon;
        private Panel listPanel;
        private PictureBox listIcon;
        private Label listOfDebts;
        private Panel addPanel;
        private Label addNewDebt;
        private PictureBox addIcon;
        private Panel editDebtPanel;
        private Label editDebt;
        private PictureBox editIcon;
        private System.Windows.Forms.Timer menuTransition;
    }
}
