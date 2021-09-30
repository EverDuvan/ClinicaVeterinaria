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
    public class AdicionClienteModel : PageModel
    {
        private readonly IRepositorioDueño repositorioDueño;

        public Dueño dueño { get; set; }

        public AdicionClienteModel(IRepositorioDueño repositorioDueño)
        {
            this.repositorioDueño = repositorioDueño;
        }
        
        public void OnGet()
        {
            dueño = new Dueño();
        }
        
        public IActionResult OnPost(Dueño dueño)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repositorioDueño.AddDueños(dueño);
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
