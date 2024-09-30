using dsMotor.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace dsMotor.Infra.Persistence
{
    public class DsMotorDbContext:DbContext
    {
        public DbSet<Motorcycle> Motorcycle { get; set; }
        public DbSet<User> Users { get; set; }

        public DsMotorDbContext(DbContextOptions<DsMotorDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Motorcycle>()
                .HasKey(i => i.Id);
            modelBuilder.Entity<User>()
                .HasKey(i => i.Id);

        }
    }
}
