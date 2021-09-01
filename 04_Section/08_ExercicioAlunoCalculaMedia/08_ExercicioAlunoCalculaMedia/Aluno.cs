using System;
using System.Globalization;

namespace _08_ExercicioAlunoCalculaMedia
{
    class Aluno
    {
        public string Nome;
        public double N1, N2, N3;
        public double NotalFinal;
        public double Media = 60.00;

        public void CalculaMedia()
        {
            this.NotalFinal = N1 + N2 + N3;
        }

        public void PassouDeAno()
        {
            if( this.NotalFinal >= this.Media)
            {
                Console.WriteLine($"NOTA FINAL: {this.NotalFinal.ToString("f2", CultureInfo.InvariantCulture )} APROVADO!!");
            }
            else
            {
                Console.WriteLine($"NOTA FINAL: {this.NotalFinal.ToString("f2", CultureInfo.InvariantCulture)} REPROVADO!!");
                double PontosFaltantes = this.Media - this.NotalFinal;
                Console.WriteLine($"FALTARAM: {PontosFaltantes.ToString("f2", CultureInfo.InvariantCulture)} PONTOS");

            }
        }
    }
}
