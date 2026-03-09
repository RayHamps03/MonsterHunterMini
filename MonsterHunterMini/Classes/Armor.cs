using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MonsterHunterMini;

public class Armor
{
    public Armor() { }

    [SetsRequiredMembers]
    public Armor(string armorName, double armorDefStat)
    {
        Name = armorName;
        Defense = armorDefStat;
    }

    /// <summary>
    /// Name of the armor set.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// The Unique Identifier for the armor set.
    /// </summary>
    [Key]
    public int ArmorId { get; set; }

    /// <summary>
    /// The attack stat of the weapon, which determines 
    /// how much damage it can deal to monsters.
    /// </summary>
    public double Defense { get; set; }

    public List<Material>? Materials { get; set; }

}