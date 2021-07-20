using Patterns.Def.Structural.Bridge;

namespace Patterns.Impl.Structural.Bridge
{
    public class Pigeon : IImplementation
    {
        public string OperationImplementation()
        {
            return "Pigeon: Результат для платформы \"Старички\"";
        }
    }
}
