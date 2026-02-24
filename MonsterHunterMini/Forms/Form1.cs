namespace MonsterHunterMini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo();
            info.Show();
            this.Hide();
        }
    }
}
