using MonsterHunterMini.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MonsterHunterMini;

public class Weapon
{
    public Weapon() { }

    [SetsRequiredMembers]
    public Weapon(string weaponName, double weaponAttStat)
    {
        Name = weaponName;
        Attack = weaponAttStat;
    }

    /// <summary>
    /// Name of the weapon.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// The Unique Identifier for the weapon.
    /// </summary>
    [Key]
    public int WeaponId { get; set; }

    /// <summary>
    /// The attack stat of the weapon, which determines 
    /// how much damage it can deal to monsters.
    /// </summary>
    public double Attack { get; set; }

    /// <summary>
    /// Foreign key property representing the relationship between the Weapons and
    /// Player entities, indicating that the player owns this weapon.
    /// </summary>
    public int? PlayerId { get; set; }

    /// <summary>
    /// Navigation property for the related Player entity.
    /// </summary>
    public Player? Player { get; set; }

    public List<Material>? RequiredMaterials { get; set; }

}