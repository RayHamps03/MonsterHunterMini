using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterHunterMini.Database;

public class MonsterDb
{
    /// <summary>
    /// Retrieves a monster from the database by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the monster to retrieve. Must correspond to an existing monster in the database.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the monster with the specified
    /// identifier.</returns>
    /// <exception cref="ArgumentException">Thrown when no monster with the specified identifier exists in the database.</exception>
    public static async Task<Monster> GetAsync(int id)
    {
        using MonsterHunterMiniDb db = new();

        // If specified id is not found, throw an exception
        return await db.Monsters.FindAsync(id) 
            ?? throw new ArgumentException("Invalid monster ID.");

    }

    /// <summary>
    /// Retrieves all monsters from the database.
    /// </summary>
    /// <remarks>This method uses the MonsterHunterMiniDb context to access the monsters table. Ensure that
    /// the database is properly initialized before calling this method.</remarks>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of all monsters in the
    /// database.</returns>
    public static async Task<List<Monster>> GetAllMonstersAsync()
    {
        using MonsterHunterMiniDb db = new();
        List<Monster> monsters = await db.Monsters.ToListAsync();
        return monsters;
    }

    /// <summary>
    /// Adds a new monster entity to the database by passing in a monster object.
    /// </summary>
    /// <remarks>This method saves changes to the database after adding the specified monster. Ensure that the
    /// monster object is fully initialized before calling this method.</remarks>
    /// <param name="monster">The monster to add to the database. Cannot be null.</param>
    /// <returns>A task that represents the asynchronous add operation.</returns>
    public static async Task AddAsync(Monster monster)
    {
        using MonsterHunterMiniDb db = new();
        db.Monsters.Add(monster);
        await db.SaveChangesAsync();
    }

    /// <summary>
    /// Retrieves a monster from the database by its unique identifier and loads its related drops.
    /// </summary>
    /// <param name="id">The unique identifier of the monster to load. Must be a positive integer.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the loaded Monster object.</returns>
    public static async Task<Monster> LoadMonsterAsync(int id)
    {
        using MonsterHunterMiniDb db = new();
        var monster = await db.Monsters
            .Include(m => m.Drops)
            .FirstAsync(m => m.MonsterId == id);
        return monster;
    }
}
