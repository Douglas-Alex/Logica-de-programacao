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
            double idade1;
            double idade2;
            double media;

            Console.WriteLine("Digite o nome da primeira pessoa:");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa:");
            idade1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da segunda pessoa:");
            nome2 = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa:");
            idade2 = double.Parse(Console.ReadLine());

            media = (idade1 + idade2) / 2;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos.");
        }
    }
}
