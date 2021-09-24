
using System;
 namespace ClinicaVet.App.Dominio{

public class HistoriaClinica:Consulta { 
    public Mascota mascota { get; set; }
    public string ListaConsulta { get; set; }

}
}