using Patterns.Def.Structural.Bridge;

namespace Patterns.Impl.Structural.Bridge
{
    public class UserInterface
    {
        protected IImplementation _implementation;

        public UserInterface(IImplementation implementation)
        {
            this._implementation = implementation;
        }

        public virtual string SendQuery()
        {
            return "UserInterface: Выполняем операцию:\n" +
                _implementation.OperationImplementation();
        }
    }
}
