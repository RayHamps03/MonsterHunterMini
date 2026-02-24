using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterHunterMini
{
    internal class Player
    {
        /// <summary>
        /// Initializes a new instance of the Player class with the specified player name, equipping a default weapon
        /// and armor.
        /// </summary>
        /// <remarks>The player is initialized with a default weapon, 'Bone Sword', and default armor,
        /// 'Hunter's Set'. These starting items can be changed as the game progresses.</remarks>
        /// <param name="playerName">The name of the player. This value is used to identify the player within the game.</param>
        public Player(string playerName)
        {
            Name = playerName;
            // Starting weapon and armor for the player, can be changed later on.
            EquippedWeapon = new Weapon("Bone Sword", 2.5);
            EquippedArmor = new Armor("Hunter's Set", 2.5);
        }

        /// <summary>
        /// The unique identifier for the player. 
        /// Used to track the player's progress, inventory, and other game-related data.
        /// </summary>
        public int PlayerId { get; set; }

        /// <summary>
        /// The name of the player. This value is inputted by the user.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The current equipped weapon of the player used as a factor to determine 
        /// the player's chance at victory.
        /// </summary>
        public Weapon EquippedWeapon { get; set; }
        /// <summary>
        /// The current equipped armor of the player used as a factor to determine
        /// the player's chance at victory.
        /// </summary>
        public Armor EquippedArmor { get; set; }
        /// <summary>
        /// A list of materials that the player has collected through defeating monsters.
        /// </summary>
        public List<Material>? Inventory { get; set; }


    }
}
