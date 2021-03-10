using System;
using System.Globalization;

namespace MetodosEstaticos
{
    class Program
    {
        static double pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circunferencia(raio);
            double vol = volume(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("vol: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi:  " + pi.ToString());
        }
        static double Circunferencia(double raio)
        {
            return 2.0 * pi * raio;
        }
        static double volume (double raio)
        {
            return 4.0 / 3.0 * pi * raio * raio * raio;
        }
    }
}
