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
    public class ListaVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        public IEnumerable<Veterinario> veterinarios;
        public ListaVeterinariosModel(IRepositorioVeterinario repositorioVeterinario){
            this.repositorioVeterinario = repositorioVeterinario;
        }

        public void OnGet()
        {
            veterinarios = repositorioVeterinario.GetAllVeterinarios();
        }
    }
}
