using Patterns.Def.Behavior.Strategy;
using System;

namespace Patterns.Impl.Behavior.Strategy
{
    public class PublicTransportStrategy : IRouteStrategy
    {
        public void BuildRoute(string from, string to)
        {
            Console.WriteLine($"Построили путь для перемещения на общественном транспорте от {from} до {to}");
        }
    }
}
