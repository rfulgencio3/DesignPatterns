using Interpreter.Entities.Interfaces;
using System;

namespace Interpreter.Entities
{
    public class Mochila : IExpressao
    {
        private readonly IFerramenta ferramentaPrincipal;
        private readonly IFerramenta ferramentaSecundaria;
        private readonly IArmamento armamento;

        public Mochila(IFerramenta ferramentaPrincipal, IFerramenta ferramentaSecundaria, IArmamento armamento)
        {
            this.ferramentaPrincipal = ferramentaPrincipal;
            this.ferramentaSecundaria = ferramentaSecundaria;
            this.armamento = armamento;
        }

        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += "Abrindo mochila...\n";
            armamento.Interpretar(contexto);
            
            contexto.Conteudo += "- 1ª Ferramenta";
            ferramentaPrincipal.Interpretar(contexto);

            contexto.Conteudo += "- 2ª Ferramenta";
            ferramentaSecundaria.Interpretar(contexto);

            contexto.Conteudo += "\n... Fechando mochila";

            Console.WriteLine(contexto.Conteudo);
        }
    }
}