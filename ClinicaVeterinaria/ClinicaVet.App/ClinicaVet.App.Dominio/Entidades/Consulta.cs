using System;
 namespace ClinicaVet.App.Dominio{

 public class Consulta{ 
     
     public int Id { get; set; }
     public Mascota mascota { get; set; }
     public Auxiliar auxiliar { get; set; }
     public Veterinario veterinario{ get; set; }
     public Receta receta { get; set; }
     public string anotacion { get; set; }
     public DateTime FechaConsulta{ get; set;}
 }
 }