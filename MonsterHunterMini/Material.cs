using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterHunterMini;

internal class Material
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
    public int MaterialId { get; set; }

    /// <summary>
    /// The name of the material.
    /// </summary>
    public string Name { get; set; }
    
}
