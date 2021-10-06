using System;
using System.Collections.Generic;
using ClinicaVet.App.Dominio;

namespace ClinicaVet.App.Persistencia
{
    public interface IRepositorioHistoriaClinica{
        IEnumerable<HistoriaClinica> getAllHistorias();
        HistoriaClinica getHistoria(int id);
        HistoriaClinica editHistoria(HistoriaClinica historiaClinica);
        HistoriaClinica addHistoria(HistoriaClinica historia);
        void RemoveHistoria(int id);
        HistoriaClinica historiaPorMascota(Mascota mascota);
        IEnumerable<HistoriaClinica> historiaPorVeterinario(Veterinario veterinario);
        IEnumerable<HistoriaClinica> historiaPorAuxiliar(Auxiliar auxiliar);
        HistoriaClinica historiaPorFechaYMascota(DateTime fecha_inicio, DateTime fecha_final, Mascota mascota);
    }
}