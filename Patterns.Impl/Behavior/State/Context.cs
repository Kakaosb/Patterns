using System;

namespace Patterns.Impl.Behavior.State
{
    public class Context
    {
        private State _state = null;

        public Context(State state)
        {
            this.TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Меняем состояние на {state.GetType().Name}.");

            this._state = state;
            this._state.SetContext(this);
        }

        public void Request1()
        {
            this._state.Action1();
        }

        public void Request2()
        {
            this._state.Action2();
        }
    }
}
