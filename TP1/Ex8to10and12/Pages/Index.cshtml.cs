using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace LojaRazor.Pages
{
    public class IndexModel : PageModel
    {
        public List<Produto> Produtos { get; set; }

        public void OnGet()
        {
            Produtos = new List<Produto>
            {
                new Produto { Nome = "Notebook Dell", Preco = 3500.00m },
                new Produto { Nome = "Mouse Logitech", Preco = 150.00m },
                new Produto { Nome = "Monitor LG", Preco = 1200.00m }
            };
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
