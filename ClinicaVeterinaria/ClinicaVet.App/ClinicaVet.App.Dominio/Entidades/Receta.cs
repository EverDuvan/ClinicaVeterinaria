using System;

namespace ClinicaVet.App.Dominio
{
    public class Receta
    {
        public int Id{ get; set; }
        public Medicamentos medicamentos { get;set; } 
        public string dosis { get;set; } 
    }
}
