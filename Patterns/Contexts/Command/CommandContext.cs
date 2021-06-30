using Patterns.Def.Behavior.Command;
using Patterns.Impl.Behavior.Command;
using System;
using System.Collections.Generic;

namespace Patterns.Contexts
{
    public class CommandContext : IContext
    {
        public void Excecute()
        {
            Invoker invoker = new Invoker();

            var a1 = 4635;
            var b1 = 14;

            List<IOperation> operations1 = new List<IOperation>() {  
                new Sum(a1, b1),
                new Subtract(a1, b1), 
                new Multi(a1, b1),   
                new Div(a1, b1)
            };

            invoker.DoCalculation(operations1);
            Console.WriteLine();

            var a2 = 7456;
            var b2 = 0;

            List<IOperation> operations2 = new List<IOperation>() {
                new Sum(a2, b2),
                new Subtract(a2, b2),
                new Multi(a2, b2),
                new Div(a2, b2)
            };

            invoker.DoCalculation(operations2);
            Console.WriteLine();
        }
    }
}
