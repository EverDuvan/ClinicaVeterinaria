using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVet.App.Dominio;
using ClinicaVet.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClinicaVet.App.Frontend.Pages.Menu
{
    public class AdicionAuxiliaresModel : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        public Auxiliar auxiliar{get; set;}
        public AdicionAuxiliaresModel(IRepositorioAuxiliar repositorioAuxiliar){
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public void OnGet()
        {
            auxiliar = new  Auxiliar();
        }
        public IActionResult OnPost(Auxiliar auxiliar){
            try{
                repositorioAuxiliar.AddAuxiliar(auxiliar);
                return RedirectToPage("./ListaAuxiliares");   
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
