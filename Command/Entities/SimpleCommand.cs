using Command.Entities.Interfaces;
using System;

namespace Command.Entities
{
    public class SimpleCommand : ICommand
    {
        private string _solicitacao = string.Empty;
        public SimpleCommand(string solicitacao)
        {
            this._solicitacao = solicitacao;
        }
        public void Execute()
        {
            Console.WriteLine("Estou executando um Simples Comando de " + this._solicitacao);
        }
    }
}
