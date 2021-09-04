using System;

namespace _05_ExercicioContaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            Console.WriteLine("Entre com o número da conta:");
            conta.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o nome do Titular da conta:");
            conta.Titular = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial? (s/n)");
            string sn = Console.ReadLine();
            if(sn == "s")
            {
                Console.WriteLine("Entre com o valor do depósito inicial:");
                conta.Saldo = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Dados da conta: " + conta);

            Console.WriteLine("Entre com valor para depósito:");
            double valorDeposito = double.Parse(Console.ReadLine());
            conta.Deposito(valorDeposito);

            Console.WriteLine("Entre com valor para saque:");
            double valorSaque = double.Parse(Console.ReadLine());
            conta.Saque(valorSaque);

        }
    }
}
