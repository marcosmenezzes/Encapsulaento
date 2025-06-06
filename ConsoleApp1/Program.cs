﻿using System;
using System.Globalization;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial: ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }

            else
            {
                conta = new ContaBancaria (numero, titular);
            }
            Console.WriteLine(  );
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.ReadKey();
        }
    }
}
