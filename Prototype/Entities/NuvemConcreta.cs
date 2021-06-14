using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Entities
{
    public class NuvemConcreta : NuvemMolde
    {
        private string corPreenchimento;
        private string corContorno;

        public NuvemConcreta(string preenchimento, string contorno)
        {
            this.corPreenchimento = preenchimento;
            this.corContorno = contorno;
        }
        public override NuvemMolde Clone()
        {
            Console.WriteLine("A nuvem clonada tem contorno {0} e preenchimento {1}", this.corContorno, this.corPreenchimento);
            return this.MemberwiseClone() as NuvemMolde;
        }
    }
}
