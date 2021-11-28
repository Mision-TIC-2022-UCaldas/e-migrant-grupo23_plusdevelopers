using Microsoft.EntityFrameworkCore;
using EMigrant.App.Dominio.Entidades;

namespace EMigrant.App.Persistencia.AppRepositorios
{
    public class AppContext: DbContext
    {
        public DbSet<Sector> Sectores {get;set;}
        public DbSet<TipoServicio> TiposServicio {get;set;}
        public DbSet<Entidad> Entidades {get;set;}

        private const string connectionString = @"Server=localhost;Database=BDEmigrant;User=sa;Password=hackatonucaldas2021;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            /*
            builder.Entity<Usuario>().HasIndex(u => u.NombreUsuario).IsUnique();
            builder.Entity<Usuario>().HasIndex(u => u.Correo).IsUnique();
            builder.Entity<Persona>().HasIndex(p => p.Documento).IsUnique();
            builder.Entity<Empresa>().HasIndex(e => e.Nit).IsUnique();
            */
        }

    }
}