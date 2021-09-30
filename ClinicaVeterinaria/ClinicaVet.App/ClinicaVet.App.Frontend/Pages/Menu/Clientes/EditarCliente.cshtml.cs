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
    public class EditarClienteModel : PageModel
    {
        private readonly IRepositorioDueño repositorioDueño;

        public Dueño dueño { get; set; }

        public EditarClienteModel(IRepositorioDueño repositorioDueño)
        {
            this.repositorioDueño = repositorioDueño;
        }
        
        public void OnGet(int cedula)
        {
            dueño = repositorioDueño.GetDueños(cedula);
        }
        public IActionResult OnPost(Dueño dueño)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repositorioDueño.EditDueños(dueño);
                    return RedirectToPage("./ListaClientes");
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
