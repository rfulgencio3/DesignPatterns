using System;

namespace Composite.Entities
{
    public class FaseJogo : ComponenteFase
    {
        public FaseJogo(string nome) : base(nome) { }
        public override void Adicionar(ComponenteFase componenteFase)
        {
            Console.WriteLine("Não é possível adicionar a fase no jogo por aqui!");
        }
        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + Nome);
        }
        public override void Remover(ComponenteFase componenteFase)
        {
            Console.WriteLine("Não é possível remover a fase do jogo por aqui!");
        }
    }
}
