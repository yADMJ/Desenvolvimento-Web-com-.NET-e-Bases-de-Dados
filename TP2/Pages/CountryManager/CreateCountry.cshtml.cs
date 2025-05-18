using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class CreateCountryModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; }

    public Country SubmittedCountry { get; set; }

    public void OnPost()
    {
        if (!ModelState.IsValid)
            return;

        if (!string.IsNullOrEmpty(Input.CountryName) && !string.IsNullOrEmpty(Input.CountryCode))
        {
            if (Input.CountryName[0] != Input.CountryCode[0])
            {
                ModelState.AddModelError("Input.CountryCode", "O código do país deve começar com a mesma letra do nome.");
                return;
            }
        }

        SubmittedCountry = new Country
        {
            CountryName = Input.CountryName,
            CountryCode = Input.CountryCode
        };
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
