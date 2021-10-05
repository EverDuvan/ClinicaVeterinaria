using System.Collections.Generic;
using System.Linq;
using ClinicaVet.App.Dominio;

namespace ClinicaVet.App.Persistencia
{
    public class RepositorioAgenda : IRepositorioAgenda
    {
        private readonly Contexto _contexto;
        //private readonly Security security; 

        public RepositorioAgenda(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public Agenda addAgenda (Agenda agenda)
        {
            Agenda agendaNew =_contexto.Add(agenda).Entity;
            return agendaNew;

        }
        public Agenda editAgenda(Agenda agenda)
        {
                Agenda agendaAEditar = _contexto.Agendas.FirstOrDefault(a => a.Id == agenda.Id);
                if(agendaAEditar != null){
                    agendaAEditar.dueño= agenda.dueño;
                    agendaAEditar.veterinario= agenda.veterinario;
                    
                    agendaAEditar.dia= agenda.dia;
                    agendaAEditar.horaInicio = agenda.horaInicio;
                    _contexto.SaveChanges();
                    
                }
        return agendaAEditar;
        }

        public IEnumerable<Agenda> getAllAgenda()
        {
            return _contexto.Agendas;
        }

        public Agenda getAgendaById(int id)
        {
            return _contexto.Agendas.FirstOrDefault(a => a.Id == id);
            //Agenda agenda =_contexto.Agendas.FirstOrDefault(p=>p.cedula == cedula);
            //return agenda;
        
        }

        public void removeAgenda(int id)
        {
            Agenda agenda = _contexto.Agendas.FirstOrDefault(a => a.Id == id);
            if (agenda != null){
                _contexto.Agendas.Remove(agenda);
                _contexto.SaveChanges();
            }
        }
    }
}