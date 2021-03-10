using System;
using System.Globalization;


namespace MetodosEstaticos
{
    class Program
    {
   
        static void Main(string[] args)
        {
            Calculadora Calc = new Calculadora();
            Console.Write("Entre o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calc.Circunferencia(raio);
            double vol = Calc.volume(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("vol: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi:  " + Calc.pi.ToString());
        }
        
    }
}
