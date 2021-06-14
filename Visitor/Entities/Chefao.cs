using Visitor.Entities.Interfaces;

namespace Visitor.Entities
{
    public class Chefao : IJogo
    {
        public string Nome { get; set; }
        public int PontosVida { get; set; }
        public void Visitante(IVisitor visitor)
        {
            visitor.Identificar(this);
        }
    }
}
