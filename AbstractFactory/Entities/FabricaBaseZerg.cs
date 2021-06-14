using AbstractFactory.Entities.Interfaces;
using System;

namespace AbstractFactory.Entities
{
    public class FabricaBaseZerg : IFabricaBases
    {
        public FabricaBaseZerg()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Zerg criada com sucesso!");

            RevestimentoBaseZerg revestimento = new RevestimentoBaseZerg();
            revestimento.Composicao();

            EnergiaBaseZerg energia = new EnergiaBaseZerg();
            energia.Composicao();
        }
    }
}
