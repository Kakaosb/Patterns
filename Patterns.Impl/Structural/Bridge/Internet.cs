using Patterns.Def.Structural.Bridge;

namespace Patterns.Impl.Structural.Bridge
{
    public class Internet : IImplementation
    {
        public string OperationImplementation()
        {
            return "Internet: Результат для платформы \"Молодежь\"";
        }
    }
}
