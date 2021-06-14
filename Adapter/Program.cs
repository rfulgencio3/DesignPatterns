using Adapter.Entities;
using Adapter.Interfaces;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem = new Personagem();
            Aviao aviaoDeBatalha = new Aviao();

            IAcao adapter = new Adaptador(aviaoDeBatalha);

            Console.WriteLine("--- CAMINHANDO ---");
            personagem.Andar("Ricardo");
            personagem.Atirar();

            Console.WriteLine("--- PEGOU UM AVIAO ---");
            adapter.Andar("Ricardo");
            adapter.Atirar();
        }
    }
}
