using AbstractFactory.Entities.Interfaces;
using System;

namespace AbstractFactory.Entities
{
    public class EnergiaBaseZerg : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base pela terra");
        }
    }
}
