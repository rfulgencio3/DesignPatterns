using Observer.Entities.Interfaces;
using System.Collections.Generic;

namespace Observer.Entities
{
    public class Cody : IPersonagem
    {
        private List<IObservador> inimigos = new List<IObservador>();
        public int vida = 100;
        public void NotificarPersonagens()
        {
            foreach (IObservador i in inimigos)
            {
                i.Avisar(this);
            }
        }

        public void RegistrarObservador(IObservador observador)
        {
            inimigos.Add(observador);
        }
        public void GolpeAcertado(bool golpe)
        {
            if (golpe)
                vida -= 10;
            NotificarPersonagens();
        }

        public int getVida()
        {
            return vida;
        }
    }
}
