using System.Globalization;

namespace ContaBancaria{
    class Program{
        static void Main(string[] args){
            ContaBancaria Conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta:");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial(s/n)?");
            char resposta = char.Parse(Console.ReadLine());
            
            if (resposta.Equals('S') || resposta.Equals('s')){
                Console.WriteLine("Digite o valor Inicial: ");
                double ValorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta = new ContaBancaria(numero, titular, ValorInicial);
            }
            else{
                Conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine("");
            Console.WriteLine("Dados da conta");
            Console.WriteLine(Conta);
            Console.WriteLine("");

            Console.WriteLine("Entre com valor de depósito:");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.Deposito(quantia);
            Console.WriteLine(Conta);
            Console.WriteLine("");

            Console.WriteLine("Entre com valor de saque:");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.Saque(quantia);
            Console.WriteLine(Conta);
            Console.WriteLine("");
        }

    }
}