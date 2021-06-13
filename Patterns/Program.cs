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
");
            WaitCommand();
        }

        private static void WaitCommand()
        {
            Console.WriteLine("Введите паттерн");

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
                default:
                    Console.WriteLine("Неизвестный паттерн");
                    break;
            }

            context.Excecute();

            WaitCommand();
        }
    }
}
