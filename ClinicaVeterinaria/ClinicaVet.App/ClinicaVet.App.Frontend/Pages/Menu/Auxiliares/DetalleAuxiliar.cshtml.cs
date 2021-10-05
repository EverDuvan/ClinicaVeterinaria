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
    public class DetalleAuxiliaresModel : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar;

        public Auxiliar auxiliar{ get; set;}

        public DetalleAuxiliaresModel(IRepositorioAuxiliar repositorioAuxiliar){
            
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public void OnGet(int cedula)
        {
            auxiliar = repositorioAuxiliar.GetAuxiliar(cedula);
        }
    }
}
