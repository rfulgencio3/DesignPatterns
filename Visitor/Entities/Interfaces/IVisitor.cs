namespace Visitor.Entities.Interfaces
{
    public interface IVisitor
    {
        void Identificar(Chefao chefao);
        void Identificar(FaseJogo faseJogo);
    }
}
