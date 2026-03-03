using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MonsterHunterMini;

public class Material
{
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
    public string Name { get; set; }
    
}
