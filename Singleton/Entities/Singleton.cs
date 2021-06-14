﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instancia = null;
        public static Singleton GetInstancia { get
            {
                if (instancia == null)
                {
                    instancia = new Singleton();
                    Console.WriteLine("Bola em Jogo");
                }
                return instancia;
            } 
        }

        public void Mensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
