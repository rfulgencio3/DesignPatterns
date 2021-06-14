using System;

namespace FactoryMethod.Entities.Personagens
{
    public class LiuKang : IPersonagem
    {
        public void Escolhido()
        {
            Console.Write("Liu Kang");
        }
    }
}
