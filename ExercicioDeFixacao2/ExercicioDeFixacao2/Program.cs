using System;
using System.Globalization;

namespace ExercicioDeFixacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura;
            double comprimento;
            double precoMetroQuadrado;
            double area;
            double preco;

            Console.WriteLine("Informe a largura do seu terreno:");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a comprimento do seu terreno:");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o preço do metro quadrado:");
            precoMetroQuadrado = double.Parse(Console.ReadLine());

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture) + "m");
            Console.WriteLine("Valor avaliado do terreno = R$ " + preco.ToString("F2"));
        }
    }
}
