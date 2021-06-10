using Patterns.Behavior.Strategy;
using System;

namespace Patterns
{
    class Program
    {
        private static IRouteStrategy routeStrategy;

        static void Main(string[] args)
        {
            Console.WriteLine(
                @"What's upppp!
Введите команду: 
- br car - построение маршрута для личного авто
- br walk - построение маршрута для прогулки
- br public - построение маршрута для общественного транспорта
");
            WaitCommand();
        }

        private static void WaitCommand()
        {
            Console.WriteLine("Введите команду");

            var command = Console.ReadLine();
            ExcecuteCommand(command);
        }

        private static void ExcecuteCommand(string command)
        {
            switch (command)
            {
                case "br car":
                    routeStrategy = new CarStrategy();
                    routeStrategy.BuildRoute("Проклятый старый дом", "Дом лесника");
                    break;
                case "br walk":
                    routeStrategy = new WalkStrategy();
                    routeStrategy.BuildRoute("Гараж Васька", "Красота на кончиках пальцев");
                    break;
                case "br public":
                    routeStrategy = new PublicTransportStrategy();
                    routeStrategy.BuildRoute("Остановка №1", "Небеса обитованные");
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }

            WaitCommand();
        }
    }
}
