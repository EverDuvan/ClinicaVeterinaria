using System;

namespace ClinicaVet.App.Dominio{

public class Veterinario:Usuario{
        
        //Seria un atributo de la clase Turno
        //public string HorarioDia{ get; set;}
        public Turno Turno{ get; set;}

}
}