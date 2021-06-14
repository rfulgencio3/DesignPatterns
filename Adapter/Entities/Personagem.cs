using System;

namespace Adapter.Entities
{
    public class Personagem
    {
        public void Atirar()
        {
            Console.WriteLine("Atirou no jogo");
        }
        public void Andar(string personagem)
        {
            Console.WriteLine("{0} ANDOU PRA FRENTE!", personagem);
        }
    }
}
