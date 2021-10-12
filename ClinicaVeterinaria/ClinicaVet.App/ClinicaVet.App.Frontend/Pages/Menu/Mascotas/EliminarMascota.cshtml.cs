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
    public class EliminarMascotaModel : PageModel
    {
        public readonly IRepositorioMascota repositorioMascota;
        public Mascota mascota { get; set; }
        public EliminarMascotaModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota = repositorioMascota;
        }
        public void OnGet(int mascotaId)
        {
            mascota = repositorioMascota.GetMascotas(mascotaId);
        }
        public IActionResult OnPost(int mascotaId){
            
            repositorioMascota.DeleteMascotas(mascotaId);
            return RedirectToPage("./ListaMascotas");
        }
    }
}
