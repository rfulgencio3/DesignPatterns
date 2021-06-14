using Interpreter.Entities.Interfaces;

namespace Interpreter.Entities
{
    public class ArcoFlecha : IArmamento
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += string.Format(" {0}", " Arco e Flecha ");
        }
    }
}