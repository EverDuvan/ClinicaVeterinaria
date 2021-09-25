using System;
 namespace ClinicaVet.App.Dominio{

 public class Consulta{ 
     
     public int Id { get; set; }
     //La consulta debe tener la mascota que se reporta y con esta se una al dueño por tablas
     public Mascota Mascota { get; set; }
     public Auxiliar auxiliar { get; set; }
     public Veterinario veterinario{ get; set; }
     public string Anotacion { get; set; }
     public Medicamentos Medicamentos { get; set; }
     public DateTime Fecha{ get; set;}
 }
 }