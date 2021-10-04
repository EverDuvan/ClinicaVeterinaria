using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVet.App.Dominio;

namespace ClinicaVet.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinarios();
        Veterinario AddVeterinarios(Veterinario veterinario);
        Veterinario EditVeterinarios(Veterinario veterinario);
        void DeleteVeterinarios(int cedula);
        Veterinario GetVeterinarios(int cedula);
        
    }
}