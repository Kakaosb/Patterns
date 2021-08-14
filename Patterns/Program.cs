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
             new Pattern() { Discription = "Стратегия", GetContextAction = () => new StrategyContext(), Key = "strat" },
             new Pattern() { Discription = "Наблюдатель", GetContextAction = () => new ObserverContext(), Key = "obs" },
             new Pattern() { Discription = "Декоратор", GetContextAction = () => new DecoratorContext(), Key = "decor" },
             new Pattern() { Discription = "Одиночка", GetContextAction = () => new SingletonContext(), Key = "single" },
             new Pattern() { Discription = "Заместитель", GetContextAction = () => new ProxyContext(), Key = "proxy" },
             new Pattern() { Discription = "Фабричный метод", GetContextAction = () => new FactoryMethodContext(), Key = "factor_m" },
             new Pattern() { Discription = "Абстрактная фабрика", GetContextAction = () => new AbstractFactoryContext(), Key = "factor_a" },
             new Pattern() { Discription = "Команда", GetContextAction = () => new CommandContext(), Key = "command" },
             new Pattern() { Discription = "Адаптер", GetContextAction = () => new AdapterContext(), Key = "adapter" },
             new Pattern() { Discription = "Фасад",  GetContextAction = () => new FacadeContext(), Key = "facade" },
             new Pattern() { Discription = "Шаблонный метод", GetContextAction = () => new TemplateMethodContext(),  Key = "temp_m" },
             new Pattern() { Discription = "Итератор", GetContextAction = () => new IteratorContext(),  Key = "iterator" },
             new Pattern() { Discription = "Компоновщик", GetContextAction = () => new CompositeContext(),  Key = "composit" },
             new Pattern() { Discription = "Состояние", GetContextAction = () => new StateContext(),  Key = "state" },
             new Pattern() { Discription = "Мост", GetContextAction = () => new BridgeContext(),  Key = "bridge" },
             new Pattern() { Discription = "Строитель", GetContextAction = () => new BuilderContext(),  Key = "builder" },
             new Pattern() { Discription = "Прототип", GetContextAction = () => new PrototypeContext(),  Key = "prototype" },
             new Pattern() { Discription = "Легковес", GetContextAction = () => new FlyweightContext(),  Key = "flyweight" },
             new Pattern() { Discription = "Цепочка обязанностей", GetContextAction = () => new ChainContext(),  Key = "chain" }
         };

        static void Main(string[] args)
        {

            var patternsList = string.Empty;

            var i = 1;

            _patterns.ForEach(el => {
                patternsList = $"{patternsList}{i++}. {el.Key} - {el.Discription}\n";
            });

            Console.WriteLine($"Список паттернов:\n{patternsList}");

            WaitCommand();
        }

        private static void WaitCommand()
        {
            Console.WriteLine("Введите код паттерна");

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
