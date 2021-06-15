using Patterns.Def.Structural.Proxy;

namespace Patterns.Impl.Structural.Proxy
{
    public class Client
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}
