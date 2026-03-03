using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MonsterHunterMini.Database;

public class MonsterDb : DbContext 
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog =MonsterHunterMiniDb; Integrated Security = True; Encrypt = False; Trust Server Certificate = False;");
    }

    // Track entities in the database 
    public DbSet<Monster> Monsters { get; set; }
}
