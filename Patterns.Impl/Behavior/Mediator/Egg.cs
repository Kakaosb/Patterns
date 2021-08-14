using System;

namespace Patterns.Impl.Behavior.Mediator
{
    public class Egg : SomeFood
    {
        public void Location()
        {
            Console.WriteLine("The Egg in a cold box");

            this._mediator.Notify(this, "E_L");
        }

        public void Coocking()
        {
            Console.WriteLine("The egg is fried");

            this._mediator.Notify(this, "E_C");
        }
    }
}
