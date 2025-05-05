using System;

namespace MensagensMultilingue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Boas-Vindas Multilíngue ===");
            Console.WriteLine("Escolha um idioma:");
            Console.WriteLine("1 - Português");
            Console.WriteLine("2 - Inglês");
            Console.WriteLine("3 - Espanhol");
            Console.Write("Digite o número correspondente ao idioma: ");

            string escolha = Console.ReadLine();

            Action<string> exibirMensagem;

            switch (escolha)
            {
                case "1":
                    exibirMensagem = MensagemPortugues;
                    break;
                case "2":
                    exibirMensagem = MensagemIngles;
                    break;
                case "3":
                    exibirMensagem = MensagemEspanhol;
                    break;
                default:
                    Console.WriteLine("Opção inválida! Será exibida a mensagem padrão em Português.");
                    exibirMensagem = MensagemPortugues;
                    break;
            }

            exibirMensagem("usuário");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        static void MensagemPortugues(string nome)
        {
            Console.WriteLine($"Bem-vindo, {nome}! Esperamos que você aproveite nossa plataforma.");
        }

        static void MensagemIngles(string name)
        {
            Console.WriteLine($"Welcome, {name}! We hope you enjoy our platform.");
        }

        static void MensagemEspanhol(string nombre)
        {
            Console.WriteLine($"¡Bienvenido, {nombre}! Esperamos que disfrutes de nuestra plataforma.");
        }
    }
}
