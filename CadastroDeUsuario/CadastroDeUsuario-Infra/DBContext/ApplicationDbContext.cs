using CadastroDeUsuario_Domain.Entities.Materia;
using CadastroDeUsuario_Domain.Entities.Nota;
using CadastroDeUsuario_Domain.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeUsuario_Infra.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserDomain> Users { get; set; }
        public DbSet<MateriaDomain> Materias { get; set; }

        public DbSet<NotaDomain> Notas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<NotaDomain>()
                .HasOne(x => x.User)
                .WithMany(x => x.Notas)
                .HasForeignKey(x => x.UserId);

            
            modelBuilder.Entity<NotaDomain>()
                .HasOne(x => x.Materia)
                .WithMany(x => x.Notas)
                .HasForeignKey(x => x.MateriaId);

            base.OnModelCreating(modelBuilder);
        }
    }
}

