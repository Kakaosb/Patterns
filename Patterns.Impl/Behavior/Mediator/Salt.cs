using System;

namespace Patterns.Impl.Behavior.Mediator
{
    public class Salt : SomeFood
    {
        public void Location()
        {
            Console.WriteLine("Some salt in the cupboard");

            this._mediator.Notify(this, "S_L");
        }

        public void DoSalt()
        {
            Console.WriteLine("Salt food");

            this._mediator.Notify(this, "S_F");
        }
    }
}
