using System;


namespace _07_ExercícioFuncionario
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto, Imposto;

        public override string ToString()
        {
            return $"Nome: {this.Nome}, salário: ${this.CalculaSalarioLiquido()}";
        }

        public double CalculaSalarioLiquido()
        {
            return this.SalarioBruto - this.Imposto;
        }

        public void BonificacaoSalario(double porcentagem)
        {
            this.SalarioBruto += this.SalarioBruto * (porcentagem / 100);
        }

    }
}
