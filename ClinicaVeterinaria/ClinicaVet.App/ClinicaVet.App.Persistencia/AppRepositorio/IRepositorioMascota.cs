using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVet.App.Dominio;

namespace ClinicaVet.App.Persistencia
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascotas(Mascota mascota);
        Mascota EditMascotas(Mascota mascota);
        void DeleteMascotas(int Id);
        Mascota GetMascotas(int Id);
    }
}