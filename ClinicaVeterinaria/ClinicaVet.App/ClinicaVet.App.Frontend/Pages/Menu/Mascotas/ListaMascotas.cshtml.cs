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
    public class ListaMascotasModel : PageModel
    {
        public readonly IRepositorioMascota repositorioMascota;
        public  IEnumerable<Mascota> mascota;
        public ListaMascotasModel(IRepositorioMascota repositorioMascota){
            this.repositorioMascota = repositorioMascota;
        }
        public void OnGet()
        {
            mascota = repositorioMascota.GetAllMascotas();
        }
    }
}
