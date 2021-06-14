using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Entities
{
    public class CriadorForcasEspeciais : CriadorDeSoldado
    {
        public CriadorForcasEspeciais()
        {
            _soldado = new SoldadoDeInfantariaLeve();
        }
        public override void Arma()
        {
            _soldado.EscolherArma("Fuzil");
        }
        public override void Transporte()
        {
            _soldado.EscolherTransporte("Carro operações especiais");
        }
        public override void Foco()
        {
            _soldado.DefinirFoco("combate em solo");
        }
    }
}
