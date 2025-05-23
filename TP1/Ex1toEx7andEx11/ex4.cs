using System;

namespace MonitoramentoTemperatura
{
    class TemperatureSensor
    {
        public delegate void TemperatureExceededEventHandler(double temperature);

        public event TemperatureExceededEventHandler TemperatureExceeded;

        public void ReadTemperature(double temperature)
        {
            Console.WriteLine($"Leitura: {temperature}ºC");

            if (temperature > 100)
            {
                TemperatureExceeded?.Invoke(temperature);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor();

            sensor.TemperatureExceeded += Sensor_TemperatureExceeded;

            Console.WriteLine("=== Monitoramento de Temperatura ===");
            Console.WriteLine("Digite valores de temperatura (ou 'sair' para encerrar):");

            while (true)
            {
                Console.Write("Temperatura: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "sair")
                    break;

                if (double.TryParse(input, out double temperatura))
                {
                    sensor.ReadTemperature(temperatura);
                }
                else
                {
                    Console.WriteLine("Valor inválido. Tente novamente.");
                }
            }

            Console.WriteLine("Monitoramento encerrado. Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        private static void Sensor_TemperatureExceeded(double temperature)
        {
            Console.WriteLine($"?? ALERTA: Temperatura excedida! Valor registrado: {temperature}ºC");
        }
    }
}
