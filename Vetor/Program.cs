using System;
using System.Globalization;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de Produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[i] = new Produto { Nome = name, Valor = price };
            }
            double soma = 0;
            for (int i = 0; i <n; i++)
            {
                soma += vetor[i].Valor;
            }

            double avg = soma / n;
            Console.WriteLine(avg);

            Console.WriteLine();
            Console.WriteLine("Teste");

        }
    }
}
