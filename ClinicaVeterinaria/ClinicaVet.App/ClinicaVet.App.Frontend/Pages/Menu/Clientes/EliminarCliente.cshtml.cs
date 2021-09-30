using System;
using System.Collections.Generic;
using System.Linq;
using ClinicaVet.App.Dominio;
using ClinicaVet.App.Persistencia;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClinicaVet.App.Frontend.Pages
{
    public class EliminarClienteModel : PageModel
    {
        private readonly IRepositorioDueño repositorioDueño;

        public Dueño dueño { get; set; }

        public EliminarClienteModel(IRepositorioDueño repositorioDueño)
        {
            this.repositorioDueño = repositorioDueño;
        }

        public void OnGet(int cedula)
        {
            dueño = repositorioDueño.GetDueños(cedula);
        }

        public IActionResult OnPost(int cedula){
            
            repositorioDueño.DeleteDueños(cedula);
            return RedirectToPage("./ListaClientes");
        }
    }
}
