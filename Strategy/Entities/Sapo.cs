using Strategy.Entities.Interfaces;

namespace Strategy.Entities
{
    public class Sapo : IAjuda
    {
        public string Ajudar(Ajuda ajudaPedido)
        {
            return "Sou um sapo e posso ajudar você a pular bem alto!";
        }
    }
}
