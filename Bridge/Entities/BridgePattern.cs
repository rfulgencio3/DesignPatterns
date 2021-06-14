using Bridge.Entities.Interfaces;
using System;

namespace Bridge.Entities
{
    public class BridgePattern
    {
        public IForma formaSolicitada { get; set; }
        public void ExibeQualformaEstaDescendoNaTela()
        {
            Console.WriteLine(formaSolicitada.Descer());
        }
    }
}
