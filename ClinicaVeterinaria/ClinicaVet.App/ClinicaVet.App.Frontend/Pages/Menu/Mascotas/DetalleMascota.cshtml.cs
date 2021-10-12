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
    public class DetalleMascotaModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        private readonly IRepositorioDueño repositorioDueño;
        public Mascota mascota { get; set;}
        public Dueño dueño { get; set;}
        public DetalleMascotaModel(IRepositorioMascota repositorioMascota, IRepositorioDueño repositorioDueño){
            this.repositorioMascota = repositorioMascota;
            this.repositorioDueño = repositorioDueño;
        }

        public void OnGet(int mascotaId)
        {
            
            mascota = repositorioMascota.GetMascotas(mascotaId);
        }
    }
}
