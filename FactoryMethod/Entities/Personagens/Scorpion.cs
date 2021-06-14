using System;

namespace FactoryMethod.Entities.Personagens
{
    public class Scorpion : IPersonagem
    {
        public void Escolhido()
        {
            Console.Write("Scorpion");
        }
    }
}
