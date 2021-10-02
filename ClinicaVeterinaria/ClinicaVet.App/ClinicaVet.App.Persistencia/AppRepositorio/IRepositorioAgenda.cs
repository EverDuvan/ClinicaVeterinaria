using System.Collections.Generic;
using ClinicaVet.App.Dominio;
using System;

namespace ClinicaVet.App.Persistencia
{
    public interface IRepositorioAgenda
        {
        IEnumerable<Agenda> getAllAgenda();
        Agenda addAgenda (Agenda agenda);
        Agenda editAgenda (Agenda agenda);
        Agenda getAgendaById (int id);
        void removeAgenda (int id);
        //IEnumerable<Agenda> agendaPorVeterinario(DateTime fecha_inicio, DateTime fecha_final, Veterinario veterinario);
        //
    }
}