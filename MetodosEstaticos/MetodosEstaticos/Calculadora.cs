namespace MetodosEstaticos
{
    class Calculadora
    {
        public double pi = 3.14;
        public double Circunferencia(double raio)
        {
            return 2.0 * pi * raio;
        }
        public double volume(double raio)
        {
            return 4.0 / 3.0 * pi * raio * raio * raio;
        }
    }
}
