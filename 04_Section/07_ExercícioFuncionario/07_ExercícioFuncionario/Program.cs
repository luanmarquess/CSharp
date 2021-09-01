using System;
using System.Globalization;

namespace _07_ExercícioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler dados funcionário (nome, salário bruto e imposto);
            // Exibir dados funcionário com base em uma porcentagem dada (somente o salário bruto é afetado pela porcentagem);
            // Aumentar salário do funcionario e exibir novamente.

            Funcionario fulano = new Funcionario();
            Console.WriteLine("Informe os dados do funcionário:");

            Console.WriteLine("Nome:");
            fulano.Nome = Console.ReadLine();

            Console.WriteLine("Salário Bruto:");
            fulano.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Imposto:");
            fulano.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Funcionário: " + fulano);

            Console.WriteLine("Informe a porcentagem a aumento no salário:");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fulano.BonificacaoSalario(aumento);
            Console.WriteLine("Dados Atualizados: " + fulano);


        }
    }
}
