using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Entities
{
    public class CriadorDeInfantariaLeve : CriadorDeSoldado
    {
        public CriadorDeInfantariaLeve()
        {
            _soldado = new SoldadoDeInfantariaLeve();
        }
        public override void Arma()
        {
            _soldado.EscolherArma("Ataque Aéreo");
        }
        public override void Transporte()
        {
            _soldado.EscolherTransporte("Helicóptero de ataque do Exército");
        }
        public override void Foco()
        {
            _soldado.DefinirFoco("resposta rápida aérea");
        }
    }
}
