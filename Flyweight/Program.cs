using System;
using Flyweight.Entities;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            TartarugaFlyweight tartarugaFlyweight = new TartarugaFlyweight();
            string cor = string.Empty;

            Tartaruga tartaruga;

            while (true)
            {
                Console.WriteLine();

                Console.Write("Qual tartaruga enviar para a tela: ");
                cor = Console.ReadLine();

                tartaruga = tartarugaFlyweight.GetTartaruga(cor);
                tartaruga.Mostra(cor);

                Console.WriteLine();

                Console.WriteLine("-------------");
            }
        }
    }
}
