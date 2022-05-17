using System;
using System.Globalization;

namespace ExercicoDeFixacao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            string nome2;
            int idade1;
            int idade2;
            double media;

            Console.WriteLine("Digite o nome da primeira pessoa:");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa:");
            idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da segunda pessoa:");
            nome2 = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa:");
            idade2 = int.Parse(Console.ReadLine());

            media = (double) (idade1 + idade2) / 2;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos.");
        }
    }
}
