using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterHunterMini;

internal class Armor
{
    public Armor(string armorName, int armorDefStat)
    {
        Name = armorName;
        Defense = armorDefStat;
    }

    /// <summary>
    /// Name of the armor set.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The Unique Identifier for the armor set.
    /// </summary>
    public int weaponID { get; set; }

    /// <summary>
    /// The attack stat of the weapon, which determines 
    /// how much damage it can deal to monsters.
    /// </summary>
    public int Defense { get; set; }

    public Material[]? materials { get; set; }

}