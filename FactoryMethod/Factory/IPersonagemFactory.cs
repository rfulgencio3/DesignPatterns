using FactoryMethod.Entities.Personagens;

namespace FactoryMethod
{
    public class IPersonagemFactory
    {
        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem)
            {
                case "1": return new LiuKang();
                case "2": return new SubZero();
                case "3": return new Scorpion();
                default: return null;
            }
        }
    }
}
