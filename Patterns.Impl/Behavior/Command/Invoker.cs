using Patterns.Def.Behavior.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Patterns.Impl.Behavior.Command
{
    public class Invoker
    {
        public void DoCalculation(List<IOperation> commands)
        {
            foreach (var command in commands)
            {
                var res = command.Calc()?.ToString() ?? "похоже, что вы нарушили законы математики, но это не точно";
                var info = command.GetArgumentValue();

                var name = string.Empty;

                var attr = command.GetType().GetCustomAttributes(typeof(DisplayNameAttribute), true)[0] as DisplayNameAttribute;
                if (attr != null)
                    name = attr.DisplayName;

                Console.WriteLine($"Результат операции {name} для чисел {info.Item1} и {info.Item2}: {res}");
            }
        }
    }
}