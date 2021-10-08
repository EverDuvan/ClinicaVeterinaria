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
    public class DetalleHistoriasModel : PageModel
    {
        private readonly IRepositorioHistoriaClinica repositorioHistoriaClinica ;
        public HistoriaClinica Historia {get; set; }

        public DetalleHistoriasModel(IRepositorioHistoriaClinica repositorio){
            this.repositorioHistoriaClinica = repositorio;
        }
        public void OnGet(int idHistoria)
        {
            Historia = repositorioHistoriaClinica.getHistoria(idHistoria);
        }
    }
}
