using System;

namespace Flyweight.Entities
{
    public class Vermelha : Tartaruga
    {
        public Vermelha()
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
