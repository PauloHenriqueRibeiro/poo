using System;
using System.Collections.Generic;
using System.Globalization;
namespace POO
{
    class Program
    {

        static void Main(string[] args)
        {
            int n1, n2, sum;

            Console.WriteLine("Digite um numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outr numero: ");
            n2 = int.Parse(Console.ReadLine());
            sum = n1 + n2;
            Console.WriteLine("A soma de ambos numeros é: " + sum);
            Console.WriteLine("Obrigado por utilizar nosso sistema!");


        }

    }
}
