using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVet.App.Dominio;

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
           Mascota MascotaEncontrado =_contexto.Mascotas.FirstOrDefault(d => d.Id == mascota.Id);

            if(MascotaEncontrado != null){
                MascotaEncontrado.dueño = mascota.dueño;
                MascotaEncontrado.nombre = mascota.nombre;
                MascotaEncontrado.fechaNacimiento = mascota.fechaNacimiento;
                MascotaEncontrado.descripcion = mascota.descripcion;
                MascotaEncontrado.tipoMascota = mascota.tipoMascota;

                _contexto.SaveChanges();
            }
            return MascotaEncontrado;
        }

        public IEnumerable<Mascota> GetAllMascotas()
        {
            return _contexto.Mascotas;
        }

        public Mascota GetMascotas(int Id)
        {
            Mascota MascotaEncontrado = _contexto.Mascotas.FirstOrDefault(d => d.Id == Id);
           return MascotaEncontrado;
        }
    }
}