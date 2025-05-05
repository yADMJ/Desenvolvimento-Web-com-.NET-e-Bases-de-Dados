using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace LojaRazor.Pages
{
    public class AddEventModel : PageModel
    {
        private readonly EventService _eventService;

        public string Message { get; set; }

        public AddEventModel(EventService eventService)
        {
            _eventService = eventService;
        }

        public void OnPost(string title, DateTime date, string location)
        {
            try
            {
                _eventService.CreateEvent(title, date, location);

                Message = "Evento cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
                Message = $"Erro ao cadastrar evento: {ex.Message}";
            }
        }
    }
}
