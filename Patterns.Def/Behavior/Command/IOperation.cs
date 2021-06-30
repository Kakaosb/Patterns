using System;

namespace Patterns.Def.Behavior.Command
{
    public interface IOperation: ICommand
    {
        Tuple<int, int> GetArgumentValue();
    }
}
