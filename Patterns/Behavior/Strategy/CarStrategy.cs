using System;

namespace Patterns.Behavior.Strategy
{
    public class CarStrategy : IRouteStrategy
    {
        public void BuildRoute(string from, string to)
        {
            Console.WriteLine($"Построили путь для личного авто от {from} до {to}");
        }
    }
}
