using Patterns.Def.Behavior.FactoryMethod;
using Patterns.Impl.Creational.FactoryMethod;
using System;

namespace Patterns.Contexts
{
    public class FactoryMethodContext : IContext
    {
        public void Excecute()
        {
            Console.WriteLine("App: У нас есть дилдо");
            ClientCode(new DildoCreator());

            Console.WriteLine();

            Console.WriteLine("App: У нас есть тетрис");
            ClientCode(new TetrisCreator());

            Console.WriteLine();

            Console.WriteLine("App: <3");
            ClientCode(new MyHeartCreator());

            Console.WriteLine();
        }

        private void ClientCode(ToyCreator creator)
        {
            Console.WriteLine("Client: а можно в другом цвете?");

            creator.Paint();
        }
    }
}
