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
    public class EditarAuxiliaresModel : PageModel
    {
       private readonly IRepositorioAuxiliar repositorioAuxiliar;

        public Auxiliar auxiliar{ get; set; }

        public EditarAuxiliaresModel(IRepositorioAuxiliar repositorioAuxiliar)
        {
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        
        public void OnGet(int cedula)
        {
            auxiliar = repositorioAuxiliar.GetAuxiliar(cedula);
        }
        public IActionResult OnPost(Auxiliar auxiliar)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repositorioAuxiliar.EditAuxiliar(auxiliar);
                    return RedirectToPage("./ListaAuxiliares");
                }
                catch
                {
                    return RedirectToPage("../Error");
                }
            }
            else
            {
                return Page();
            }
        }
    }
}
