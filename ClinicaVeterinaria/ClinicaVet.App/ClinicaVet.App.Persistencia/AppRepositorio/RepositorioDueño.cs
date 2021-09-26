using System.Collections.Generic;
using System.Linq;
using ClinicaVet.App.Dominio;

namespace ClinicaVet.App.Persistencia
{
    public class RepositorioDueño : IRepositorioDueño
    {
        private readonly Contexto _contexto;        
        public RepositorioDueño(Contexto contexto){
            this._contexto = contexto;
        }
        public Dueño AddDueños(Dueño dueño)
        {
            Dueño nuevoDueño =_contexto.Add(dueño).Entity;
            _contexto.SaveChanges();
            return nuevoDueño;
        }
        public void DeleteDueños(int cedula)
        {
            Dueño dueñoEncontrado = _contexto.Dueños.FirstOrDefault(d => d.Cedula == cedula);
            if(dueñoEncontrado != null){
                _contexto.Dueños.Remove(dueñoEncontrado);
                _contexto.SaveChanges();
            }
        }
        public IEnumerable<Dueño> GetAllDueños()
        {
            return _contexto.Dueños;
        }
        public Dueño GetDueños(int cedula)
        {
            Dueño dueñoEncontrado = _contexto.Dueños.FirstOrDefault(d => d.Cedula == cedula);
            return dueñoEncontrado;
        }

        public Dueño UpdateDueños(Dueño dueño)
        {
            Dueño dueñoEncontrado = _contexto.Dueños.FirstOrDefault(d => d.Cedula == dueño.Cedula);
            if(dueñoEncontrado != null){
                dueñoEncontrado.password = dueño.password;
                dueñoEncontrado.Nombre = dueño.Nombre;
                dueñoEncontrado.Apellido = dueño.Apellido;
                dueñoEncontrado.Celular = dueño.Celular;
                dueñoEncontrado.Direccion = dueño.Direccion;
                dueñoEncontrado.Ciudad = dueño.Ciudad;
                _contexto.SaveChanges();
            }
            return dueñoEncontrado;

        }
    }
}