using System.Collections.Generic;
using ClinicaVet.App.Dominio;

namespace ClinicaVet.App.Persistencia
{
    public interface IRepositorioConsulta
    {
        IEnumerable<Consulta> GetAllConsultas();
        Consulta AddConsulta(Consulta consulta);
        Consulta EditConsulta(Consulta consulta);
        void DeleteConsulta(int Id);
        Consulta GetConsulta(int Id);
    }

}