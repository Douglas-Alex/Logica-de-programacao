using System;

namespace SalarioComBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo;
            double totalVendas;
            double salarioReceber;

            Console.WriteLine("Nome do vendedor(a):");
            nome = Console.ReadLine();
            Console.WriteLine("Salario fixo vendedor(a):");
            salarioFixo = double.Parse(Console.ReadLine());
            Console.WriteLine("Total de vendas efetuada no mês pelo vendedor(a):");
            totalVendas = double.Parse(Console.ReadLine());

            salarioReceber = ((double)15/100)* totalVendas + salarioFixo;

            Console.WriteLine(nome+" vai receber R$ " +salarioReceber.ToString("F2"));
        }
    }
}
