using System;

namespace Patterns.Behavior.Strategy
{
    public class PublicTransportStrategy : IRouteStrategy
    {
        public void BuildRoute(string from, string to)
        {
            Console.WriteLine($"Построили путь для перемещения на общественном транспорте от {from} до {to}");
        }
    }
}
