using System;
using System.Collections.Generic;
using System.Linq;
using ClinicaVet.App.Dominio;

namespace ClinicaVet.App.Persistencia
{
    public class RepositorioDueño : IRepositorioDueño
    {
        private readonly Contexto _contexto; 
        //private readonly Security security; 

        public RepositorioDueño(Contexto contexto){
            this._contexto = contexto;
            //security = new Security();
        }
        public Dueño AddDueños(Dueño dueño)
        {
            //String password = dueño.password;
            //password = security.GetMD5Hash(password);
            //dueño.password = password;

            Dueño nuevoDueño =_contexto.Add(dueño).Entity;
            _contexto.SaveChanges();
            return nuevoDueño;
        }

        public void DeleteDueños(int cedula)
        {
            Dueño dueñoEncontrado = _contexto.Dueños.FirstOrDefault(d => d.cedula == cedula);
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
            Dueño dueñoEncontrado = _contexto.Dueños.FirstOrDefault(d => d.cedula == cedula);
            return dueñoEncontrado;
        }

        public Dueño EditDueños(Dueño dueño)
        {
            //Deuño dueñoEncontrada = _contexto.Dueños.FirstOrDefault(d => d.Id == dueño.Id);
            //String password = dueño.password;
            //password = security.GetMD5Hash(password);
            //dueño.password = password;

            Dueño dueñoEncontrado = _contexto.Dueños.FirstOrDefault(d => d.cedula == dueño.cedula);
            if(dueñoEncontrado != null){
                dueñoEncontrado.nombre = dueño.nombre;
                dueñoEncontrado.apellido = dueño.apellido;
                dueñoEncontrado.cedula = dueño.cedula;
                dueñoEncontrado.celular = dueño.celular;
                dueñoEncontrado.direccion = dueño.direccion;
                dueñoEncontrado.ciudad = dueño.ciudad;
                dueñoEncontrado.email = dueño.email;
                dueñoEncontrado.password = dueño.password;
                dueñoEncontrado.username = dueño.username;
                _contexto.SaveChanges();
            }
            return dueñoEncontrado;

        }
    }
}