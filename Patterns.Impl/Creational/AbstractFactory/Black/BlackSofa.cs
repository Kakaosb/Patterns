using Patterns.Def.Creational;
using System;

namespace Patterns.Impl.Creational.AbstractFactory
{
    public class BlackSofa : IAbstractSofa
    {
        public void BeSoft()
        {
            Console.WriteLine("Черная софа мягкая");
        }

        public void Stay()
        {
            Console.WriteLine("Черная софа стоит");
        }
    }
}
