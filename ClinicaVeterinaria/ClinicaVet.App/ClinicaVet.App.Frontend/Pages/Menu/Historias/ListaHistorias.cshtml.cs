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
    public class ListaHistoriasModel : PageModel
    {
        private readonly IRepositorioHistoriaClinica repositorioHistoriaClinica;
        public IEnumerable<HistoriaClinica> historias;
        public Mascota mascota { get; set; }

        public ListaHistoriasModel(IRepositorioHistoriaClinica repositorioHistoriaClinica){
            this.repositorioHistoriaClinica = repositorioHistoriaClinica;
            historias = repositorioHistoriaClinica.getAllHistorias();
        }
        public void OnGet()
        {
        }
    }
}
