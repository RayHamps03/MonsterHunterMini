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
    protected Material() { }
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
    
}
