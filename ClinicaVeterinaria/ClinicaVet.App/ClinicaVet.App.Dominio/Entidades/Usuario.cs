using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVet.App.Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public int cedula { get; set; }
        public string apellido { get; set; }
        public string celular { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        [Required(ErrorMessage = "El email es obligatoruio."),EmailAddress(ErrorMessage = "Esto no es un email")]
        public string email{ get; set;}
        [Required(ErrorMessage = "El usuario es obligatorio."),RegularExpression(@"^\S*$", ErrorMessage = "No puede tener espacios")]
        public string username { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria."),DataType(DataType.Password)]
        public string password { get; set; }
        
    }
}