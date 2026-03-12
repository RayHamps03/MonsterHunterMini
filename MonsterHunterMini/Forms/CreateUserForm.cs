using MonsterHunterMini.Classes;
using MonsterHunterMini.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MonsterHunterMini.Forms
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            using MonsterHunterMiniDb db = new();

            Player player = new(txtPlayerName.Text);

            // Add player to database if input is valid
            if (IsValidateInput())
            {
                db.Players.Add(player);
                await db.SaveChangesAsync();

                MessageBox.Show($"Welcome, {player.Name}");

                this.Close();
            }
            
        }

        /// <summary>
        /// Validates the player name input to ensure it is not empty and does not exceed 20 characters.
        /// </summary>
        /// <returns>true if the player name input is valid; otherwise, false.</returns>
        private bool IsValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtPlayerName.Text))
            {
                MessageBox.Show("Please enter a valid player name.");
                return false;
            }
            else if (txtPlayerName.Text.Length > 20)
            {
                MessageBox.Show("Player name must be 20 characters or less.");
                return false;
            }
            return true;
        }
    }
}
