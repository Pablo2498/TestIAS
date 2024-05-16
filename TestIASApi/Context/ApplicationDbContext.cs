using Microsoft.EntityFrameworkCore;
using TestIASApi.Entities;

namespace TestIASApi.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Vehicle> Vehicles { get; set; }

    public DbSet<Brand> Brands { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vehicle>()
            .HasOne(p => p.Brand)
            .WithOne(t => t.Vehicle);

        base.OnModelCreating(modelBuilder);
    }
}
