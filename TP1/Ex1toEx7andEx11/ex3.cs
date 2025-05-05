using System;

namespace CalculoAreaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Cálculo de Área de um Retângulo ===");

            Console.Write("Informe a base do retângulo: ");
            if (!double.TryParse(Console.ReadLine(), out double baseRetangulo))
            {
                Console.WriteLine("Valor inválido para a base!");
                return;
            }

            Console.Write("Informe a altura do retângulo: ");
            if (!double.TryParse(Console.ReadLine(), out double alturaRetangulo))
            {
                Console.WriteLine("Valor inválido para a altura!");
                return;
            }

            Func<double, double, double> calcularArea = (baseValor, alturaValor) => baseValor * alturaValor;

            double area = calcularArea(baseRetangulo, alturaRetangulo);

            Console.WriteLine($"A área do retângulo é: {area:F2}");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
