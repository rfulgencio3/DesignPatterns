namespace Decorator.Entities
{
    public class ArmaduraPadrao : MoldeArmadura
    {
        string _descricao = "Proteção simples, ";
        public override string Descricao
        {
            get { return _descricao; }
        }
    }
}
