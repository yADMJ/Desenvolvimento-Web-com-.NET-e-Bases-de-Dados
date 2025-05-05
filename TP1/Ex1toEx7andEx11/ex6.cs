using System;
using System.IO;

namespace SistemaDeLogs
{
    class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine($"[Console] {message}");
        }

        public void LogToFile(string message)
        {
            string caminhoArquivo = "log.txt";
            File.AppendAllText(caminhoArquivo, $"[Arquivo] {message}{Environment.NewLine}");
            Console.WriteLine($"[Arquivo] Mensagem registrada no arquivo '{caminhoArquivo}'.");
        }

        public void LogToDatabase(string message)
        {
            Console.WriteLine($"[Banco de Dados] Mensagem registrada no banco: {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            Action<string> logDelegate = null;
            logDelegate += logger.LogToConsole;
            logDelegate += logger.LogToFile;
            logDelegate += logger.LogToDatabase;

            Console.WriteLine("=== Sistema de Logs Corporativo ===");
            Console.Write("Digite a mensagem de log: ");
            string mensagem = Console.ReadLine();

            logDelegate(mensagem);

            Console.WriteLine("Log registrado em todos os destinos. Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

