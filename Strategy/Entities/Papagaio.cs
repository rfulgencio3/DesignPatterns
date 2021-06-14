using Strategy.Entities.Interfaces;

namespace Strategy.Entities
{
    public class Papagaio : IAjuda
    {
        public string Ajudar(Ajuda ajudaPedido)
        {
            return "Sou um papagaio e posso ajudar você a voar";
        }
    }
}
