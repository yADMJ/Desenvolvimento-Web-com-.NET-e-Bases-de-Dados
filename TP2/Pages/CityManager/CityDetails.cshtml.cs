using Microsoft.AspNetCore.Mvc.RazorPages;

public class CityDetailsModel : PageModel
{
    public string CityName { get; set; }

    public void OnGet(string cityName)
    {
        CityName = cityName;
    }
}
