using Microsoft.EntityFrameworkCore;
using MonsterHunterMini.Database;
using MonsterHunterMini.Forms;

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

        private async void buttonPlay_Click(object sender, EventArgs e)
        {
            using MonsterHunterMiniDb db = new();

            // Checks if there are any users in the database
            bool userExists = await db.Players.AnyAsync();

            if (!userExists)
            {
                // Create user if no user exists in the database
                CreateUserForm newUser = new();
                newUser.ShowDialog();
                return;
            }
            else
            {
                QuestSelect battle = new QuestSelect();
                battle.Show();
                this.Hide();
            }


        }

        private void buttonCraftUpgrade_Click(object sender, EventArgs e)
        {
            FormCraftUpgradeSelect craftUpgradeSelect = new FormCraftUpgradeSelect();
            craftUpgradeSelect.Show();
            this.Hide();
        }
    }
}
