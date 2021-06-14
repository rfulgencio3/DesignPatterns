using Adapter.Interfaces;

namespace Adapter.Entities
{
    public class Adaptador : IAcao
    {
        Aviao aviao;
        public Adaptador(Aviao novoAviao)
        {
            this.aviao = novoAviao;
        }
        public void Andar(string jogador)
        {
            this.aviao.Voar("Ricardo");
        }
        public void Atirar()
        {
            this.aviao.SoltarMissil();
        }
    }
}
