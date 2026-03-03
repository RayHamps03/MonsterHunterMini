using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MonsterHunterMini;

public class Weapon
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
    [Key]
    public int WeaponId { get; set; }

    /// <summary>
    /// The attack stat of the weapon, which determines 
    /// how much damage it can deal to monsters.
    /// </summary>
    public double Attack { get; set; }

    public List<Material>? Materials { get; set; }

}