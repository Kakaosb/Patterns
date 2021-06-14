using Patterns.Impl.Creational.Singleton;
using System;
using System.Threading;

namespace Patterns.Contexts
{
    public class SingletonContext : IContext
    {
        public void Excecute()
        {
            Thread process1 = new Thread(() =>
            {
                TestSingleton("Никита Первый");
            });

            Thread process2 = new Thread(() =>
            {
                TestSingleton("Варвара Вторая");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        private static void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetInstance(value);
            Console.WriteLine($"Родителем является {singleton.Parent}");
            singleton.Query(value);
            Console.WriteLine();
        }
    }
}
