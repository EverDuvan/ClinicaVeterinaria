using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ClinicaVet.App.Dominio;
using ClinicaVet.App.Persistencia;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClinicaVet.App.Frontend.Pages
{
    public class AdicionConsultasModel : PageModel
    {
        private readonly IRepositorioConsulta repositorioConsulta;

        public Consulta consulta { get; set; }

        public AdicionConsultasModel(IRepositorioConsulta repositorioConsulta)
        {
            this.repositorioConsulta = repositorioConsulta;
        }
        public void OnGet()
        {
            consulta = new Consulta();
        }


    }
}
