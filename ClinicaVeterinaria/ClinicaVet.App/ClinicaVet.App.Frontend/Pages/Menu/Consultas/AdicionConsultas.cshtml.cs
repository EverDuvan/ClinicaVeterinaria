using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ClinicaVet.App.Dominio;
using ClinicaVet.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClinicaVet.App.Frontend.Pages
{
    public class AdicionConsultasModel : PageModel
    {
        private readonly IRepositorioConsulta repositorioConsulta;
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        private readonly IRepositorioVeterinario repositorioVeterinario;
        private readonly IRepositorioMascota repositorioMascota;
        private readonly IRepositorioHistoriaClinica repositorioHistoriaClinica;

        public IEnumerable<SelectListItem> mascotas { get; set; }
        public IEnumerable<SelectListItem> veterinarios { get; set; }
        public IEnumerable<SelectListItem> auxiliares { get; set;}
        public Consulta consulta { get; set; }
        public Receta receta { get; set; }
        public int cedulaVeterinario { get; set; }
        public int cedulaDueño { get; set; }
        public int cedulaAuxiliar { get; set; }
        public int IdMascota { get; set; }

        public AdicionConsultasModel(IRepositorioConsulta repositorioConsulta, IRepositorioAuxiliar repositorioAuxiliar, IRepositorioVeterinario repositorioVeterinario, RepositorioHistoriaClinica repositorioHistoriaClinica, IRepositorioMascota repositorioMascota)
        {
            this.repositorioConsulta = repositorioConsulta;
            this.repositorioAuxiliar = repositorioAuxiliar;
            this.repositorioVeterinario = repositorioVeterinario;
            this.repositorioHistoriaClinica = repositorioHistoriaClinica;
            this.repositorioMascota = repositorioMascota;

            veterinarios = repositorioVeterinario.GetAllVeterinarios().Select(
                v => new SelectListItem{
                    Value = Convert.ToString(v.cedula),
                    Text = v.nombre
                }
            );
            auxiliares = repositorioAuxiliar.GetAllAuxiliares().Select(
                a => new SelectListItem{
                    Value = Convert.ToString(a.cedula),
                    Text = a.nombre
                }
            );
            mascotas = repositorioMascota.GetAllMascotas().Select(
                m => new SelectListItem{
                    Value = Convert.ToString(m.Id),
                    Text = m.nombre
                }
            );
            consulta = new Consulta();
            receta = new Receta();
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Consulta consulta,int cedulaVeterinario,int cedulaAuxiliar,int IdMascota, Receta receta)
        {
            if(ModelState.IsValid){
                Veterinario veterinario = repositorioVeterinario.GetVeterinarios(cedulaVeterinario);
                Auxiliar auxiliar = repositorioAuxiliar.GetAuxiliar(cedulaAuxiliar);
                Mascota mascota = repositorioMascota.GetMascotas(IdMascota);

                Consulta consultaNueva = new Consulta(){
                    mascota = mascota,
                    auxiliar = auxiliar,
                    veterinario = veterinario,
                    FechaConsulta = consulta.FechaConsulta,
                    anotacion = consulta.anotacion,
                    receta = receta,
                    medicamentos = receta.medicamentos
                };

                HistoriaClinica historia = repositorioHistoriaClinica.historiaPorMascota(mascota);

                /*
                Si la persona tiene anotaciones quiere decir que tiene una historia clinica, si no debemos crearla
                */
                if(historia == null){
                    historia = new HistoriaClinica(){
                        resumen = " Nombre Mascota " + mascota.nombre +"Fecha: "+ DateTime.Now,
                        consultas = new List<Consulta>{consultaNueva}
                    };
                    repositorioHistoriaClinica.addHistoria(historia);
                }else{
                    List<Consulta> listaConsultas = historia.consultas;
                    listaConsultas.Add(consultaNueva);
                    historia.consultas = listaConsultas;
                    repositorioHistoriaClinica.editHistoria(historia);
                }

                return RedirectToPage("./ListAnotacion");
            }
            else{
                return Page();
            }
        }
    }
}
