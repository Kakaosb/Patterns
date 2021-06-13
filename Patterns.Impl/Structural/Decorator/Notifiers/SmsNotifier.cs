using Patterns.Def.Structural.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Impl.Structural.Decorator
{
    public class SmsNotifier : Manager
    {
        public SmsNotifier(Notifier notifier) : base(notifier)
        {
        }

        public override void Send(Message message)
        {
            var sms = new SmsMessage(message);
            Console.WriteLine($"Отправили сообщение {sms.Body} на {sms.Phone}");

            base.Send(message);
        }
    }
}
