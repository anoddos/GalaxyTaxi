using GalaxyTaxi.Api.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace GalaxyTaxi.Api.Database;

public class Db : DbContext
{
    public DbSet<Account> Accounts { get; set; } = null!;

    public Db(DbContextOptions options) : base(options)
    {
        
    }
}