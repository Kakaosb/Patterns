using Patterns.Def.Structural.Proxy;
using System;

namespace Patterns.Impl.Structural.Proxy
{
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("Реальный субъект выполняет запрос");
        }
    }
}
