using Patterns.Def.Structural.Decorator;
using System;

namespace Patterns.Impl.Structural.Decorator
{
    public class EmailNotifier : Manager
    {
        public EmailNotifier(Notifier notifier) : base(notifier)
        {
        }

        public override void Send(Message message)
        {
            var email = new EmailMessage(message);
            Console.WriteLine($"Отправили сообщение {email.Body} на {email.Address}");

            base.Send(message);
        }
    }
}
