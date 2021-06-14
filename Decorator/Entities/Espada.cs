namespace Decorator.Entities
{
    public class Espada : DecoratorArmadura
    {
        string _descricao = "Espada ultra forte, ";
        MoldeArmadura _moldeArmadura;

        public Espada(MoldeArmadura moldeArmadura)
        {
            _moldeArmadura = moldeArmadura;
        }
        public override string Descricao
        {
            get { return _moldeArmadura.Descricao + _descricao; }
        }
    }
}
