using Microsoft.EntityFrameworkCore;
using ClinicaVet.App.Dominio;

namespace ClinicaVet.App.Persistencia
{
    public class Contexto: DbContexto
    {
        public DbSet <Usuario> Usuarios { get; set; }
        public DbSet<Veterinario> Veterinarios{get; set; }
        public DbSet<Auxiliar> Auxiliares { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            if (!options.IsConfigured){
                options.UseSqlServer ("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ClinicaVet");
           
         }
         }
         protected override void OnModelCreating(ModelBuilder builder)
         {
             builder.Entity<Usuario>()
             .HasIndex(u => u.Cedula)
             .IsUnique();
         }
    }
    
}