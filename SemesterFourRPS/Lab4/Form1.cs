namespace Lab4
{
    public partial class DBForm : Form
    {
        public DBForm()
        {
            InitializeComponent();
        }

        bool isMenuOpen = true;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (isMenuOpen)
            {
                sideBarMenu.Width -= 10;

                if (sideBarMenu.Width == 50)
                {
                    isMenuOpen = false;
                    menuTransition.Stop();
                } 
            }
            else
            {
                sideBarMenu.Width += 10;

                if (sideBarMenu.Width == 280)
                {
                    isMenuOpen = true;
                    menuTransition.Stop();
                }
            }
        }

        private void menuIcon_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
    }


}
