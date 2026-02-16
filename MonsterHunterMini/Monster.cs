using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterHunterMini;

internal class Monster
{

    /// <summary>
    /// Creates a new Monster with the specified name, attack and defense statistics, and drop
    /// materials.
    /// </summary>
    /// <param name="monstName">The name of the monster. Cannot be null or empty.</param>
    /// <param name="monstAttStat">The attack statistic value for the monster.</param>
    /// <param name="monstDefStat">The defense statistic value for the monster.</param>
    /// <param name="materials">An array of materials that the monster can drop. Cannot be null.</param>
    public Monster(string monstName, int monstAttStat, int monstDefStat, List<Material> materials)
    {
        Name = monstName;
        Attack = monstAttStat;
        Defense = monstDefStat;
        Drops = materials;
    }
    /// <summary>
    /// The unique identifier for the monster.
    /// </summary>
    public int MonsterId { get; set; }
    /// <summary>
    /// The name of the monster.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// The attack stat of the monster, used to determine
    /// how much damage is dealt to the player.
    /// </summary>
    public int Attack { get; set; }
    /// <summary>
    /// The defense stat of the monster, used to determine
    /// the monster's resistance to the player's attacks.
    /// </summary>
    public int Defense { get; set; }

    public List<Material>? Drops { get; set; }
}
