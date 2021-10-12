using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVet.App.Dominio;
using ClinicaVet.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClinicaVet.App.Frontend.Pages.Menu
{
    public class EditarMascotaModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        public Mascota mascota { get; set;}
        public EditarMascotaModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota = repositorioMascota;
        }
        
        public void OnGet(int mascotaId)
        {
            mascota = repositorioMascota.GetMascotas(mascotaId);
        }
        public IActionResult OnPost(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repositorioMascota.EditMascotas(mascota);
                    return RedirectToPage("./ListaMascotas");
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
