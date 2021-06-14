using Strategy.Entities.Interfaces;

namespace Strategy.Entities
{
    public class Ajuda
    {
        private IAjuda _ajuda;
        public Ajuda(IAjuda ajuda)
        {
            _ajuda = ajuda;
        }

        public string Ajudar()
        {
            return _ajuda.Ajudar(this);
        }
    }
}