using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClinicaVet.App.Dominio;
using ClinicaVet.App.Persistencia;

namespace ClinicaVet.App.Frontend.Pages
{
    
    public class ListaClientesModel : PageModel
    {
        private readonly IRepositorioDueño repositorioDueño;

        public IEnumerable<Dueño> dueños { get; set; }

        public ListaClientesModel(IRepositorioDueño rep){
            this.repositorioDueño = rep;
        }
        
        public void OnGet()
        {
            dueños = repositorioDueño.GetAllDueños();
        }
    }
}
