using System;
 namespace ClinicaVet.App.Dominio
{
    //Hereda de usuario donde estan todos los atributos que piden:
    public class Dueño: Usuario  {
        
        //Para unir las tablas el dueño debe tener un instancia con cada mascota 
        //public Mascota Mascota { get; set; }
        
        //public int Id { get; set; }
        //public string Nombre { get; set; }
        //public string Apellido { get; set; }
        //public string Celular { get; set; }
        //public string Direccion { get; set; }
        //public string Ciudad { get; set; }
        public int IdMascota { get; set; }
    
    }
}