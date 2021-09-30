using System.Collections.Generic;
using ClinicaVet.App.Dominio;

namespace ClinicaVet.App.Persistencia
{
    public interface IRepositorioDueño
    {
        IEnumerable<Dueño> GetAllDueños();
        Dueño AddDueños(Dueño dueño);
        Dueño EditDueños(Dueño dueño);
        void DeleteDueños(int cedula);
        Dueño GetDueños(int cedula);
    }

}