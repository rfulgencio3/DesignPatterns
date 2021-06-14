namespace Composite.Entities
{
    public abstract class ComponenteFase
    {
        protected string Nome;
        public ComponenteFase(string nome)
        {
            this.Nome = nome;
        }
        public abstract void Adicionar(ComponenteFase componenteFase);
        public abstract void Remover(ComponenteFase componenteFase);
        public abstract void Mostrar(int profundidade);
    }
}
