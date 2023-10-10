using Microsoft.EntityFrameworkCore;

namespace projeto_final_bloco_02.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Produto>().ToTable("tb_postagens");
            //modelBuilder.Entity<Categoria>().ToTable("tb_temas");


            //_ = modelBuilder.Entity<Produto>()
            //    .HasOne(_ => _.Categoria)
            //    .WithMany(t => t.Produto)
            //    .HasForeignKey("TemaId")
            //    .OnDelete(DeleteBehavior.Cascade);

            //_ = modelBuilder.Entity<Produto>()
            //    .HasOne(_ => _.Usuario)
            //    .WithMany(u => u.Produto)
            //    .HasForeignKey("UsuarioId")
            //    .OnDelete(DeleteBehavior.Cascade);

        }

        // Registrar DbSet - Objeto responsável por manipular a Tabela

        //public DbSet<Produto> Postagens { get; set; } = null!;
        //public DbSet<Categoria> Temas { get; set; } = null!;

        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    var insertedEntries = this.ChangeTracker.Entries()
        //                           .Where(x => x.State == EntityState.Added)
        //                           .Select(x => x.Entity);

        //    foreach (var insertedEntry in insertedEntries)
        //    {
        //        //Se uma propriedade da Classe Auditable estiver sendo criada. 
        //        if (insertedEntry is Auditable auditableEntity)
        //        {
        //            auditableEntity.Data = new DateTimeOffset(DateTime.Now);
        //        }
        //    }

        //    var modifiedEntries = ChangeTracker.Entries()
        //               .Where(x => x.State == EntityState.Modified)
        //               .Select(x => x.Entity);

        //    foreach (var modifiedEntry in modifiedEntries)
        //    {
        //        //Se uma propriedade da Classe Auditable estiver sendo atualizada.  
        //        if (modifiedEntry is Auditable auditableEntity)
        //        {
        //            auditableEntity.Data = new DateTimeOffset(DateTime.Now);
        //        }
        //    }

        //    return base.SaveChangesAsync(cancellationToken);
        //}

    }
}
