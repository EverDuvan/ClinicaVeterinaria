using System.Collections.Generic;
using System.Linq;
using ClinicaVet.App.Dominio;

namespace ClinicaVet.App.Persistencia
{
    public class RepositorioAuxiliar : IRepositorioAuxiliar
    {
        public readonly Contexto _contexto;
        public RepositorioAuxiliar(Contexto contexto){
            this._contexto = contexto;
        }
        public Auxiliar AddAuxiliar(Auxiliar auxiliar)
        {
            Auxiliar newAuxiliar = _contexto.Add(auxiliar).Entity;
            _contexto.SaveChanges();
            return newAuxiliar;
        }

        public void DeleteAuxiliar(int cedula)
        {
            Auxiliar auxiliarEcontrado = _contexto.Auxiliares.FirstOrDefault(a => a.cedula == cedula);
            if(auxiliarEcontrado != null){
                _contexto.Auxiliares.Remove(auxiliarEcontrado);
                _contexto.SaveChanges();
            }  

        }

        public Auxiliar EditAuxiliar(Auxiliar auxiliar)
        {
            Auxiliar auxiliarEcontrado = _contexto.Auxiliares.FirstOrDefault(a => a.cedula == auxiliar.cedula);
            if(auxiliarEcontrado != null){
                auxiliarEcontrado.nombre = auxiliar.nombre;
                auxiliarEcontrado.apellido = auxiliar.apellido;
                auxiliarEcontrado.cedula = auxiliar.cedula;
                auxiliarEcontrado.celular =auxiliar.celular;
                auxiliarEcontrado.direccion = auxiliar.direccion;
                auxiliarEcontrado.ciudad = auxiliar.ciudad;
                auxiliarEcontrado.email = auxiliar.email;
                auxiliarEcontrado.password = auxiliar.password;
                auxiliarEcontrado.username = auxiliar.username;
                _contexto.SaveChanges();
            }
            return auxiliarEcontrado;    
        }

        public IEnumerable<Auxiliar> GetAllAuxiliares()
        {
            return _contexto.Auxiliares;
        }

        public Auxiliar GetAuxiliar(int cedula)
        {
            Auxiliar auxiliarEcontrado = _contexto.Auxiliares.FirstOrDefault(a => a.cedula == cedula);
            return auxiliarEcontrado;
        }
    }
}