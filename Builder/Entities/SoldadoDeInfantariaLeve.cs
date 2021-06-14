using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Entities
{
    public class SoldadoDeInfantariaLeve : Soldado
    {
        public override void EscolherArma(string arma)
        {
            Arma = arma;
        }
        public override void EscolherTransporte(string transporte)
        {
            Transporte = transporte;
        }
        public override void DefinirFoco(string foco)
        {
            Foco = foco;
        }

    }
}
