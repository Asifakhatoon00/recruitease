using Microsoft.EntityFrameworkCore;
using recruitease_backend.Models;

namespace recruitease_backend.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Maps the User C# class to the 'Users' table in MySQL
    public DbSet<User> Users { get; set; }
}

