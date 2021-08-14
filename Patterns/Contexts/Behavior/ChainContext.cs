using Patterns.Impl.Behavior.Chain;
using System;

namespace Patterns.Contexts
{
    public class ChainContext : IContext
    {
        public void Excecute()
        {
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            Client.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            Client.ClientCode(squirrel);

            Console.WriteLine();
        }
    }
}
