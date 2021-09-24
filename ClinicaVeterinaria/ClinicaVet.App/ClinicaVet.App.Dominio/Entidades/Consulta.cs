using System;
 namespace ClinicaVet.App.Dominio{

 public class Consulta{ 
     public int Id { get; set; }
     public Auxiliar auxiliar { get; set; }
     public Veterinario veterinario{ get; set; }
     public string Anotacion { get; set; }
     public Medicamentos medicamentes { get; set; }
     public DateTime Fecha{ get; set;}
 }
 }