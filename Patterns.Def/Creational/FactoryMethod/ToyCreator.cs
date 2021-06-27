using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Def.Behavior.FactoryMethod
{
    public abstract class ToyCreator
    {
        public abstract IProduct FactoryMethod();

        public void Paint()
        {
            var product = FactoryMethod();

            Console.WriteLine("Creator: замешали краску");

            product.Paint();
        }
    }
}
