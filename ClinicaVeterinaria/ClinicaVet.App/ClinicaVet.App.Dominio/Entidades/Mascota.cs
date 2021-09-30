using System;
 namespace ClinicaVet.App.Dominio
{
    public class Mascota
    {
        public int Id { get; set; }       
        public Dueño dueño { get; set; }
        public string nombre { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string descripcion { get; set; }
        public TipoMascota tipoMascota { get; set; }

    } 
}