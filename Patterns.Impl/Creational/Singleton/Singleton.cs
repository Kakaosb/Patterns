using System;

namespace Patterns.Impl.Creational.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        //for lock first call
        private static readonly object _lock = new object();

        //for check the lock
        public string Parent { get; set; }

        private Singleton() { }

        public void Query(string name)
        {
            Console.WriteLine($"Привет, я объект {name}! Выполни для меня запрос");
        }

        public static Singleton GetInstance(string who) {
            if (_instance == null) {
                lock (_lock)
                {
                    _instance = new Singleton();
                    _instance.Parent = who;
                }
            }

            return _instance;
        }
    }
}
