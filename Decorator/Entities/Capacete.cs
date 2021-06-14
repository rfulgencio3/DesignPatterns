namespace Decorator.Entities
{
    public class Capacete : DecoratorArmadura
    {
        string _descricao = "Capacete, ";
        MoldeArmadura _moldeArmadura;

        public Capacete(MoldeArmadura moldeArmadura)
        {
            _moldeArmadura = moldeArmadura;
        }
        public override string Descricao
        {
            get { return _moldeArmadura.Descricao + _descricao; }
        }
    }
}
