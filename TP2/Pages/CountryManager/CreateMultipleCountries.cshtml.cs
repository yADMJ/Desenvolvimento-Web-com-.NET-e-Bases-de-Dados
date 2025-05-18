using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class CreateMultipleCountriesModel : PageModel
{
    [BindProperty]
    public List<InputModel> Countries { get; set; } = new List<InputModel>();

    public List<Country> SubmittedCountries { get; set; }

    public void OnGet()
    {
        for (int i = 0; i < 5; i++)
        {
            Countries.Add(new InputModel());
        }
    }

    public void OnPost()
    {
        if (!ModelState.IsValid)
            return;

        SubmittedCountries = Countries
            .Select(c => new Country { CountryName = c.CountryName, CountryCode = c.CountryCode })
            .ToList();
    }

    public class InputModel
    {
        [Required(ErrorMessage = "O nome do país é obrigatório.")]
        public string CountryName { get; set; }

        [Required(ErrorMessage = "O código do país é obrigatório.")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "O código do país deve ter exatamente 2 caracteres.")]
        public string CountryCode { get; set; }
    }

    public class Country
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }
}
