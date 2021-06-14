using Observer.Entities;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Cody cody = new Cody();
            Inimigo inimigoUm = new Inimigo(cody);
            Inimigo inimigoDois = new Inimigo(cody);
            Inimigo inimigoTres = new Inimigo(cody);

            while (true)
            {
                Console.WriteLine("Acertar o Cody com um golpe (S ou N)?");

                if (Console.ReadLine() == "s")
                    cody.GolpeAcertado(true);
                else
                    Console.WriteLine("Você não acertou o Cody!");
            }
        }
    }
}
