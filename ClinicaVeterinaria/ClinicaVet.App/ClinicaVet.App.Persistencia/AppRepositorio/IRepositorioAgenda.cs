using System.Collections.Generic;
using ClinicaVet.App.Dominio;
using System;

namespace ClinicaVet.App.Persistencia
{
    public interface IRepositorioAgenda
        {
        IEnumerable<Agenda> getAllAgendas();
        Agenda addAgenda (Agenda agenda);
        //Agenda editAgenda (Agenda agenda);
        //Agenda getAgendaById (int id);
        //void removeAgenda (int id);
      
    }
}