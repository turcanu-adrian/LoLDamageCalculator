using Domain.Champion;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Champion> Champions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ability>()
                .Property(a => a.Cooldown)
                .HasConversion(
                c => JsonSerializer.Serialize(c, (JsonSerializerOptions)null),
                c => JsonSerializer.Deserialize<double[]>(c, (JsonSerializerOptions)null)
                );

            modelBuilder.Entity<Ability>()
                .Property(a => a.ManaCost)
                .HasConversion(
                c => JsonSerializer.Serialize(c, (JsonSerializerOptions)null),
                c => JsonSerializer.Deserialize<double[]>(c, (JsonSerializerOptions)null)
                );
        }
    }
}
