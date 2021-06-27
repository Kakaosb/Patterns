using Patterns.Def.Creational;
using System;

namespace Patterns.Impl.Creational.AbstractFactory
{
    class WhiteSofa : IAbstractSofa
    {
        public void BeSoft()
        {
            Console.WriteLine("Белая софа как облачко");
        }

        public void Stay()
        {
            Console.WriteLine("Белая софа стоит");
        }
    }
}
