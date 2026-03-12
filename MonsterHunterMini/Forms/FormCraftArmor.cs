using Microsoft.EntityFrameworkCore;
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
    public partial class FormCraftArmor : Form
    {
        public FormCraftArmor()
        {
            InitializeComponent();
        }

        private async void FormCraftArmor_Load(object sender, EventArgs e)
        {
            await LoadArmorAsync();
        }

        private async void buttonCraft_Click(object sender, EventArgs e)
        {
            int armorId = (int)listArmor.SelectedValue;

            bool success = await CraftArmorAsync(armorId);

            if (success)
            {
                MessageBox.Show("Successfully crafted armor!");
                await LoadArmorAsync(); // Refresh armor list after crafting
            }
            else
            {
                MessageBox.Show("You do not have the required materials.");
            }
        }

        /// <summary>
        /// Load armor for the player based on their inventory. Only armor that can be crafted with the materials
        /// in the player's inventory will be shown.
        /// </summary>
        private async Task LoadArmorAsync()
        {
            using MonsterHunterMiniDb db = new();
            Player player = await PlayerDb.LoadPlayerAsync(1);
            var playerMaterialNames = player.Inventory
                .Select(m => m.Name)
                .ToList();

            var craftableArmor = await db.Armor
            .Include(a => a.RequiredMaterials)
            .Where(a => a.RequiredMaterials
                .All(req => playerMaterialNames.Contains(req.Name)))
            .ToListAsync();

            listArmor.DisplayMember = "Name";
            listArmor.ValueMember = "ArmorId";
            listArmor.DataSource = craftableArmor;

        }

        public async Task<bool> CraftArmorAsync(int armorId)
        {
            using MonsterHunterMiniDb db = new();

            // Gather Player and Armor data
            var player = await db.Players
                .Include(p => p.Inventory)
                .FirstAsync(p => p.PlayerId == 1);

            var armor = await db.Armor
                .Include(a => a.RequiredMaterials)
                .FirstAsync(a => a.ArmorId == armorId);

            // Extract player material names
            var playerMaterialNames = player.Inventory
                .Select(m => m.Name)
                .ToList();

            // Check if player has all required materials
            if (!armor.RequiredMaterials.All(req => playerMaterialNames.Contains(req.Name)))
            {
                return false;
            }

            // Delete required materials from player's inventory
            foreach (var req in armor.RequiredMaterials)
            {
                var owned = player.Inventory.FirstOrDefault(m => m.Name == req.Name);
                if (owned != null)
                {
                    db.Materials.Remove(owned);
                }
            }

            // Assign armor to player
            armor.PlayerId = player.PlayerId;

            await db.SaveChangesAsync();
            return true;
        }

        
    }
}
