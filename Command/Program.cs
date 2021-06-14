using Command.Entities;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Control control = new Control();
            control.SendSimpleCommand(new SimpleCommand("Dizer Oi!"));

            Receiver receiver = new Receiver();
            control.SendComplexCommand(new ComplexCommand(receiver, "Abastecer o carro", "Calibrar os pneus do carro"));

            control.Do();
            Console.ReadKey();
        }
    }
}
