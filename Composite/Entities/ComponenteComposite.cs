using System;
using System.Collections.Generic;

namespace Composite.Entities
{
    public class ComponenteComposite : ComponenteFase
    {
        private List<ComponenteFase> fasesJogo = new List<ComponenteFase>();
        public ComponenteComposite(string nome) : base(nome) { }
        public override void Adicionar(ComponenteFase componenteFase)
        {
            this.fasesJogo.Add(componenteFase);
        }
        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + Nome);
            foreach (ComponenteFase item in this.fasesJogo)
            {
                item.Mostrar(profundidade + 2);
            }
        }
        public override void Remover(ComponenteFase componenteFase)
        {
            this.fasesJogo.Remove(componenteFase);
        }
    }
}

