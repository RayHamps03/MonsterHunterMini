using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MonsterHunterMini.Database;

public class MonsterHunterMiniDb : DbContext 
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog =MonsterHunterMiniDb; Integrated Security = True; Encrypt = False; Trust Server Certificate = False;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed the database with Monsters 
        modelBuilder.Entity<Monster>().HasData(
            new Monster { MonsterId = 1, Name = "Rathalos", Attack = 7, Defense = 7},
            new Monster { MonsterId = 2, Name = "Rathian", Attack = 9, Defense = 7},
            new Monster { MonsterId = 3, Name = "Diablos", Attack = 6, Defense = 7 },
            new Monster { MonsterId = 4, Name = "Velocidrome", Attack = 3, Defense = 3},
            new Monster { MonsterId = 5, Name = "Yian-Kut-Ku", Attack = 4, Defense = 4 },
            new Monster { MonsterId = 6, Name = "Iodrome", Attack = 4, Defense = 3}
        );

        // Seed the database with Materials
        modelBuilder.Entity<Material>().HasData(
            new Material { MaterialId = 1, Name = "Rathalos Scale"},
            new Material { MaterialId = 2, Name = "Rathalos Tail" },
            new Material { MaterialId = 3, Name = "Rathalos Webbing" },
            new Material { MaterialId = 4, Name = "Rathian Scale"},
            new Material { MaterialId = 5, Name = "Rathian Tail" },
            new Material { MaterialId = 6, Name = "Rathian Webbing" },
            new Material { MaterialId = 7, Name = "Diablos Ridge" },
            new Material { MaterialId = 8, Name = "Diablos Tailcase" },
            new Material { MaterialId = 9, Name = "Twisted Horn" }
        );

        
    }

    // Track entities in the database 
    public DbSet<Monster> Monsters { get; set; }

    public DbSet<Player> Players { get; set; }

}
