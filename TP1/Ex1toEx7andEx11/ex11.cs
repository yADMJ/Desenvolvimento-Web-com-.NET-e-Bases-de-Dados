using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string> manipularNome = ConcatenarNome;

            manipularNome += ConverterMaiusculas;
            manipularNome += RemoverEspacos;

            string nome = "João";
            string sobrenome = " Silva";

            string resultado = manipularNome(nome, sobrenome);

            Console.WriteLine("Resultado final: " + resultado);
        }

        static string ConcatenarNome(string nome, string sobrenome)
        {
            return nome + sobrenome;
        }

        static string ConverterMaiusculas(string texto, string sobrenome)
        {
            return texto.ToUpper();
        }
        static string RemoverEspacos(string texto, string sobrenome)
        {
            return texto.Replace(" ", "");
        }
    }
}

