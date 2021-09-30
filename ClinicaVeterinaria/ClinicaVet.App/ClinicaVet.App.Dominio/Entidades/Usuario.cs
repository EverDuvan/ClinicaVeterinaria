using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVet.App.Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cedula { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "El email es obligatoruio."),EmailAddress(ErrorMessage = "Esto no es un email")]
        public string email{ get; set;}
        [Required(ErrorMessage = "El usuario es obligatorio."),RegularExpression(@"^\S*$", ErrorMessage = "No puede tener espacios")]
        public string username { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria."),DataType(DataType.Password)]
        public string password { get; set; }
        
    }
}