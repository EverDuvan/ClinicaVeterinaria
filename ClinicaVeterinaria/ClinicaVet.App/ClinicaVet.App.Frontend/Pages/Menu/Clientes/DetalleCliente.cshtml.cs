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

    public class DetalleClienteModel : PageModel
    {
        private readonly IRepositorioDueño repositorioDueño;

        public Dueño dueño { get; set; }

        public DetalleClienteModel(IRepositorioDueño repositorioDueño)
        {
            this.repositorioDueño = repositorioDueño;
        }

        public void OnGet(int cedula)
        {
            dueño = repositorioDueño.GetDueños(cedula);
        }
    }
}
