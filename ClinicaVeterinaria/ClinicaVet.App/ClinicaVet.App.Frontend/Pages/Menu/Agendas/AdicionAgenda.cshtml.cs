using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClinicaVet.App.Dominio;
using ClinicaVet.App.Persistencia;

namespace ClinicaVet.App.Frontend.Pages
{
        public class AddAgendaModel : PageModel
    {
        private readonly IRepositorioAgenda repositorioAgenda;
        private readonly IRepositorioVeterinario repositorioVeterinario;
        private readonly IRepositorioDueño repositorioDueño;
        public Agenda agenda { get; set; }
        public SelectList veterinarios { get; set; }
        public SelectList dueños { get; set; }
        public string mensaje { get; set; }

        public int cedulaVeterinario { get; set; }
        public int cedulaDueño { get; set; }
        public AddAgendaModel(IRepositorioAgenda repositorioAgenda, IRepositorioVeterinario repositorioVeterinario, IRepositorioDueño repositorioDueño){
            this.repositorioVeterinario = repositorioVeterinario;
            this.repositorioAgenda = repositorioAgenda;
            this.repositorioDueño = repositorioDueño;
            
            veterinarios =new SelectList (repositorioVeterinario.GetAllVeterinarios(),nameof(Veterinario.cedula),nameof(Veterinario.nombre));

            dueños =new SelectList (repositorioDueño.GetAllDueños(),nameof(Dueño.cedula),nameof(Dueño.nombre));
 
        /*public AddAgendaModel(Agenda agenda, SelectList veterinarios, string mensaje, int cedulaVeterinario) 
        {
            this.agenda = agenda;
            this.veterinarios = veterinarios;
            this.mensaje = mensaje;
            this.cedulaVeterinario = cedulaVeterinario;
               
        }
        
        public AddAgendaModel(Agenda agenda, SelectList veterinarios, int cedulaVeterinario, string mensaje) 
        {
            this.agenda = agenda;
            this.veterinarios = veterinarios;
            this.cedulaVeterinario = cedulaVeterinario;
            this.mensaje = mensaje;
              
        }*/

        
        }
        

        public void OnGet()
        {
        }
        public IActionResult OnPost(Agenda agenda, int cedulaVeterinario, int cedulaDueño ){ 
            if (ModelState.IsValid){
                Veterinario veterinario =repositorioVeterinario.GetVeterinarios(cedulaVeterinario);
                Dueño dueño =repositorioDueño.GetDueños(cedulaDueño);
                
                Agenda nuevaAgenda= new Agenda(){
                    veterinario= veterinario,
                    dueño=dueño,
                    descripcion= agenda.descripcion,
                    sala= agenda.sala,
                    dia = agenda.dia,
                    hora= agenda.hora,    
                };
                Agenda agendaResultante =repositorioAgenda.addAgenda(nuevaAgenda); 
                if(agendaResultante == null){
                    mensaje="El Veterinario tiene cita a esa hora , agende otra";
                    return Page();
                    }
                else {
                    return RedirectToPage("./ListaAgenda");
                }        
            }
            else {
                     return Page();
                }    
        }
    }
}

