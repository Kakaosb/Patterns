using Patterns.Contexts;
using Patterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns
{
    class Program
    {
        private static IContext _context;

        private static List<Pattern> _patterns =
         new List<Pattern>
         {
             new Pattern() { Discription = "стратегия", GetContextAction = () => new StrategyContext(), Key = "strat" },
             new Pattern() { Discription = "наблюдатель", GetContextAction = () => new ObserverContext(), Key = "obs" },
             new Pattern() { Discription = "декоратор", GetContextAction = () => new DecoratorContext(), Key = "decor" },
             new Pattern() { Discription = "одиночка", GetContextAction = () => new SingletonContext(), Key = "single" },
             new Pattern() { Discription = "заместитель", GetContextAction = () => new ProxyContext(), Key = "proxy" },
             new Pattern() { Discription = "фабричный метод", GetContextAction = () => new FactoryMethodContext(), Key = "factor_m" },
             new Pattern() { Discription = "абстрактная фабрика", GetContextAction = () => new AbstractFactoryContext(), Key = "factor_a" },
             new Pattern() { Discription = "команда", GetContextAction = () => new CommandContext(), Key = "command" },
             new Pattern() { Discription = "адаптер", GetContextAction = () => new AdapterContext(), Key = "adapter" },
             new Pattern() { Discription = "фасад",  GetContextAction = () => new FacadeContext(), Key = "facade" },
             new Pattern() { Discription = "шаблонный метод", GetContextAction = () => new TemplateMethodContext(),  Key = "temp_m" }
         };

        static void Main(string[] args)
        {

            var patternsList = string.Empty;

            _patterns.ForEach(el => {
                patternsList = $"{patternsList}- {el.Key} - {el.Discription}\n";
            });

            Console.WriteLine($"Список паттернов:\n{patternsList}");

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
            var pattern = _patterns.FirstOrDefault(p => p.Key == command);
            
            if (pattern != null)
            {
                _context = pattern.GetContextAction();
                _context.Excecute();
            }
            else
            {
                Console.WriteLine("Неизвестный паттерн");
            }

            WaitCommand();
        }
    }
}
