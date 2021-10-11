using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVet.App.Dominio;
using ClinicaVet.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClinicaVet.App.Frontend.Pages.Menu
{
    public class AdicionMascotaModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        private readonly IRepositorioDueño repositorioDueño;

        public Mascota mascota{get; set;}
        public IEnumerable<SelectListItem> Dueños { get; set; }
        public int cedulaDueño { get; set; }
        public Dueño dueño { get; set; }

        public AdicionMascotaModel(IRepositorioMascota repositorioMascota, IRepositorioDueño repositorioDueño){
            this.repositorioMascota = repositorioMascota;
            this.repositorioDueño = repositorioDueño;
            mascota = new Mascota();
            Dueños = repositorioDueño.GetAllDueños().Select(
                d => new SelectListItem
                {
                    Value = Convert.ToString(d.cedula),
                    Text = d.nombre
                }
            ).ToList();
        }
        
        public void OnGet()
        {
            
        }
        public IActionResult OnPost(Mascota mascota, int cedulaDueño)
        {
            if (ModelState.IsValid)
            {
                Dueño dueño = repositorioDueño.GetDueños(cedulaDueño);

                try
                {
                    repositorioMascota.AddMascotas(mascota);
                    mascota.dueño = dueño;
                    repositorioMascota.EditMascotas(mascota);
                    return RedirectToPage("./ListaMascotas");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
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
