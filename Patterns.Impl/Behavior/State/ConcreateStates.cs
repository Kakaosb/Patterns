using System;

namespace Patterns.Impl.Behavior.State
{
    public class ConcreteStateA : State
    {
        public override void Action1()
        {
            Console.WriteLine("ConcreteStateA выполняет действие 1.");

            this._context.TransitionTo(new ConcreteStateB());

            Console.WriteLine("ConcreteStateA установил StateB.");
        }

        public override void Action2()
        {
            Console.WriteLine("ConcreteStateA выполняет действие 2.");
        }
    }

    public class ConcreteStateB : State
    {
        public override void Action1()
        {
            Console.Write("ConcreteStateB выполняет действие 1.");
        }

        public override void Action2()
        {
            Console.WriteLine("ConcreteStateB выполняет действие 2.");

            this._context.TransitionTo(new ConcreteStateA());

            Console.WriteLine("ConcreteStateB установил StateA.");
        }
    }
}
