
using System;
 namespace ClinicaVet.App.Dominio{

public class HistoriaClinica { 

    public int Id { get; set; }
    public Veterinario veterinario { get; set; }
    public Auxiliar auxiliar { get; set; }
    public Anotacion anotacion { get; set; }
    public Fecha fecha { get; set; }
    public Medicamentos medicamentos { get; set; }
    public Mascota mascota { get; set; }
    public string ListaConsulta { get; set; }

}
}