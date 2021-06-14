using System;

namespace Template_Method.Entities
{
    public class ModoDificil : Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("Adicionar obstaculos na pista");
        }
        public override void SegundaFase()
        {
            Console.WriteLine("Os carros devem correr mais");
        }
    }
}
