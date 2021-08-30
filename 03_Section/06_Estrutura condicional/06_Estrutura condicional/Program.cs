using System;

namespace _06_Estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checa se número é par:");


            Console.WriteLine("Informe um número inteiro:");
            int numInt;
            try
            {
                numInt = int.Parse(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Número deve ser inteiro");
            }

            if(numInt % 2 == 0)
            {
                Console.WriteLine($"O número: {numInt}, é par!");
            }
            else
            {
                Console.WriteLine($"O número: {numInt}, NÃO é par!");
            };
            for( var i = 0; i <= 4; i++)
            {
                Console.WriteLine("EXERCÍCIO 2 PERÍODO DO DIA");

                Console.WriteLine("Informe a hora atual:");
                int hora = int.Parse(Console.ReadLine());

                if(hora < 12 && hora > 4)
                {
                    Console.WriteLine("Bom dia");
                }
                if(hora < 18 && hora > 12)
                {
                    Console.WriteLine("Boa Tarde");
                }
                if(hora < 23 && hora > 18)
                {
                    Console.WriteLine("Boa Noite");
                }
                else
                {
                    Console.WriteLine("Vá dormir, já é madrugada!");
                }

            };


            
 
        }
    }
}
