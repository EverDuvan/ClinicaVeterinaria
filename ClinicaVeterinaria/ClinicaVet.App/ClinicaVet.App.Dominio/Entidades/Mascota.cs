using System;
 namespace ClinicaVet.App.Dominio
{
    public class Mascota
    {
        public int Id { get; set; }       
        public Dueño Dueño { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Descripcion { get; set; }
        public TipoMascota TipoMascota { get; set; }

    } 
}