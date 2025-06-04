using CityBreaks.Web.Data;
using CityBreaks.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Web.Pages
{
    public class CreatePropertyModel : PageModel
    {
        private readonly CityBreaksContext _context;

        public CreatePropertyModel(CityBreaksContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Property Property { get; set; } = new();

        public SelectList Cities { get; set; }

        public async Task OnGetAsync()
        {
            var cities = await _context.Cities
                .OrderBy(c => c.Name)
                .ToListAsync();

            Cities = new SelectList(cities, "Id", "Name");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Console.WriteLine($"Tentando salvar: {Property.Name}, {Property.PricePerNight}, CidadeId: {Property.CityId}");

            await _context.Properties.AddAsync(Property);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }

    }
}
