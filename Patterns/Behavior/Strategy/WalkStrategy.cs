using System;

namespace Patterns.Behavior.Strategy
{
    public class WalkStrategy : IRouteStrategy
    {
        public void BuildRoute(string from, string to)
        {
            Console.WriteLine($"Построили путь для прогулки от {from} до {to}");
        }
    }
}
