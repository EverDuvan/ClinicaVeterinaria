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
    public class AdicionVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;

        public Veterinario veterinario { get; set; }

        public AdicionVeterinarioModel(IRepositorioVeterinario repositorioVeterinario)
        {
            this.repositorioVeterinario = repositorioVeterinario;
        }
        
        public void OnGet()
        {
            veterinario = new Veterinario();
        }
        
        public IActionResult OnPost(Veterinario veterinario)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repositorioVeterinario.AddVeterinarios(veterinario);
                    return RedirectToPage("./ListaVeterinarios");
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
