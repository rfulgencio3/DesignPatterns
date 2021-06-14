using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton jogadorUm = Singleton.GetInstancia;
            jogadorUm.Mensagem("Jogador Um: A bola está comigo no meio do campo.");
            
            Singleton jogadorDois = Singleton.GetInstancia;
            jogadorDois.Mensagem("Jogador Dois: recebeu a bola.");
            
            Singleton jogadorTres = Singleton.GetInstancia;
            jogadorTres.Mensagem("Jogador Tres: recebeu o lançamento.");

            Console.ReadKey();
        }
    }
}
