using Patterns.Def.Behavior.Strategy;
using Patterns.Impl.Behavior.Strategy;
using System;
using System.Collections.Generic;

namespace Patterns.Contexts
{
    public class StrategyContext: IContext
    {
        private static IRouteStrategy _routeStrategy;

        private static Dictionary<string, Func<IRouteStrategy>> _strategies =
            new Dictionary<string, Func<IRouteStrategy>>
            {
                { "br car", () => new CarStrategy() },
                { "br walk", () => new WalkStrategy() },
                { "br public", () => new PublicTransportStrategy() }

            };

        public void Excecute() {
            Console.WriteLine(@"
Введите команду (без -): 
- br car - построение маршрута для личного авто
- br walk - построение маршрута для прогулки
- br public - построение маршрута для общественного транспорта
");

            var command = Console.ReadLine();

            if (_strategies.TryGetValue(command, out Func<IRouteStrategy> getRouteStrategyAction))
            {
                _routeStrategy = getRouteStrategyAction();
                _routeStrategy.BuildRoute("Проклятый старый дом", "Дом лесника");
            }
            else {
                Console.WriteLine("Неизвестная команда");
            }

            Console.WriteLine();
        }
    }
}
