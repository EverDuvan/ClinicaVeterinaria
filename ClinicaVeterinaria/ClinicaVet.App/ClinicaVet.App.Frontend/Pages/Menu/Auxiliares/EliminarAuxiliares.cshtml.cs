using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClinicaVet.App.Dominio;
using ClinicaVet.App.Persistencia;

namespace ClinicaVet.App.Frontend.Pages.Menu
{
    public class EliminarAuxiliaresModel : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar;

        public Auxiliar auxiliar { get; set; }

        public EliminarAuxiliaresModel(IRepositorioAuxiliar repositorioAuxiliar)
        {
            this.repositorioAuxiliar = repositorioAuxiliar;
        }

        public void OnGet(int cedula)
        {
            auxiliar = repositorioAuxiliar.GetAuxiliar(cedula);
        }

        public IActionResult OnPost(int cedula){
            
            repositorioAuxiliar.DeleteAuxiliar(cedula);
            return RedirectToPage("./ListaAuxiliares");
        }
    }
}
