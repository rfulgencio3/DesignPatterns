using Proxy.Entities;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Acessando a fase do jogo sem o Proxy ####");
            FaseJogo faseJogo = new FaseJogo();
            Console.WriteLine(faseJogo.Jogar());
            Console.WriteLine();

            Console.WriteLine("#### Usando o Proxy para controlar o acesso a fase do jogo ####");
            Console.WriteLine();
            ProxyFase proxyFase = new ProxyFase();
            Console.WriteLine(proxyFase.Jogar());
            
            Console.ReadKey();
        }
    }
}
