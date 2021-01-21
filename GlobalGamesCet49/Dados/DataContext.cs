
namespace GlobalGamesCet49.Dados
{
    using GlobalGamesCet49.Dados.Entidades;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : IdentityDbContext<User>
    {

        public DbSet<Contacto> Contactos { get; set; }

        public DbSet<Inscricoes> Inscricoes { get; set; }

        public DbSet<UserLogin> UserLogin { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
