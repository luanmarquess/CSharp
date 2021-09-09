using System;

namespace _05_ExercicioContaBanco
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o número da conta:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o nome do Titular da conta:");
            string titular = Console.ReadLine();
  
            Console.WriteLine("Haverá depósito inicial? (s/n)");
            char sn = char.Parse(Console.ReadLine());
            double depositoInicial = 0;
            if (sn == 's' || sn == 'S')
            {
                Console.WriteLine("Entre com o valor do depósito inicial:");
                depositoInicial = double.Parse(Console.ReadLine());
            }
 
            Conta conta = new Conta(numero, titular, depositoInicial);

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
