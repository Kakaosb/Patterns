using Patterns.Def.Behavior.Strategy;
using Patterns.Impl.Behavior.Strategy;
using System;

namespace Patterns.Contexts
{
    public class StrategyContext: IContext
    {
        private static IRouteStrategy _routeStrategy;

        public void Excecute() {
            Console.WriteLine(@"
Введите команду (без -): 
- br car - построение маршрута для личного авто
- br walk - построение маршрута для прогулки
- br public - построение маршрута для общественного транспорта
");

            var command = Console.ReadLine();

            switch (command)
            {
                case "br car":
                    _routeStrategy = new CarStrategy();
                    break;
                case "br walk":
                    _routeStrategy = new WalkStrategy();
                    break;
                case "br public":
                    _routeStrategy = new PublicTransportStrategy();
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }

            if (_routeStrategy != null)
                _routeStrategy.BuildRoute("Проклятый старый дом", "Дом лесника");
        }
    }
}
