using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Entities
{
    public class Exercito
    {
        public void ConstruirSoldado(CriadorDeSoldado criadorDeSoldado)
        {
            criadorDeSoldado.Arma();
            criadorDeSoldado.Transporte();
            criadorDeSoldado.Foco();
        }
    }
}
