using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador preço $ 2100,00";
            string produto2 = "Mesa de escritorio preço $ 650,50";

            byte idade =  30, Anos, de, Idade;
            int codigo = 5290;
            char genero = 'm';

            double preco1 = 2100.50;
            double preco2 = 650.50;
            double Medida = 53.234567;

            Console.WriteLine(produto1);
            Console.WriteLine(produto2);
            Console.WriteLine(idade);
            Console.WriteLine(codigo);
            Console.WriteLine(genero);
            Console.WriteLine(preco1);
            Console.WriteLine(preco2);
            Console.WriteLine(Medida + Medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
