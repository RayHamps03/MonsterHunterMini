using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterHunterMini;

internal class Weapons
{
    public Weapons(string weaponName, int weaponAttStat)
    {
        Name = weaponName;
        Attack = weaponAttStat;
    }

    /// <summary>
    /// Name of the weapon.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The Unique Identifier for the weapon.
    /// </summary>
    public int weaponID { get; set; }

    /// <summary>
    /// The attack stat of the weapon, which determines 
    /// how much damage it can deal to monsters.
    /// </summary>
    public int Attack { get; set; }

    public List<Material>? materials { get; set; }

}