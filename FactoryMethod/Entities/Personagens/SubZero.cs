using System;

namespace FactoryMethod.Entities.Personagens
{
    public class SubZero : IPersonagem
    {
        public void Escolhido()
        {
            Console.Write("Sub Zero");
        }
    }
}
