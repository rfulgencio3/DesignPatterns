﻿using System;
using Visitor.Entities.Interfaces;

namespace Visitor.Entities
{
    public class NivelVisitor : IVisitor
    {
        public void Identificar(FaseJogo fase)
        {
            switch (fase.NomeFase)
            {
                case "Floresta":
                    Console.WriteLine("A fase {0} no jogo é {1}% difícil.", fase.NomeFase, 70);
                    break;
                case "Caverna":
                    Console.WriteLine("A fase {0} no jogo é {1}% difícil.", fase.NomeFase, 30);
                    break;
            }
        }
        public void Identificar(Chefao chefao)
        {
            switch (chefao.Nome)
            {
                case "Boss 1":
                    Console.WriteLine("O chefão {0} é {1}% difícil e tem {2} pontos de vida.", chefao.Nome, 25, chefao.PontosVida);
                    break;
                case "Boss 2":
                    Console.WriteLine("O chefão {0} é {1}% difícil e tem {2} pontos de vida.", chefao.Nome, 50, chefao.PontosVida);
                    break;
            }
        }
    }
}
