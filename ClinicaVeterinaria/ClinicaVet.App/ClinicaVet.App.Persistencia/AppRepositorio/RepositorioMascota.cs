using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVet.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVet.App.Persistencia.AppRepositorio
{
    public class RepositorioMascota : IRepositorioMascota
    {

        private readonly Contexto _contexto;

        public RepositorioMascota(Contexto contexto){
            this._contexto = contexto;

        }

        public Mascota AddMascotas(Mascota mascota)
        {
            Mascota nuevoMascota =_contexto.Add(mascota).Entity;
            _contexto.SaveChanges();
            return nuevoMascota;
        }
        

        public void DeleteMascotas(int Id)
        {
         Mascota MascotaEncontrado = _contexto.Mascotas.FirstOrDefault(m => m.Id == Id);
            if(MascotaEncontrado != null){
                _contexto.Mascotas.Remove(MascotaEncontrado);
                _contexto.SaveChanges();
            }
        }

        public Mascota EditMascotas(Mascota mascota)
        {
           Mascota MascotaAEditar =_contexto.Mascotas.FirstOrDefault(m => m.Id == mascota.Id);

            if(MascotaAEditar != null){
                MascotaAEditar.dueño = mascota.dueño;
                MascotaAEditar.nombre = mascota.nombre;
                MascotaAEditar.fechaNacimiento = mascota.fechaNacimiento;
                MascotaAEditar.descripcion = mascota.descripcion;
                MascotaAEditar.tipoMascota = mascota.tipoMascota;

                _contexto.SaveChanges();
            }
            return MascotaAEditar;
        }

        public IEnumerable<Mascota> GetAllMascotas()
        {
            return _contexto.Mascotas;
        }

        public Mascota GetMascotas(int Id)
        {
           Mascota MascotaEncontrado = _contexto.Mascotas.FirstOrDefault(m => m.Id == Id);
           return MascotaEncontrado;
           
        }
    }
}