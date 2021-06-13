using Patterns.Def.Structural.Decorator;
using System;

namespace Patterns.Impl.Structural.Decorator
{
    public class SimpleNotifier : Notifier
    {
        public override void Send(Message message)
        {
            Console.WriteLine($"Пришло сообщение: {message.Body}");
        }
    }
}
