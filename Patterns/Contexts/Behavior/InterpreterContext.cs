using Patterns.Impl.Behavior.Interpreter;
using System;

namespace Patterns.Contexts
{
    class InterpreterContext : IContext
    {
        public void Excecute()
        {
            Context context = new Context();

            var expression = new NonterminalExpression();
            expression.Interpret(context);

            Console.WriteLine();
        }
    }
}
