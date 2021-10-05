using System.Collections.Generic;
using System.Linq;
using ClinicaVet.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVet.App.Persistencia
{
    public class RepositorioAgenda : IRepositorioAgenda
    {
        private readonly Contexto _contexto;
        

        public RepositorioAgenda(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public Agenda addAgenda (Agenda agenda)
        {
            Agenda agendacruzada =_contexto.Agendas.FirstOrDefault(c => c.dia == agenda.dia && c.hora == agenda.hora && c.veterinario.Id == agenda.veterinario.Id );
            if(agendacruzada == null){
                  _contexto.Agendas.Add(agenda);  
                  _contexto.SaveChanges();
                  return agenda;
            }
            else {
                return null;
            }
        }

        public IEnumerable<Agenda> getAllAgendas()
        {
            return _contexto.Agendas.Include("veterinario").Include("dueño");;
        }

         /* public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        */
        /* public Agenda editAgenda(Agenda agenda)
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
        }*/
        /*public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }*/

        /* public Agenda getAgendaById(int id)
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
         }   */
    }
}