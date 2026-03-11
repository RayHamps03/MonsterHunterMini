using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MonsterHunterMini.Database
{
    public class PlayerDb
    {
        /// <summary>
        /// Adds a player to the database and saves the changes.
        /// </summary>
        /// <remarks>Ensure that the player does not already exist in the database to prevent duplicate
        /// entries.</remarks>
        /// <param name="player">The player to add to the database. Cannot be null.</param>
        /// <returns>A task that represents the asynchronous add operation.</returns>
        public static async Task AddAsync(Player player)
        {
            using MonsterHunterMiniDb db = new();
            db.Players.Add(player);
            await db.SaveChangesAsync();
        }

        /// <summary>
        /// Retrieves a player from the database by the specified player ID, including the player's
        /// equipped weapon, equipped armor, and inventory.
        /// </summary>
        /// <param name="id">The unique identifier of the player to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the loaded Player object.</returns>
        public static async Task<Player> LoadPlayerAsync(int id)
        {
            using MonsterHunterMiniDb db = new();

            return await db.Players
                .Include(p => p.EquippedWeapon)
                .Include(p => p.EquippedArmor)
                .Include(p => p.Inventory)
                .FirstAsync(p => p.PlayerId == id);
        }
    }
}
