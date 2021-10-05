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
    public class ListaAuxiliaresModel : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        public IEnumerable<Auxiliar> auxiliares;
        public ListaAuxiliaresModel(IRepositorioAuxiliar repositorioAuxiliar){
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public void OnGet()
        {
            auxiliares = repositorioAuxiliar.GetAllAuxiliares();
        }
    }
}
