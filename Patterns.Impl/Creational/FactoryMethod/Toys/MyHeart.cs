using Patterns.Def.Behavior.FactoryMethod;
using System;

namespace Patterns.Impl.Creational.FactoryMethod
{
    public class MyHeart : IProduct
    {
        public void Paint()
        {
            Console.WriteLine("А точно можно красить?");
        }
    }
}
