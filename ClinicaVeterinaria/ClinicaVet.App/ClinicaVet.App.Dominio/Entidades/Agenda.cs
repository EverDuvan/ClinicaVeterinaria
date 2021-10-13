using System;
//using System.Collections.Generic;
//using System.Linq;
using System.ComponentModel.DataAnnotations;


namespace ClinicaVet.App.Dominio
{
    public class Agenda
    {
        [Key]
        public int id{get;set;}
        public Dueño dueño { get; set; }
        public Veterinario veterinario { get; set; }
        [Required(ErrorMessage = "El dia  es obligatorio."),DataType(DataType.Date),Range(typeof(DateTime),"1/1/2021","1/1/2026", ErrorMessage = "El dia es obligatorio")]
       
        public DateTime dia{ get; set;}  
        [Required(ErrorMessage="La hora es obligatoria."),DataType(DataType.Time)]
        public DateTime hora{ get; set;}   
        public string descripcion{ get; set; }  
        [Required]
        public Sala sala{ get; set; } 

    }
}
