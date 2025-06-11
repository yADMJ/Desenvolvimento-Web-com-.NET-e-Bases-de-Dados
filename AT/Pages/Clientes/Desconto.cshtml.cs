using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TurismoApp.Services;

namespace TurismoApp.Pages
{
    public class DescontoModel : PageModel
    {
        [BindProperty]
        public decimal PrecoOriginal { get; set; }

        public decimal PrecoComDesconto { get; set; }

        public void OnPost()
        {
            // Cria a inst�ncia do delegate apontando para a fun��o de desconto
            CalculateDelegate calcular = new CalculateDelegate(DiscountService.AplicarDesconto);

            // Aplica o desconto
            PrecoComDesconto = calcular(PrecoOriginal);
        }
    }
}
