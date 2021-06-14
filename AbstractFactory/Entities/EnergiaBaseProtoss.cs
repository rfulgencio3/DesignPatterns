using AbstractFactory.Entities.Interfaces;
using System;

namespace AbstractFactory.Entities
{
    public class EnergiaBaseProtoss : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base com cristais");
        }
    }
}
