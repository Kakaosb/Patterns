using Patterns.Def.Behavior.FactoryMethod;
using System;

namespace Patterns.Impl.Creational.FactoryMethod
{
    public class Dildo : IProduct
    {
        public void Paint()
        {
            Console.WriteLine("Нежно покрасили вдоль");
        }
    }
}
