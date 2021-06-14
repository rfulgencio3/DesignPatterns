namespace Decorator.Entities
{
    public class DecoratorArmadura : MoldeArmadura
    {
        string _descricao = "Decorator abstrato da armadura do personagem";
        public override string Descricao
        {
            get { return _descricao; }
        }
    }
}
