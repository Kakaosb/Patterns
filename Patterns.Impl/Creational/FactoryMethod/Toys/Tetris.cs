using Patterns.Def.Behavior.FactoryMethod;
using System;

namespace Patterns.Impl.Creational.FactoryMethod
{
    public class Tetris : IProduct
    {
        public void Paint()
        {
            Console.WriteLine("Обмакнули в ведро");
        }
    }
}
