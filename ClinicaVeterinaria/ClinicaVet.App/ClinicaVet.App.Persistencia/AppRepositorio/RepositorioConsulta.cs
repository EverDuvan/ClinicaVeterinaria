using System;
using System.Collections.Generic;
using System.Linq;
using ClinicaVet.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVet.App.Persistencia
{
    public class RepositorioConsulta : IRepositorioConsulta
    {
        private readonly Contexto _contexto;
        //private readonly Security security; 

        public RepositorioConsulta(Contexto contexto){
            this._contexto = contexto;
        }
        public Consulta AddConsulta(Consulta consulta)
        {
            Consulta nuevaConsulta =_contexto.Add(consulta).Entity;
            _contexto.SaveChanges();
            return nuevaConsulta;
        }

        public void DeleteConsulta(int Id)
        {
            Consulta consultaEncontrada = _contexto.Consultas.FirstOrDefault(c => c.Id == Id);
            if(consultaEncontrada != null){
                _contexto.Consultas.Remove(consultaEncontrada);
                _contexto.SaveChanges();
            }
        }

        public Consulta EditConsulta(Consulta consulta)
        {
            Consulta consultaEncontrada = _contexto.Consultas.FirstOrDefault(c => c.Id == consulta.Id);
            if(consultaEncontrada != null){
                consultaEncontrada.dueño = consulta.dueño;
                consultaEncontrada.mascota = consulta.mascota;
                consultaEncontrada.auxiliar = consulta.auxiliar;
                consultaEncontrada.veterinario = consulta.veterinario;
                consultaEncontrada.receta = consulta.receta;
                consultaEncontrada.anotacion = consulta.anotacion;
                consultaEncontrada.FechaConsulta = consulta.FechaConsulta;
                _contexto.SaveChanges();
            }
            return consultaEncontrada;
        }

        public IEnumerable<Consulta> GetAllConsultas()
        {
            return _contexto.Consultas.Include("mascota").Include("veterinario").Include("auxiliar");
        }

        public Consulta GetConsulta(int Id)
        {
            Consulta consultaEncontrada = _contexto.Consultas.Include("mascota").Include("veterinario").Include("auxiliar").FirstOrDefault(c => c.Id == Id);
            return consultaEncontrada;
        }
    }
}