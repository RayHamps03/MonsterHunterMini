using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterHunterMini;

internal class Weapons
{
    public Weapon(string weaponName, double weaponAttStat)
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
    public double Attack { get; set; }

    public Material[]? materials { get; set; }

}