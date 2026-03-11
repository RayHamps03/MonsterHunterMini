using Microsoft.EntityFrameworkCore;
using MonsterHunterMini.Classes;
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

        modelBuilder.Entity<Armor>().HasData(
            new Armor { ArmorId = 1, Name = "Rathalos Set", Defense = 12 },
            new Armor { ArmorId = 2, Name = "Rathian Set", Defense = 10 },
            new Armor { ArmorId = 3, Name = "Diablos Set", Defense = 15 }
        );

        modelBuilder.Entity<Weapon>().HasData(
            new Weapon { WeaponId = 1, Name = "Rathalos Greatsword", Attack = 10 },
            new Weapon { WeaponId = 2, Name = "Rathian Greatsword", Attack = 9 },
            new Weapon { WeaponId = 3, Name = "Diablos Greatsword", Attack = 12 }


        );

        // Seed the database with Materials
        modelBuilder.Entity<Material>().HasData(
            new Material { MaterialId = 1, Name = "Rathalos Scale", MonsterId = 1, ArmorId = 1, WeaponId = 1, DropRate = 0.6m},
            new Material { MaterialId = 2, Name = "Rathalos Tail", MonsterId = 1, ArmorId = 1, WeaponId = 1, DropRate = 0.5m},
            new Material { MaterialId = 3, Name = "Rathalos Webbing", MonsterId = 1, ArmorId = 1, WeaponId = 1, DropRate = 0.4m},
            new Material { MaterialId = 4, Name = "Rathian Scale", MonsterId = 2, ArmorId = 2, WeaponId = 2, DropRate = 0.6m},
            new Material { MaterialId = 5, Name = "Rathian Tail", MonsterId = 2, ArmorId = 2, WeaponId = 2, DropRate = 0.5m},
            new Material { MaterialId = 6, Name = "Rathian Webbing", MonsterId = 2, ArmorId = 2, WeaponId = 2, DropRate = 0.4m},
            new Material { MaterialId = 7, Name = "Diablos Ridge", MonsterId = 3, ArmorId = 3, WeaponId = 3, DropRate = 0.6m},
            new Material { MaterialId = 8, Name = "Diablos Tailcase", MonsterId = 3, ArmorId = 3, WeaponId = 3, DropRate = 0.4m},
            new Material { MaterialId = 9, Name = "Twisted Horn", MonsterId = 3, ArmorId = 3, WeaponId = 3, DropRate = 0.25m}
        );

        
        
    }

    // Track entities in the database 
    public DbSet<Monster> Monsters { get; set; }

    public DbSet<Player> Players { get; set; }

}
