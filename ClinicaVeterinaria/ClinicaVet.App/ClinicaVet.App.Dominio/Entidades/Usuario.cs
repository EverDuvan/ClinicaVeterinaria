using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVet.App.Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string password { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        

    }
}