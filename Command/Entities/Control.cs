using Command.Entities.Interfaces;
using System;

namespace Command.Entities
{
    public class Control
    {
        private ICommand simpleCommand;
        private ICommand complexCommand;

        public void SendSimpleCommand(ICommand command)
        {
            this.simpleCommand = command;
        }
        public void SendComplexCommand(ICommand command)
        {
            this.complexCommand = command;
        }

        public void Do()
        {
            Console.WriteLine("Ok, vou executar para você!");
            if (this.simpleCommand is ICommand)
                this.simpleCommand.Execute();

            if (this.complexCommand is ICommand)
                this.complexCommand.Execute();
        }
    }
}
