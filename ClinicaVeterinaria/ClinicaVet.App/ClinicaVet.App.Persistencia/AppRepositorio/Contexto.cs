using System;
using Microsoft.EntityFrameworkCore;
using ClinicaVet.App.Dominio;


namespace ClinicaVet.App.Persistencia
{
    public class Contexto: DbContext
    {
        public DbSet <Usuario> Usuarios { get; set; }
        public DbSet<Veterinario> Veterinarios{get; set; }
        public DbSet<Auxiliar> Auxiliares { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<HistoriaClinica> HistoriaClinica { get; set; }
        public DbSet<Medicamentos> medicamentos { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder options)
         {
            if (!options.IsConfigured) { options.UseSqlServer ("Data Source = (localdb) \\MSSQLLocalDB; Initial Catalog = ClinicaVet");
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