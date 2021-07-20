using Patterns.Def.Structural.Bridge;

namespace Patterns.Impl.Structural.Bridge
{
    public class ExtendedUI : UserInterface
    {
        public ExtendedUI(IImplementation implementation) : base(implementation)
        {
        }

        public override string SendQuery()
        {
            return "ExtendedUI: Расширенный метод\n" +
                base._implementation.OperationImplementation() + "\n";
        }
    }
}
