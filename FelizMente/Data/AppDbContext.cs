using FelizMente.Model;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;

namespace FelizMente.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Tema>().ToTable("tb_temas");

        }
        public DbSet<Tema> Temas { get; set; } = null!;

    }
}
