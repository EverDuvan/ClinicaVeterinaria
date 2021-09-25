using System;
 namespace ClinicaVet.App.Dominio
{
    public class Mascota
    {
        public int Id { get; set; }       
        //el dueño es de tipo Dueño y asi se puede buscar a cada mascota por el dueño
        //public string Dueño { get; set; }
        public Dueño Dueño { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Descripcion { get; set; }
        //adiciono tipo de mascota
        public TipoMascota TipoMascota { get; set; }
        //Para simlificar, solo pondria si es perro o gato con la clase tipo Mascota
        //public string raza { get; set; }
        


    } 
}