using Patterns.Impl.Structural.Proxy;
using System;

namespace Patterns.Contexts
{
    public class ProxyContext : IContext
    {
        public void Excecute()
        {
            Client client = new Client();

            Console.WriteLine("Client: вызов метода реального сервиса");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: вызов метода заместителя");
            Proxy proxy = new Proxy(realSubject);
            client.ClientCode(proxy);

            Console.WriteLine();
        }
    }
}
