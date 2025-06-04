using CityBreaks.Web.Data;
using CityBreaks.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Web.Pages
{
    public class EditPropertyModel : PageModel
    {
        private readonly CityBreaksContext _context;

        public EditPropertyModel(CityBreaksContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Property Property { get; set; }

        public SelectList CityOptions { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Property = await _context.Properties.FindAsync(id);
            if (Property == null)
            {
                return NotFound();
            }

            CityOptions = new SelectList(await _context.Cities.ToListAsync(), "Id", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var propertyToUpdate = await _context.Properties.FindAsync(id);
            if (propertyToUpdate == null)
            {
                return NotFound();
            }

            var updated = await TryUpdateModelAsync(
                propertyToUpdate,
                "Property",
                p => p.Name, p => p.PricePerNight, p => p.CityId);

            if (!updated)
            {
                ModelState.AddModelError("", "Falha ao atualizar o modelo.");
            }

            if (updated && ModelState.IsValid)
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("/Index");
            }

            CityOptions = new SelectList(await _context.Cities.ToListAsync(), "Id", "Name");
            return Page();
        }

    }
}
