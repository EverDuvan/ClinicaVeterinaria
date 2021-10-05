using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVet.App.Dominio;

namespace ClinicaVet.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        private readonly Contexto _contexto; 
        

        public RepositorioVeterinario(Contexto contexto){
            this._contexto = contexto;
            
        }
        public Veterinario AddVeterinarios(Veterinario veterinario)
        {
            Veterinario nuevoVeterinario =_contexto.Add(veterinario).Entity;
            _contexto.SaveChanges();
            return nuevoVeterinario;
        }

        public void DeleteVeterinarios(int cedula)
        {
            Veterinario veterinarioEncontrado = _contexto.Veterinarios.FirstOrDefault(d => d.cedula == cedula);
            if(veterinarioEncontrado != null){
                _contexto.Veterinarios.Remove(veterinarioEncontrado);
                _contexto.SaveChanges();
            }
        }
        public IEnumerable<Veterinario> GetAllVeterinarios()
        {
            return _contexto.Veterinarios;
        }
        public Veterinario GetVeterinarios(int cedula)
        {
            Veterinario veterinarioEncontrado = _contexto.Veterinarios.FirstOrDefault(d => d.cedula == cedula);
            return veterinarioEncontrado;
        }

        public Veterinario EditVeterinarios(Veterinario veterinario)
        {
            Veterinario veterinarioEncontrado =_contexto.Veterinarios.FirstOrDefault(d => d.cedula == veterinario.cedula);
            if(veterinarioEncontrado != null){
                veterinarioEncontrado.nombre = veterinario.nombre;
                veterinarioEncontrado.apellido = veterinario.apellido;
                veterinarioEncontrado.cedula = veterinario.cedula;
                veterinarioEncontrado.celular = veterinario.celular;
                veterinarioEncontrado.direccion = veterinario.direccion;
                veterinarioEncontrado.ciudad = veterinario.ciudad;
                veterinarioEncontrado.email = veterinario.email;
                veterinarioEncontrado.password = veterinario.password;
                veterinarioEncontrado.username = veterinario.username;
                _contexto.SaveChanges();
            }
            return veterinarioEncontrado;

        }
    }
}