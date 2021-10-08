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
        public void OnGet(int Id)
        {
            mascota = repositorioMascota.GetMascotas(Id);
        }
        public IActionResult OnPost(int Id){
            
            repositorioMascota.DeleteMascotas(Id);
            return RedirectToPage("./ListaMascotas");
        }
    }
}
