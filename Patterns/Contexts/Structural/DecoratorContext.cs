using Patterns.Def.Structural.Decorator;
using Patterns.Impl.Structural.Decorator;
using System;

namespace Patterns.Contexts
{
    public class DecoratorContext : IContext
    {
        public void Excecute()
        {
            Client client = new Client();

            Notifier notifier = new SimpleNotifier();

            Console.WriteLine();
            Console.WriteLine("Без обертки:");
            client.SendReportToDeveloper(notifier);

            Console.WriteLine();
            Console.WriteLine("Обертка в email и sms:");
            Console.WriteLine();

            notifier = new EmailNotifier(notifier);
            notifier = new SmsNotifier(notifier);
            client.SendReportToDeveloper(notifier);

            Console.WriteLine();
            Console.WriteLine("Обертка в email, sms и телеграм:");
            Console.WriteLine();

            notifier = new TelegramNotifier(notifier);
            client.SendReportToDeveloper(notifier);

            Console.WriteLine();
        }
    }
}
