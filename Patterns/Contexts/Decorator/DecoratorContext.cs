using Patterns.Impl.Structural.Decorator;
using System;

namespace Patterns.Contexts
{
    public class DecoratorContext : IContext
    {
        public void Excecute()
        {
            Client client = new Client();

            SimpleNotifier simpleNotifier = new SimpleNotifier();

            Console.WriteLine();
            Console.WriteLine("Без обертки:");
            client.SendReportToDeveloper(simpleNotifier);

            Console.WriteLine();
            Console.WriteLine("Обертка в email и sms:");
            Console.WriteLine();

            EmailNotifier emailNotifier = new EmailNotifier(simpleNotifier);
            SmsNotifier smsNotifier = new SmsNotifier(emailNotifier);
            client.SendReportToDeveloper(smsNotifier);

            Console.WriteLine();
            Console.WriteLine("Обертка в email, sms и телеграм:");
            Console.WriteLine();

            TelegramNotifier telegram = new TelegramNotifier(smsNotifier);
            client.SendReportToDeveloper(telegram);

            Console.WriteLine();
        }
    }
}
