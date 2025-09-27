using Microsoft.EntityFrameworkCore;
using WebApplication2.Data.Mapeamento;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMapeamento());
        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Aluno> Aluno { get; set; }
    }
}
