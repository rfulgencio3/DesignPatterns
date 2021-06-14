using System;
using System.Collections.Generic;
using Visitor.Entities;
using Visitor.Entities.Interfaces;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IJogo> jogo = new List<IJogo>();
            jogo.Add(new FaseJogo()
            {
                NomeFase = "Floresta"
            });
            jogo.Add(new Chefao()
            {
                Nome = "Boss 1",
                PontosVida = 30
            });

            jogo.Add(new FaseJogo()
            {
                NomeFase = "Caverna"
            });
            jogo.Add(new Chefao()
            {
                Nome = "Boss 2",
                PontosVida = 50
            });
            
            NivelVisitor nivelVisitor = new NivelVisitor();
            foreach(var etapa in jogo)
            {
                etapa.Visitante(nivelVisitor);
            }
            
            Console.ReadLine();
        }
    }
}
