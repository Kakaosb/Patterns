using Patterns.Def.Behavior.Command;
using System;
using System.ComponentModel;

namespace Patterns.Impl.Behavior.Command
{
    public abstract class Operation : IOperation
    {
        protected int _a { get; set; }
        protected int _b { get; set; }

        public Operation(int a, int b) {
            _a = a;
            _b = b;
        }

        public virtual object Calc()
        {
            return 0;
        }

        public Tuple<int, int> GetArgumentValue() {
            return new Tuple<int, int>(_a, _b);
        }
    }

    [DisplayName("Сложение")]
    public class Sum : Operation, ICommand
    {
        public Sum (int a, int b) : base(a, b) { }

        public override object Calc()
        {
            return _a + _b;
        }
    }

    [DisplayName("Вычитание")]
    public class Subtract : Operation, ICommand
    {
        public Subtract (int a, int b) : base(a, b) { }

        public override object Calc()
        {
            return _a - _b;
        }
    }

    [DisplayName("Умножение")]
    public class Multi : Operation, ICommand
    {
        public Multi (int a, int b) : base(a, b) { }

        public override object Calc()
        {
            return _a * _b;
        }
    }

    [DisplayName("Деление")]
    public class Div : Operation, ICommand
    {
        public Div (int a, int b) : base(a, b) { }

        public override object Calc()
        {
            if (_b != 0)
                return _a / _b;
            else
                return "NaN"; 
        }
    }
}