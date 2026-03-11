using MonsterHunterMini.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MonsterHunterMini;

public class Material
{
    // Parameterless constructor required by EF Core at design-time and runtime
    // EF Core can only bind constructor parameters that match mapped properties.
    // Providing a parameterless ctor ensures the framework can create instances.
    public Material() { }
    /// <summary>
    /// Creates a new Material with the given name.
    /// </summary>
    /// <param name="matName">The name given to this material</param>
    public Material(string matName)
    {
        Name = matName;
    }
    /// <summary>
    /// The unique identifier for the material.
    /// </summary>
    
    [Key]
    public int MaterialId { get; set; }

    /// <summary>
    /// The name of the material.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Foreign key property to establish the relationship with the Monster entity.
    /// </summary>
    public int? MonsterId { get; set; }

    /// <summary>
    /// Navigation property to the related Monster entity.
    /// </summary>
    public Monster? Monster { get; set; }

    /// <summary>
    /// Foreign key property to establish the relationship with the Player entity, 
    /// indicating that the player has this material in their inventory.
    /// </summary>
    public int? PlayerId { get; set; }

    /// <summary>
    /// Navigation property to the related Player entity.
    /// </summary>
    public Player? Player { get; set; }

    /// <summary>
    /// Foreign key property to establish relationship with the Armor entity.
    /// </summary>
    public int? ArmorId { get; set; }

    /// <summary>
    /// Navigation property to the related Armor entity.
    /// </summary>
    public Armor? Armor { get; set; }

    /// <summary>
    /// Foreign key property to establish relationship with the Weapon entity.
    /// </summary>
    public int? WeaponId { get; set; }

    /// <summary>
    /// Navigation property to the related Weapon entity.
    /// </summary>
    public Weapon? Weapon { get; set; }

    /// <summary>
    /// Gets or sets the rate at which items are dropped after monster's defeat. Should be 
    /// between 0.0 and 1.0, with 1.0 being 100% drop rate.
    /// </summary>
    public decimal DropRate { get; set; }

}
