using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProductCatalog.Pages
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public string Nome { get; set; }

        [BindProperty]
        public decimal Preco { get; set; }

        public bool IsSubmitted { get; set; }

        public void OnPost()
        {
            IsSubmitted = true;
        }
    }
}
