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
    }
}
