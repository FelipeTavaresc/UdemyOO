﻿using System.Globalization;

namespace ConstrutoresEx05
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria() { }

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int numeroConta, string titular, double depositoInicial) : this(numeroConta, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
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
