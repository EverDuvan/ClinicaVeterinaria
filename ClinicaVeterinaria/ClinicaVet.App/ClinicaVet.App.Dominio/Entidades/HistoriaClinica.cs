using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVet.App.Dominio{
public class HistoriaClinica {
    [Key]
    public int Id{get;set;}
    public List<Consulta> consultas { get; set; }
    public string resumen{get;set;}
}
}