using System;

namespace DescontoDelegate
{
    delegate decimal CalculateDiscount(decimal originalPrice);

    class Program
    {
        static decimal AplicarDesconto10Porcento(decimal precoOriginal)
        {
            return precoOriginal * 0.90m; 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Descontos ===");
            Console.Write("Informe o preço original do produto: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal precoOriginal))
            {
                CalculateDiscount calcularDesconto = new CalculateDiscount(AplicarDesconto10Porcento);

                decimal precoComDesconto = calcularDesconto(precoOriginal);

                Console.WriteLine($"Preço original: R$ {precoOriginal:F2}");
                Console.WriteLine($"Preço com 10% de desconto: R$ {precoComDesconto:F2}");
            }
            else
            {
                Console.WriteLine("Valor inválido. Digite um número válido.");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
