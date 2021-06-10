using Patterns.Def.Behavior.Strategy;
using Patterns.Impl.Behavior.Strategy;
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
                    break;
                case "br walk":
                    routeStrategy = new WalkStrategy();
                    break;
                case "br public":
                    routeStrategy = new PublicTransportStrategy();
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }

            if(routeStrategy != null)   
                routeStrategy.BuildRoute("Проклятый старый дом", "Дом лесника");

            WaitCommand();
        }
    }
}
