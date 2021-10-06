using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVet.App.Dominio
{

    public class Consulta
    {
        [Key]
        public int Id { get; set; }
        public Mascota mascota { get; set; }
        public Auxiliar auxiliar { get; set; }
        public Veterinario veterinario { get; set; }
        public Receta receta { get; set; }
        public string anotacion { get; set; }
        [Required(ErrorMessage = "La fecha es obligatoria."),DataType(DataType.DateTime),Range(typeof(DateTime), "1/1/2021", "31/12/2025",ErrorMessage = "El valor {0} debe estar {1} y {2}")]
        public DateTime FechaConsulta { get; set; }
    }
}