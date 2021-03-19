using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace POO
{
    class Banco
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public string Valor { get; set; }
        public double Saldo { get; set; }

        public double SomarSaldo(double somar)
        {
            Saldo = Saldo + somar;
            return somar;
        }

        public double SaqueSaldo(double valor)
        {
            Saldo = (Saldo - valor) - 5.0;
            return valor;
        }

        public override string ToString()
        {
            return "Conta " +
                    NumeroConta +
                    ", " +
                    "Titular: " +
                    Titular +
                    ", " +
                    "Saldo: " +
                    "$" + Saldo.ToString("F2",CultureInfo.InvariantCulture); 
        }
    }

   
}
