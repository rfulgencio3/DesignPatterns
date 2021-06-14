using System;

namespace Template_Method.Entities
{
    public class ModoNormal : Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("O carro precisa abastecer uma vez");
        }
        public override void SegundaFase()
        {
            Console.WriteLine("Os carros devem correr na mesma velocidade");
        }
    }
}
