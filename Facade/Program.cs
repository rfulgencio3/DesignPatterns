using Facade.Entities;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeMethod facade = new FacadeMethod();
            facade.OperacaoA();
            facade.OperacaoB();

            Console.ReadKey();
        }
    }
}
