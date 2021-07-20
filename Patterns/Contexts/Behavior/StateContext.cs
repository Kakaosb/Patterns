using Patterns.Impl.Behavior.State;
using System;

namespace Patterns.Contexts
{
    public class StateContext : IContext
    {
        public void Excecute()
        {
            var context = new Context(new ConcreteStateA());

            context.Request1();

            Console.WriteLine();

            context.Request2();

            Console.WriteLine();
        }
    }
}
