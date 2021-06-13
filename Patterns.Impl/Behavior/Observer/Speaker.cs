using Patterns.Def.Behavior.Observer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Impl.Behavior.Observer
{
    public class Speaker : ISpeaker
    {
        private List<IListener> _listeners { get; set; } = new List<IListener>();

        private int _state { get; set; } = 0;
        
        public int State { get { return _state; } }

        public void ChangeState(int newState)
        {
            _state = newState;

            Notify();
        }

        public void Notify()
        {
            foreach (var listener in _listeners) {
                listener.Update(this);
            }
        }

        public void Subscribe(IListener listener)
        {
            _listeners.Add(listener);
            var number = (listener as Listener).Number;

            Console.WriteLine($"Издатель: Подписан слушатель {number}.");
        }

        public void Unsubscribe(IListener listener)
        {
            if (_listeners.Any(el => el == listener))
            {
                var number = (listener as Listener).Number;
                _listeners.Remove(listener);
                Console.WriteLine($"Издатель: Отписан слушатель {number}.");
            }
        }
    }
}
