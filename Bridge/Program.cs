using Bridge.Entities;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            BridgePattern bridge = new BridgePattern();
            Random random = new Random();

            void Sortear()
            {
                if (random.Next(2) == 1)
                    bridge.formaSolicitada = new FormaUm();
                else
                    bridge.formaSolicitada = new FormaDois();

                if (random.Next(1, 3) == 1)
                    bridge.formaSolicitada.ICor = new Verde();
                else if (random.Next(1, 3) == 2)
                    bridge.formaSolicitada.ICor = new Laranja();
                else if (random.Next(1, 3) == 3)
                    bridge.formaSolicitada.ICor = new Rosa();
            }

            Console.WriteLine("Pressione ENTER para enviar uma forma");

            while(1 > 0)
            {
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.KeyChar == 13)
                    Sortear();

                Console.WriteLine();
                bridge.ExibeQualformaEstaDescendoNaTela();
            }
        }
    }
}
