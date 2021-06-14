using Visitor.Entities.Interfaces;

namespace Visitor.Entities
{
    public class FaseJogo : IJogo
    {
        public string NomeFase { get; set; }
        public void Visitante(IVisitor visitor)
        {
            visitor.Identificar(this);
        }
    }
}
