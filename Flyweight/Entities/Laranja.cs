using System;

namespace Flyweight.Entities
{
    public class Laranja : Tartaruga
    {
        public Laranja()
        {
            this.Condicao = "Tartaruga dentro do casco, ";
            this.Acao = "rodando no chão - ";
        }
        public override void Mostra(string cor)
        {
            this.Cor = cor;
            Console.WriteLine(Condicao + Acao + cor.ToUpper());
        }
    }
}