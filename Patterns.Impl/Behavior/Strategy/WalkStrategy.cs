using Patterns.Def.Behavior.Strategy;
using System;

namespace Patterns.Impl.Behavior.Strategy
{
    public class WalkStrategy : IRouteStrategy
    {
        public void BuildRoute(string from, string to)
        {
            Console.WriteLine($"Построили путь для прогулки от {from} до {to}");
        }
    }
}
