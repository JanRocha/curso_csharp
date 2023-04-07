using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaBancaria {
    internal class ContaBancaria {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titular){
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = 0;
        }
        
        public ContaBancaria(int numeroConta, string titular, double saldo): this(numeroConta, titular){
            Saldo = saldo;
        }

        public void Deposito(double Quantia){
            Saldo += Quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;    
        }

        public override string ToString(){
            return "Conta " + NumeroConta + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
