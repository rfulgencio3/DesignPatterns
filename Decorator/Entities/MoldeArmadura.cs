namespace Decorator.Entities
{
    public abstract class MoldeArmadura
    {
        private string _descricao = "Armadura do Personagem abstrata";
        public virtual string Descricao
        {
            get { return _descricao; }
        }
    }
}
