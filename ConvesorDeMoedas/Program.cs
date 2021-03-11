using System;
using System.Globalization;

namespace ConvesorDeMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a contação di dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dolares desaja comprar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total = Conversor.Converter(cotacao, dolar);
            Console.Write("valor a ser pago em reais : " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
