using FactoryMethod.Entities;
using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonagemFactory factoryMethod = new IPersonagemFactory();
            IPersonagem personagem;

            string nomeJogador;
            string personagemJogador;

            for (int jogador = 1; jogador <= 2; jogador++)
            {
                Console.Write(@"Digite o nome do Jogador {0}: ", jogador);
                nomeJogador = Console.ReadLine().ToString();
                Console.WriteLine();

                Console.WriteLine(@"{0} Personagens disponíveis: ", nomeJogador);
                Console.WriteLine("1 - Liu Kang | 2 - Sub Zero | 3 - Scorpion");
                
                Console.WriteLine();
                Console.Write("Digite o número de seu personagem: ");

                personagemJogador = Console.ReadLine().ToString();
                personagem = factoryMethod.EscolherPersonagem(personagemJogador);

                Console.WriteLine();
                Console.Write(@"{0}, Você vai jogar com ", nomeJogador);
                personagem.Escolhido();

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
