using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class CreateCityModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; }

    public string SubmittedCity { get; set; }

    public void OnPost()
    {
        if (!ModelState.IsValid)
            return;

        SubmittedCity = Input.CityName;
    }

    public class InputModel
    {
        [Required(ErrorMessage = "O nome da cidade é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome da cidade deve ter no mínimo 3 caracteres.")]
        public string CityName { get; set; }
    }
}
