﻿using Interpreter.Entities.Interfaces;

namespace Interpreter.Entities
{
    public class Bussola : IFerramenta
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += string.Format(" {0}", " Bússola ");
        }
    }
}