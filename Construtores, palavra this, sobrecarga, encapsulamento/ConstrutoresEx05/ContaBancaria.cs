using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresEx05
{
    class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria() { }

        public ContaBancaria(int numeroConta, string titular, double depositoInicial)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = depositoInicial;
        }

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = 0.0;
        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Saque(double valor)
        {
            Saldo = Saldo - (valor + 5.00);
        }

        public override string ToString()
        {
            return
                "Conta " + NumeroConta + ", " +
                "Titular: " + Titular + ", " +
                "Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
