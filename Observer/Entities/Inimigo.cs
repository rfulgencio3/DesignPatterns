using Observer.Entities.Interfaces;
using System;

namespace Observer.Entities
{
    class Inimigo : IObservador
    {
        private Cody personagemObservado;
        public void Avisar(IPersonagem personagem)
        {
            if (personagem == personagemObservado)
            {
                Console.WriteLine("O Cody foi acertado com um golpe, agora sua vida de jogo é de : " + personagemObservado.getVida());
            }
        }
        public Inimigo(Cody cody)
        {
            personagemObservado = cody;
            personagemObservado.RegistrarObservador(this);
        }
    }
}
