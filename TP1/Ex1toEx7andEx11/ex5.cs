using System;
using System.Threading;

namespace SimuladorDownload
{
    class DownloadManager
    {
        public event EventHandler DownloadCompleted;

        public void StartDownload(string arquivo)
        {
            Console.WriteLine($"Iniciando download do arquivo: {arquivo}...");
            Thread.Sleep(5000);

            Console.WriteLine("Processo de download finalizado internamente.");

            OnDownloadCompleted(EventArgs.Empty);
        }

        protected virtual void OnDownloadCompleted(EventArgs e)
        {
            DownloadCompleted?.Invoke(this, e);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DownloadManager manager = new DownloadManager();

            manager.DownloadCompleted += Manager_DownloadCompleted;

            Console.WriteLine("=== Sistema de Download ===");
            Console.Write("Digite o nome do arquivo para download: ");
            string arquivo = Console.ReadLine();

            manager.StartDownload(arquivo);

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        private static void Manager_DownloadCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("? Download concluído com sucesso!");
        }
    }
}
