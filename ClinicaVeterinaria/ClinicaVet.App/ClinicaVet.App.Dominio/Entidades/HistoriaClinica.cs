
using System;
 namespace ClinicaVet.App.Dominio{


// elimine la herencia de historias clinicas. Este no hereda solo tiene el atributo, ya que tendria muchas cunsultas en una sola historia clinica
public class HistoriaClinica { 
    public int Id{get;set;}
    public Mascota Mascota { get; set; }
    // el atributo seria de tipo consulta, para almacenar en Historia clinica cada consulta emitida
    //public string ListaConsulta { get; set; }
    public Consulta Consulta { get; set; }

}
}