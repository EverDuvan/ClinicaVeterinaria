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
    public class AdicionMascotaModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        public Mascota mascota{get; set;}
        public AdicionMascotaModel(IRepositorioMascota repositorioMascota){
            this.repositorioMascota = repositorioMascota;
        }
        public void OnGet()
        {
            mascota = new Mascota();
        }
        public IActionResult OnPost(Mascota mascota){
            try{
                repositorioMascota.AddMascotas(mascota);
                return RedirectToPage("./ListaMascotas");   
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
