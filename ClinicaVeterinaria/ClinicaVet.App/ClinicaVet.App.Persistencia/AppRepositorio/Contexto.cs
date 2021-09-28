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
        public DbSet<HistoriaClinica> HistoriaClinicas { get; set; }
        public DbSet<Medicamentos> Medicamentos { get; set; }
        
        
        //Adiciono DbSets de todas las clases 
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Dueño> Dueños { get; set; }
        public DbSet<Turno> Turnos { get; set; }


         protected override void OnConfiguring(DbContextOptionsBuilder options)
         {
            if (!options.IsConfigured) { options.UseSqlServer ("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ClinicaVet");
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