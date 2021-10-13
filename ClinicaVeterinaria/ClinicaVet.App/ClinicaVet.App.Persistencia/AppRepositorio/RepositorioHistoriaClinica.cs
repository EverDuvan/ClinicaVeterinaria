using System;
using System.Collections.Generic;
using System.Linq;
using ClinicaVet.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVet.App.Persistencia
{
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica
    {
        private readonly Contexto _contexto;

        public RepositorioHistoriaClinica(Contexto contexto){
            this._contexto = contexto;
        }

        public HistoriaClinica addHistoria(HistoriaClinica historia)
        {
            HistoriaClinica historiaNueva =  _contexto.Add(historia).Entity;
            _contexto.SaveChanges();
            return historiaNueva;
        }

        public HistoriaClinica editHistoria(HistoriaClinica historiaClinica)
        {
            HistoriaClinica historiaAEditar = _contexto.HistoriaClinicas.FirstOrDefault(h => h.Id == historiaClinica.Id);
            if(historiaAEditar != null){
                historiaAEditar.consultas = historiaClinica.consultas;
                _contexto.SaveChanges();
            }
            return historiaAEditar;
        }

        public IEnumerable<HistoriaClinica> getAllHistorias()
        {
            return _contexto.HistoriaClinicas.Include("consultas").Include("consultas.mascota").Include("consultas.veterinario").Include("consultas.auxiliar").Include("aconsultas.receta").Include("aconsultas.anotacion").Include("aconsultas.FechaConsulta");
        }

        public HistoriaClinica getHistoria(int id)
        {
            return _contexto.HistoriaClinicas.Include("consultas").Include("consultas.mascota").Include("consultas.veterinario").Include("consultas.auxiliar").Include("aconsultas.receta").Include("aconsultas.anotacion").Include("aconsultas.FechaConsulta").FirstOrDefault(h => h.Id == id);
        }

        public IEnumerable<HistoriaClinica> historiaPorAuxiliar(Auxiliar auxiliar)
        {
            return _contexto.HistoriaClinicas.Where(h => h.consultas.Any(c => c.auxiliar.Id==auxiliar.Id));
        }

        public HistoriaClinica historiaPorFechaYMascota(DateTime fecha_inicio, DateTime fecha_final, Mascota mascota)
        {
            return _contexto.HistoriaClinicas.FirstOrDefault(h => h.consultas.Any(c => c.mascota.Id == mascota.Id && c.FechaConsulta >= fecha_inicio && c.FechaConsulta <= fecha_final));
        }

        public HistoriaClinica historiaPorMascota(Mascota mascota)
        {
            return _contexto.HistoriaClinicas.FirstOrDefault(h => h.consultas.All(c => c.mascota.Id == mascota.Id));
        }

        public IEnumerable<HistoriaClinica> historiaPorVeterinario(Veterinario veterinario)
        {
            return _contexto.HistoriaClinicas.Where(h => h.consultas.Any(c => c.veterinario.Id == veterinario.Id));
        }

        public void RemoveHistoria(int id)
        {
            HistoriaClinica historiaAEliminar = _contexto.HistoriaClinicas.FirstOrDefault(h => h.Id == id);
            if(historiaAEliminar != null){
                _contexto.HistoriaClinicas.Remove(historiaAEliminar);
                _contexto.SaveChanges();
            }
        }
    }
}