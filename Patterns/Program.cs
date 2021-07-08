using Patterns.Contexts;
using System;
using System.Collections.Generic;

namespace Patterns
{
    class Program
    {
        private static IContext context;

        private static Dictionary<string, Func<IContext>> _contexts =
         new Dictionary<string, Func<IContext>>
         {
                { "strat", () => new StrategyContext() },
                { "obs", () => new ObserverContext() },
                { "decor", () => new DecoratorContext() },
                { "single", () => new SingletonContext() },
                { "proxy", () => new ProxyContext() },
                { "factor_m", () => new FactoryMethodContext() },
                { "factor_a", () => new AbstractFactoryContext() },
                { "command", () => new CommandContext() },
                { "adapter", () => new AdapterContext() },
                { "decor", () => new FacadeContext() },
                { "temp_m", () => new TemplateMethodContext() }
         };

        static void Main(string[] args)
        {
            Console.WriteLine(
 @"Список паттернов: 
- strat - стратегия
- obs - наблюдатель
- decor - декоратор
- single - одиночка
- proxy - заместитель
- factor_m - фабричный метод
- factor_a - абстрактная фабрика
- command - команда
- adapter - адаптер
- facade - фасад
- temp_m - шаблонный метод
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
            if (_contexts.TryGetValue(command, out Func<IContext> getRouteStrategyAction))
            {
                context.Excecute();
            }
            else
            {
                Console.WriteLine("Неизвестный паттерн");
            }

            WaitCommand();
        }
    }
}
