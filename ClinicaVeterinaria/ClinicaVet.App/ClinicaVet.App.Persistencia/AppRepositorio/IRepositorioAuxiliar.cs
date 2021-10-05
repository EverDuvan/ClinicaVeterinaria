using System.Collections.Generic;
using ClinicaVet.App.Dominio;

namespace ClinicaVet.App.Persistencia
{
    public interface IRepositorioAuxiliar{
        IEnumerable<Auxiliar> GetAllAuxiliares();
        Auxiliar GetAuxiliar(int cedula);
        Auxiliar AddAuxiliar(Auxiliar auxiliar);
        Auxiliar EditAuxiliar(Auxiliar auxiliar);
        void DeleteAuxiliar(int cedula); 

    }
}