using Patterns.Contexts;
using System;

namespace Patterns
{
    class Program
    {
        private static IContext context;

        static void Main(string[] args)
        {
            Console.WriteLine(
                @"Список паттернов: 
- strat - стратегия
- obs - наблюдатель
- decor - декоратор
- single - одиночка
");
            WaitCommand();
        }

        private static void WaitCommand()
        {
            Console.WriteLine("Введите паттерн (без -)");

            var command = Console.ReadLine();
            ExcecuteCommand(command);
        }

        private static void ExcecuteCommand(string command)
        {
            switch (command)
            {
                case "strat":
                    context = new StrategyContext(); 
                    break;
                case "obs":
                    context = new ObserverContext();
                    break;
                case "decor":
                    context = new DecoratorContext();
                    break;
                case "single":
                    context = new SingletonContext();
                    break;
                default:
                    Console.WriteLine("Неизвестный паттерн");
                    break;
            }

            context.Excecute();

            WaitCommand();
        }
    }
}
