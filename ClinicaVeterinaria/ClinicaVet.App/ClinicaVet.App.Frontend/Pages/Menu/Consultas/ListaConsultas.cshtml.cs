using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVet.App.Dominio;
using ClinicaVet.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClinicaVet.App.Frontend.Pages
{
    public class ListaConsultasModel : PageModel
    {
        private readonly IRepositorioConsulta repositorioConsulta;

        public IEnumerable<Consulta> consultas { get; set; }

        public ListaConsultasModel(IRepositorioConsulta rep){
            this.repositorioConsulta = rep;
        }
        public void OnGet()
        {
            consultas = repositorioConsulta.GetAllConsultas();
        }
    }
}
