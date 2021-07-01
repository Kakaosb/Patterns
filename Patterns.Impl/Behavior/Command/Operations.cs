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

        public abstract int? Calc();

        public Tuple<int, int> GetArgumentValue() {
            return new Tuple<int, int>(_a, _b);
        }
    }

    [DisplayName("Сложение")]
    public class Sum : Operation, ICommand
    {
        private int? _result;

        public Sum (int a, int b) : base(a, b) { }

        public override int? Calc()
        {
           if (_result == null)
                _result = _a + _b;

            return _result;
        }
    }

    [DisplayName("Вычитание")]
    public class Subtract : Operation, ICommand
    {
        private int? _result;

        public Subtract (int a, int b) : base(a, b) { }

        public override int? Calc()
        {
            if (_result == null)
                _result =  _a - _b;

            return _result;
        }
    }

    [DisplayName("Умножение")]
    public class Multi : Operation, ICommand
    {
        private int? _result;

        public Multi (int a, int b) : base(a, b) { }

        public override int? Calc()
        {
            if (_result == null)
                _result = _a * _b;

            return _result;
        }
    }

    [DisplayName("Деление")]
    public class Div : Operation, ICommand
    {
        private int? _result;

        public Div (int a, int b) : base(a, b) { }

        public override int? Calc()
        {
            if (_result == null && _b != 0)
                _result = _a / _b;

            return _result;
        }
    }
}