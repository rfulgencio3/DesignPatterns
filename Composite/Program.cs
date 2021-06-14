using Composite.Entities;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            ComponenteComposite mapa = new ComponenteComposite("MAPA DAS CAVERNAS");
            
            ComponenteComposite cavernaUm = new ComponenteComposite("Caverna Um");
            cavernaUm.Adicionar(new FaseJogo("Sub-Fase Um"));
            cavernaUm.Adicionar(new FaseJogo("Sub-Fase Dois"));
            cavernaUm.Adicionar(new FaseJogo("Sub-Fase Três"));

            ComponenteComposite cavernaDois = new ComponenteComposite("Caverna Dois");
            cavernaDois.Adicionar(new FaseJogo("Sub-Fase Um"));
            cavernaDois.Adicionar(new FaseJogo("Sub-Fase Dois"));
            cavernaDois.Adicionar(new FaseJogo("Sub-Fase Três"));

            ComponenteComposite portaSecreta = new ComponenteComposite("Porta Secreta");
            portaSecreta.Adicionar(new FaseJogo("Sub-Fase Secreta X"));

            mapa.Adicionar(cavernaUm);
            mapa.Adicionar(cavernaDois);
            mapa.Adicionar(portaSecreta);

            mapa.Mostrar(1);

            Console.ReadKey();
        }
    }
}
