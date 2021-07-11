using Patterns.Impl.Behavior.Iterator;
using System;

namespace Patterns.Contexts
{
    public class IteratorContext : IContext
    {
        public void Excecute()
        {
            // Клиентский код может знать или не знать о Конкретном Итераторе
            // или классах Коллекций, в зависимости от уровня косвенности,
            // который вы хотите сохранить в своей программе.
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Прямой обход:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nОбратный обход:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
        }
    }
}