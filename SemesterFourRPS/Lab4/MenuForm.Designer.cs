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
            sideBarMenu = new FlowLayoutPanel();
            showMenu = new Panel();
            menuIcon = new PictureBox();
            listPanel = new Panel();
            listLabel = new Label();
            listIcon = new PictureBox();
            addPanel = new Panel();
            addLabel = new Label();
            newIcon = new PictureBox();
            editDebtPanel = new Panel();
            editLabel = new Label();
            editIcon = new PictureBox();
            menuTransition = new System.Windows.Forms.Timer(components);
            sideBarMenu.SuspendLayout();
            showMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuIcon).BeginInit();
            listPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listIcon).BeginInit();
            addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)newIcon).BeginInit();
            editDebtPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editIcon).BeginInit();
            SuspendLayout();
            // 
            // sideBarMenu
            // 
            sideBarMenu.BackColor = Color.FromArgb(40, 40, 40);
            sideBarMenu.Controls.Add(showMenu);
            sideBarMenu.Controls.Add(listPanel);
            sideBarMenu.Controls.Add(addPanel);
            sideBarMenu.Controls.Add(editDebtPanel);
            sideBarMenu.Dock = DockStyle.Left;
            sideBarMenu.FlowDirection = FlowDirection.TopDown;
            sideBarMenu.Location = new Point(0, 0);
            sideBarMenu.Name = "sideBarMenu";
            sideBarMenu.Padding = new Padding(0, 0, 0, 10);
            sideBarMenu.Size = new Size(55, 564);
            sideBarMenu.TabIndex = 0;
            // 
            // showMenu
            // 
            showMenu.BackColor = Color.FromArgb(40, 40, 40);
            showMenu.Controls.Add(menuIcon);
            showMenu.Dock = DockStyle.Left;
            showMenu.Location = new Point(3, 3);
            showMenu.Margin = new Padding(3, 3, 3, 10);
            showMenu.Name = "showMenu";
            showMenu.Size = new Size(280, 50);
            showMenu.TabIndex = 0;
            // 
            // menuIcon
            // 
            menuIcon.Cursor = Cursors.Hand;
            menuIcon.Dock = DockStyle.Left;
            menuIcon.Image = Properties.Resources.menu_small;
            menuIcon.Location = new Point(0, 0);
            menuIcon.Name = "menuIcon";
            menuIcon.Size = new Size(50, 50);
            menuIcon.TabIndex = 0;
            menuIcon.TabStop = false;
            menuIcon.Click += menuIcon_Click;
            // 
            // listPanel
            // 
            listPanel.BackColor = Color.FromArgb(40, 40, 40);
            listPanel.Controls.Add(listLabel);
            listPanel.Controls.Add(listIcon);
            listPanel.Dock = DockStyle.Left;
            listPanel.Location = new Point(3, 66);
            listPanel.Margin = new Padding(3, 3, 3, 10);
            listPanel.Name = "listPanel";
            listPanel.Size = new Size(280, 50);
            listPanel.TabIndex = 1;
            // 
            // listLabel
            // 
            listLabel.BackColor = Color.FromArgb(40, 40, 40);
            listLabel.Cursor = Cursors.Hand;
            listLabel.Dock = DockStyle.Fill;
            listLabel.Font = new Font("Segoe UI", 10.2F);
            listLabel.ForeColor = Color.White;
            listLabel.Location = new Point(50, 0);
            listLabel.Name = "listLabel";
            listLabel.Size = new Size(230, 50);
            listLabel.TabIndex = 3;
            listLabel.Text = "Show list";
            listLabel.TextAlign = ContentAlignment.MiddleLeft;
            listLabel.Click += listLabel_Click;
            // 
            // listIcon
            // 
            listIcon.BackColor = Color.FromArgb(40, 40, 40);
            listIcon.Dock = DockStyle.Left;
            listIcon.Image = Properties.Resources.list_small;
            listIcon.Location = new Point(0, 0);
            listIcon.Name = "listIcon";
            listIcon.Size = new Size(50, 50);
            listIcon.TabIndex = 2;
            listIcon.TabStop = false;
            // 
            // addPanel
            // 
            addPanel.BackColor = Color.FromArgb(40, 40, 40);
            addPanel.Controls.Add(addLabel);
            addPanel.Controls.Add(newIcon);
            addPanel.Dock = DockStyle.Left;
            addPanel.Location = new Point(3, 129);
            addPanel.Margin = new Padding(3, 3, 3, 10);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(280, 50);
            addPanel.TabIndex = 2;
            // 
            // addLabel
            // 
            addLabel.BackColor = Color.FromArgb(40, 40, 40);
            addLabel.Cursor = Cursors.Hand;
            addLabel.Dock = DockStyle.Fill;
            addLabel.Font = new Font("Segoe UI", 10.2F);
            addLabel.ForeColor = Color.White;
            addLabel.Location = new Point(50, 0);
            addLabel.Name = "addLabel";
            addLabel.Size = new Size(230, 50);
            addLabel.TabIndex = 3;
            addLabel.Text = "Add new Debt";
            addLabel.TextAlign = ContentAlignment.MiddleLeft;
            addLabel.Click += addLabel_Click;
            // 
            // newIcon
            // 
            newIcon.BackColor = Color.FromArgb(40, 40, 40);
            newIcon.Dock = DockStyle.Left;
            newIcon.Image = Properties.Resources.add_small;
            newIcon.Location = new Point(0, 0);
            newIcon.Name = "newIcon";
            newIcon.Size = new Size(50, 50);
            newIcon.TabIndex = 2;
            newIcon.TabStop = false;
            // 
            // editDebtPanel
            // 
            editDebtPanel.BackColor = Color.FromArgb(40, 40, 40);
            editDebtPanel.Controls.Add(editLabel);
            editDebtPanel.Controls.Add(editIcon);
            editDebtPanel.Dock = DockStyle.Left;
            editDebtPanel.Location = new Point(3, 192);
            editDebtPanel.Margin = new Padding(3, 3, 3, 10);
            editDebtPanel.Name = "editDebtPanel";
            editDebtPanel.Size = new Size(280, 50);
            editDebtPanel.TabIndex = 2;
            // 
            // editLabel
            // 
            editLabel.BackColor = Color.FromArgb(40, 40, 40);
            editLabel.Cursor = Cursors.Hand;
            editLabel.Dock = DockStyle.Fill;
            editLabel.Font = new Font("Segoe UI", 10.2F);
            editLabel.ForeColor = Color.White;
            editLabel.Location = new Point(50, 0);
            editLabel.Name = "editLabel";
            editLabel.Size = new Size(230, 50);
            editLabel.TabIndex = 3;
            editLabel.Text = "Edit Debt";
            editLabel.TextAlign = ContentAlignment.MiddleLeft;
            editLabel.Click += editLabel_Click;
            // 
            // editIcon
            // 
            editIcon.BackColor = Color.FromArgb(40, 40, 40);
            editIcon.Dock = DockStyle.Left;
            editIcon.Image = Properties.Resources.edit_small;
            editIcon.Location = new Point(0, 0);
            editIcon.Name = "editIcon";
            editIcon.Size = new Size(50, 50);
            editIcon.TabIndex = 2;
            editIcon.TabStop = false;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 5;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // DBForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(966, 564);
            Controls.Add(sideBarMenu);
            IsMdiContainer = true;
            Name = "DBForm";
            Text = "Lab4";
            Load += DBForm_Load;
            sideBarMenu.ResumeLayout(false);
            showMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuIcon).EndInit();
            listPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listIcon).EndInit();
            addPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)newIcon).EndInit();
            editDebtPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)editIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sideBarMenu;
        private Panel showMenu;
        private PictureBox menuIcon;
        private Panel listPanel;
        private Panel addPanel;
        private Panel editDebtPanel;
        private System.Windows.Forms.Timer menuTransition;
        private PictureBox listIcon;
        private PictureBox newIcon;
        private PictureBox editIcon;
        private Label addLabel;
        private Label listLabel;
        private Label editLabel;
    }
}
