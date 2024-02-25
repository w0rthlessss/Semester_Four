namespace Lab4
{
    public partial class DBForm : Form
    {
        AddForm? addDebt;
        EditForm? editDebt;
        ListForm? debtList;
        public DBForm()
        {
            InitializeComponent();
        }

        bool isMenuOpen = true;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (isMenuOpen)
            {
                sideBarMenu.Width -= 15;

                if (sideBarMenu.Width <= 55)
                {
                    sideBarMenu.Width = 55;
                    isMenuOpen = false;
                    menuTransition.Stop();
                }
            }
            else
            {
                sideBarMenu.Width += 15;

                if (sideBarMenu.Width >= 280)
                {
                    sideBarMenu.Width = 280;
                    isMenuOpen = true;
                    menuTransition.Stop();
                }
            }
        }

        private void menuIcon_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void OpenDebtListForm()
        {
            if (debtList == null)
            {
                debtList = new ListForm();
                debtList.FormClosed += DebtList_FormClosed;
                debtList.MdiParent = this;
                debtList.Show();
            }
            else debtList.Activate();

            debtList.Dock = DockStyle.Fill;
        }

        private void listLabel_Click(object sender, EventArgs e)
        {
            OpenDebtListForm();
        }

        private void DebtList_FormClosed(object? sender, FormClosedEventArgs e)
            => debtList = null;

        private void addLabel_Click(object sender, EventArgs e)
        {
            if (addDebt == null)
            {
                addDebt = new AddForm();
                addDebt.FormClosed += AddDebt_FormClosed;
                addDebt.MdiParent = this;
                addDebt.Show();
            }
            else addDebt.Activate();

            addDebt.Dock = DockStyle.Fill;
        }

        private void AddDebt_FormClosed(object? sender, FormClosedEventArgs e)
            => addDebt = null;

        private void editLabel_Click(object sender, EventArgs e)
        {
            if (editDebt == null)
            {
                editDebt = new EditForm();
                editDebt.FormClosed += EditDebt_FormClosed;
                editDebt.MdiParent = this;
                editDebt.Show();
            }
            else editDebt.Activate();

            editDebt.Dock = DockStyle.Fill;
        }

        private void EditDebt_FormClosed(object? sender, FormClosedEventArgs e)
            => editDebt = null;

        private void DBForm_Load(object sender, EventArgs e)
        {
            OpenDebtListForm();
        }
    }


}
