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
            new Monster { MonsterId = 1, Name = "Rathalos", Attack = 7, Defense = 7 },
            new Monster { MonsterId = 2, Name = "Rathian", Attack = 9, Defense = 7 },
            new Monster { MonsterId = 3, Name = "Diablos", Attack = 6, Defense = 7 },
            new Monster { MonsterId = 4, Name = "Velocidrome", Attack = 3, Defense = 3 },
            new Monster { MonsterId = 5, Name = "Yian-Kut-Ku", Attack = 4, Defense = 4 },
            new Monster { MonsterId = 6, Name = "Iodrome", Attack = 4, Defense = 3 }
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
            new Material { MaterialId = 1, Name = "Rathalos Scale", MonsterId = 1, DropRate = 0.6m },
            new Material { MaterialId = 2, Name = "Rathalos Tail", MonsterId = 1, DropRate = 0.5m },
            new Material { MaterialId = 3, Name = "Rathalos Webbing", MonsterId = 1, DropRate = 0.4m },
            new Material { MaterialId = 4, Name = "Rathian Scale", MonsterId = 2, DropRate = 0.6m },
            new Material { MaterialId = 5, Name = "Rathian Tail", MonsterId = 2, DropRate = 0.5m },
            new Material { MaterialId = 6, Name = "Rathian Webbing", MonsterId = 2, DropRate = 0.4m },
            new Material { MaterialId = 7, Name = "Diablos Ridge", MonsterId = 3, DropRate = 0.6m },
            new Material { MaterialId = 8, Name = "Diablos Tailcase", MonsterId = 3, DropRate = 0.4m },
            new Material { MaterialId = 9, Name = "Twisted Horn", MonsterId = 3, DropRate = 0.25m }
        );
        
        modelBuilder.Entity<Armor>()
            .HasMany(a => a.RequiredMaterials)
            .WithMany(m => m.RequiredByArmor)
            .UsingEntity(j => j.HasData(
                new { RequiredMaterialsMaterialId = 1, RequiredByArmorArmorId = 1 },
                new { RequiredMaterialsMaterialId = 2, RequiredByArmorArmorId = 1 },
                new { RequiredMaterialsMaterialId = 3, RequiredByArmorArmorId = 1},
                new { RequiredMaterialsMaterialId = 4, RequiredByArmorArmorId = 2 },
                new { RequiredMaterialsMaterialId = 5, RequiredByArmorArmorId = 2 },
                new { RequiredMaterialsMaterialId = 6, RequiredByArmorArmorId = 2 },
                new { RequiredMaterialsMaterialId = 7, RequiredByArmorArmorId = 3 },
                new { RequiredMaterialsMaterialId = 8, RequiredByArmorArmorId = 3 },
                new { RequiredMaterialsMaterialId = 9, RequiredByArmorArmorId = 3 }));
        
        modelBuilder.Entity<Weapon>()
            .HasMany(w => w.RequiredMaterials)
            .WithMany(m => m.RequiredByWeapons)
            .UsingEntity(j => j.HasData(
                new { RequiredMaterialsMaterialId = 1, RequiredByWeaponsWeaponId = 1 },
                new { RequiredMaterialsMaterialId = 2, RequiredByWeaponsWeaponId = 1 },
                new { RequiredMaterialsMaterialId = 3, RequiredByWeaponsWeaponId = 1 },
                new { RequiredMaterialsMaterialId = 4, RequiredByWeaponsWeaponId = 2 },
                new { RequiredMaterialsMaterialId = 5, RequiredByWeaponsWeaponId = 2 },
                new { RequiredMaterialsMaterialId = 6, RequiredByWeaponsWeaponId = 2 },
                new { RequiredMaterialsMaterialId = 7, RequiredByWeaponsWeaponId = 3 },
                new { RequiredMaterialsMaterialId = 8, RequiredByWeaponsWeaponId = 3 },
                new { RequiredMaterialsMaterialId = 9, RequiredByWeaponsWeaponId = 3 }));

        // Player has many owned weapons
        modelBuilder.Entity<Weapon>()
            .HasOne(w => w.Player)
            .WithMany()
            .HasForeignKey(w => w.PlayerId)
            .OnDelete(DeleteBehavior.Restrict);

        // Player has one equipped weapon
        modelBuilder.Entity<Player>()
            .HasOne(p => p.EquippedWeapon)
            .WithMany()
            .HasForeignKey(p => p.EquippedWeaponId)
            .OnDelete(DeleteBehavior.Restrict);

        // Player has many owned armor pieces
        modelBuilder.Entity<Armor>()
            .HasOne(a => a.Player)
            .WithMany()
            .HasForeignKey(a => a.PlayerId)
            .OnDelete(DeleteBehavior.Restrict);

        // Player has one equipped armor
        modelBuilder.Entity<Player>()
            .HasOne(p => p.EquippedArmor)
            .WithMany()
            .HasForeignKey(p => p.EquippedArmorId)
            .OnDelete(DeleteBehavior.Restrict);



    }

    // Track entities in the database 
    public DbSet<Monster> Monsters { get; set; }

    public DbSet<Player> Players { get; set; }

    public DbSet<Material> Materials { get; set; }

    public DbSet<Weapon> Weapons { get; set; }

    public DbSet<Armor> Armor { get; set; }

}
