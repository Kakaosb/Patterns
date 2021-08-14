using Patterns.Impl.Behavior.Mediator;
using System;

namespace Patterns.Contexts
{
    public class MediatorContext : IContext
    {
        public void Excecute()
        {
            Egg egg = new Egg();
            Salt salt = new Salt();
            new ConcreteMediator(egg, salt);

            Console.WriteLine("Client triggets operation L_E.");
            egg.Location();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation S_F.");
            salt.DoSalt();

            Console.WriteLine();
        }
    }
}
