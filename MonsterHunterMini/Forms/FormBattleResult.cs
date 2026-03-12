using Microsoft.EntityFrameworkCore;
using MonsterHunterMini.Classes;
using MonsterHunterMini.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MonsterHunterMini.Forms
{
    public partial class FormBattleResult : Form
    {
        public FormBattleResult()
        {
            InitializeComponent();
        }

        public FormBattleResult(Monster hunted) : this()
        {
            HuntedMonster = hunted;
        }

        private async void FormBattleResult_Load(object sender, EventArgs e)
        {
            p1 = await PlayerDb.LoadPlayerAsync(1);
            drops = GetMonsterDrops(HuntedMonster);
            LoadDrops();
        }

        Player p1;
        Monster HuntedMonster;
        List<Material> drops;

        /// <summary>
        /// Uses a random number generator to determine if each material is dropped
        /// based on its associated drop rate.
        /// </summary>
        /// <param name="monster">The monster whose drops are to be calculated. Must not be null.</param>
        /// <returns>A list of materials that the monster drops, which may be empty if no materials are dropped.</returns>
        public List<Material> GetMonsterDrops(Monster monster)
        {
            Random rng = new();
            List<Material> drops = new();

            foreach (var material in monster.Drops)
            {
                double chance = (double)material.DropRate;

                if (rng.NextDouble() <= chance)
                {
                    drops.Add(material);

                }
            }
            return drops;
        }

        /// <summary>
        /// Adds the materials dropped by the specified monster to the player's inventory and persists the changes
        /// asynchronously.
        /// </summary>
        /// <remarks>This method retrieves the drops associated with the specified monster and adds them
        /// to the player's inventory. Changes are saved asynchronously to the database.</remarks>
        /// <param name="player">The player whose inventory will receive the monster's drops. Must not be null and must have a valid
        /// inventory.</param>
        /// <param name="monster">The monster from which the drops are obtained. The drops are determined based on the monster's
        /// characteristics.</param>
        /// <returns>A task that represents the asynchronous operation of granting drops and saving changes to the database.</returns>
        public async Task GrantDrops(Player player, Monster monster)
        {
            using MonsterHunterMiniDb db = new();

            foreach (var material in drops)
            {
                // Ensure the player has an inventory collection
                player.Inventory ??= new List<Material>();

                // If the player already has this material (by name), skip adding to avoid duplicates
                bool alreadyHas = player.Inventory.Any(m => string.Equals(m.Name, material.Name, StringComparison.OrdinalIgnoreCase));
                if (alreadyHas)
                    continue;

                // Create a new material instance for the player's inventory so we don't modify the original
                var newMat = new Material
                {
                    Name = material.Name,
                    DropRate = material.DropRate,
                    PlayerId = player.PlayerId
                };

                player.Inventory.Add(newMat);
            }

            await db.SaveChangesAsync();
        }

        /// <summary>
        /// Binds the available drop materials to the materials list control for display.
        /// </summary>
        public void LoadDrops()
        {
            listMaterials.DisplayMember = "Name";
            listMaterials.ValueMember = "MaterialId";
            listMaterials.DataSource = drops;
        }

        /// <summary>
        /// Adds the current collection of drops to the player's inventory and persists the changes to
        /// the database.
        /// </summary>
        /// <returns>A task that represents the asynchronous save operation.</returns>
        public async Task SaveDrops()
        {
            using MonsterHunterMiniDb db = new();

            var player = await db.Players
                .Include(p => p.Inventory)
                .FirstAsync(p => p.PlayerId == p1.PlayerId);


            foreach (var mat in drops)
            {
                // Ensure inventory exists
                player.Inventory ??= new List<Material>();

                // If the player already has this material, skip adding to prevent duplicates
                bool exists = player.Inventory.Any(m => string.Equals(m.Name, mat.Name, StringComparison.OrdinalIgnoreCase));
                if (exists)
                    continue;

                // Create a new material for the player's inventory instead of reusing the monster material
                var newMat = new Material
                {
                    Name = mat.Name,
                    DropRate = mat.DropRate,
                    PlayerId = player.PlayerId
                };

                player.Inventory.Add(newMat);
            }

            drops.Clear(); // Clear the drops list after adding them to the player's inventory

            await db.SaveChangesAsync();
        }

        private async void buttonCollect_Click(object sender, EventArgs e)
        {
            await SaveDrops();
            Form1 main = new();
            this.Close();
            main.Show();

        }
    }
}
