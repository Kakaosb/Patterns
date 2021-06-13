using Patterns.Impl.Behavior.Observer;
using System;
using System.Collections.Generic;

namespace Patterns.Contexts
{
    public class ObserverContext : IContext
    {
        private List<Listener> _listeners { get; set; } = new List<Listener>() {
                 new Listener("Я рад, что", 1),
                 new Listener("Вы представляете,", 2),
                 new Listener("Мне кто-то сказал, что", 3),
                 new Listener("А правда ли, что", 4)
            };

        private Speaker _speaker { get; set; } = new Speaker();

        public void Excecute()
        {
            Excecute(true);
        }

        private void Excecute(bool isFirst)
        {
            if (isFirst)
            {
                _listeners.ForEach(el => _speaker.Subscribe(el));
            }

            Console.WriteLine(@"Введите новое состояние издателя типа int или любую букву для возвращения в главное меню");

            var command = Console.ReadLine();

            if (int.TryParse(command, out int commandInt))
            {
                _speaker.ChangeState(commandInt);
                Excecute(false);
            }
            else
            {
                _listeners.ForEach(el => _speaker.Unsubscribe(el));
            }
        }
    }
}
