using System;


namespace ClinicaVet.App.Dominio
{
    public class Agenda
    {
        public Dueño dueño { get; set; }
        public Veterinario veterinario { get; set; }
        public DateTime dia{ get; set;}  
        public DateTime horaInicio{ get; set;}     

    }
}
