using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClinicaVet.App.Dominio;
using ClinicaVet.App.Persistencia;

namespace ClinicaVet.App.Frontend.Pages
{
    public class ListaAgendaModel : PageModel
    {
    private readonly IRepositorioAgenda repositorioAgenda;
    public IEnumerable <Agenda> agendas;
    public ListaAgendaModel(IRepositorioAgenda repositorio){
        this.repositorioAgenda = repositorio;
        agendas = repositorioAgenda.getAllAgendas();
        }
    public void OnGet()
    {
      }
    }    
}

