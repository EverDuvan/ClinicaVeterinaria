
using System;
 namespace ClinicaVet.App.Dominio{

public class HistoriaClinica:Consulta { 
    
    public Mascota Mascota { get; set; }
    // el atributo seria de tipo consulta, para almacenar en Historia clinica cada consulta emitida
    //public string ListaConsulta { get; set; }
    public Consulta Consulta { get; set; }
}
}