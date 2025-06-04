using Microsoft.AspNetCore.Mvc.RazorPages;
using CityBreaks.Web.Models;
using CityBreaks.Web.Services;
using Microsoft.AspNetCore.Mvc;

public class CityDetailsModel : PageModel
{
    private readonly ICityService _cityService;

    public CityDetailsModel(ICityService cityService)
    {
        _cityService = cityService;
    }

    [BindProperty(SupportsGet = true)]
    public string Name { get; set; }

    public City? City { get; set; }

    public async Task OnGetAsync()
    {
        if (!string.IsNullOrEmpty(Name))
        {
            City = await _cityService.GetByNameAsync(Name);
        }
    }
}
