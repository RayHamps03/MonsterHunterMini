using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MonsterHunterMini.Database;
using MonsterHunterMini;

namespace MonsterHunterMini.Forms
{
    public partial class QuestSelect : Form
    {
        public QuestSelect()
        {
            InitializeComponent();
            buttonStart.Click += buttonStart_Click;
        }


        private async void QuestSelect_Load(object sender, EventArgs e)
        {
            // Load monsters from the database and bind to the list box
            _ = LoadMonstersAsync();
        }

        /// <summary>
        /// Asynchronously loads the list of monsters from the database and binds them to the quest selection list.
        /// </summary>
        /// <remarks>This method retrieves all available monsters using the MonsterDb and sets the display
        /// and value members for the quest selection list.</remarks>
        private async Task LoadMonstersAsync()
        {
            List<Monster> monsters = await MonsterDb.GetAllMonstersAsync();
            listQuests.DisplayMember = "Name";
            listQuests.ValueMember = "MonsterId";
            listQuests.DataSource = monsters;
        }

        private async void buttonStart_Click(object? sender, EventArgs e)
        {
            // Get the selected monster and load the player data
            Monster? selected = listQuests.SelectedItem as Monster;
            Player player = await PlayerDb.LoadPlayerAsync(1);

            if (selected == null)
            {
                MessageBox.Show("Please select a monster to hunt.");
                return;
            }

            // Open the battle form for the selected monster
            FormBattle battle = new FormBattle(selected, player);
            battle.Show();
            this.Close();
        }
    }
}
