using AbstractFactory.Entities.Interfaces;
using System;

namespace AbstractFactory.Entities
{
    public class EnergiaBaseTerran : IEnergia
    {
        public void Composicao() 
        {
            Console.WriteLine("Energia de sustentação da base mecânica");
        }
    }
}
