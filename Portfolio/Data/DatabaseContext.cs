using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.Data;

public class DatabaseContext : IdentityDbContext
{
    public DbSet<Project> Projects { get; init; }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }
}