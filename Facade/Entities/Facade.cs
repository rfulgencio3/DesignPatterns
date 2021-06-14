using System;

namespace Facade.Entities
{
    public class FacadeMethod
    {
        private SubSistemaUm subSistemaUm;
        private SubSistemaDois subSistemaDois;
        private SubSistemaTres subSistemaTres;

        public FacadeMethod()
        {
            this.subSistemaUm = new SubSistemaUm();
            this.subSistemaDois = new SubSistemaDois();
            this.subSistemaTres = new SubSistemaTres();
        }
        public void OperacaoA()
        {
            Console.WriteLine("\nOperacao A -------");
            this.subSistemaUm.Responsabilidade();
            this.subSistemaDois.Responsabilidade();
        }
        public void OperacaoB()
        {
            Console.WriteLine("\nOperacao B -------");
            this.subSistemaTres.Responsabilidade();
        }
    }
}
