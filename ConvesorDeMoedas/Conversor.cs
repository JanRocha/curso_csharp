using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvesorDeMoedas
{
    class Conversor
    {
        public static double iof = 6;

        public static double Converter(double cotacao, double valor)
        {
            double calc = valor * cotacao;
            calc = calc + ((calc * iof) / 100);
            return calc;
        }
    }
}
