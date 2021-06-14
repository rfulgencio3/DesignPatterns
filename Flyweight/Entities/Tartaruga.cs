namespace Flyweight.Entities
{
    public abstract class Tartaruga
    {
        protected string Condicao;
        protected string Acao;
        public string Cor { get; set; }

        public abstract void Mostra(string cor);
    }
}
