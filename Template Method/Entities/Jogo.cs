using System;

namespace Template_Method.Entities
{
    public abstract class Jogo
    {
        public abstract void PrimeiraFase();
        public abstract void SegundaFase();
        private void TrilhaSonora()
        {
            Console.WriteLine("Música Emocionante");
        }
        public Jogo()
        {
            TrilhaSonora();
            PrimeiraFase();
            SegundaFase();
        }
    }
}
