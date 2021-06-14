using AbstractFactory.Entities.Interfaces;
using System;

namespace AbstractFactory.Entities
{
    public class RevestimentoBaseTerran : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor verde");
        }
    }
}
