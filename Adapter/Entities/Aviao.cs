using System;

namespace Adapter.Entities
{
    public class Aviao
    {
        public void Voar(string personagem)
        {
            Console.WriteLine("{0} VOOU PARA FRENTE!", personagem);
        }
        public void SoltarMissil()
        {
            Console.WriteLine("Soltou um míssil no jogo!");
        }
    }
}
