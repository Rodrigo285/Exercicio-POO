using System;
using System.Globalization;

namespace ContaBancaria {
    internal class Program {
        static void Main(string[] args) {

            ContaCorrente conta;

            Console.Write(" Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if (resp == 's' || resp == 'S') {

                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaCorrente(numero, titular, depositoInicial);
              
               
            }
            else {
                conta = new ContaCorrente(numero, titular);
               
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write(" Entre um valor para depósito:");
            double deposito = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write(" Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine(conta);
            Console.WriteLine();






        }
    }
}