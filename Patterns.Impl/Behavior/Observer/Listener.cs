using Patterns.Def.Behavior.Observer;
using System;

namespace Patterns.Impl.Behavior.Observer
{
    public class Listener : IListener
    {
        private string _character { get; set; }
        private int _number { get; set; }

        public int Number
        {
            get { return _number; } 
        }

        public void Update(ISpeaker speaker)
        {
            var state = (speaker as Speaker).State;

            Console.WriteLine($"Слушатель {_number}. {_character} состояние издателя = {state}");
        }

        public Listener(string character, int number) {
            _character = character;
            _number = number;
        }
    }
}
