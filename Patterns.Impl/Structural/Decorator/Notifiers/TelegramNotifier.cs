using Patterns.Def.Structural.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Impl.Structural.Decorator
{
    public class TelegramNotifier : Manager
    {
        public TelegramNotifier(Notifier notifier) : base(notifier)
        {
        }

        public override void Send(Message message)
        {
            var tel = new TelegramMessage(message);
            Console.WriteLine($"Отправили сообщение {tel.Body} на {tel.Login}");

            base.Send(message);
        }
    }
}
