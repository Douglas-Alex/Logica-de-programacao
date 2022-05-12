using System;
using System.Globalization;

namespace ExercicioDeFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            int Idade;
            double Altura;
            int Quarto;
            double Preco;

            Console.WriteLine("Digite seu nome completo:");
            Nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            Quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor avaliado de sua casa?");
            Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua idade e altura:");
            string[] vet = Console.ReadLine().Split(' ');
            Idade = int.Parse(vet[0]);
            Altura = double.Parse(vet[1]);

            Console.WriteLine(Nome+ " você tem " +Idade+ " anos e " +Altura+ " de altura, sua casa possui "
                              +Quarto+ " quarto(s) e sua casa foi avaliada em R$ " +Preco.ToString("F2")+ ".");
        }
    }
}
