using Patterns.Impl.Structural.Facade;
using System;

namespace Patterns.Contexts
{
    public class FacadeContext : IContext
    {
        public void Excecute()
        {
            Creator creator = new Creator();
            Packer packer = new Packer();
            Facade facade = new Facade(creator, packer);

            Client.ClientCode(facade);

            Console.WriteLine();
        }
    }
}
