using Patterns.Impl.Behavior.Visitor;
using System;
using System.Collections.Generic;

namespace Patterns.Contexts
{
    public class VisitorContext : IContext
    {
        public void Excecute()
        {
            List<IMusicalInstrument> components = new List<IMusicalInstrument>
            {
                new Drums(),
                new Piano()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var clean = new VisitorClean();
            Client.ClientCode(components, clean);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var play = new VisitorPlay();
            Client.ClientCode(components, play);

            Console.WriteLine();
        }

        private class Client
        {
            public static void ClientCode(List<IMusicalInstrument> components, IVisitor visitor)
            {
                foreach (var component in components)
                {
                    component.Accept(visitor);
                }
            }
        }
    }
}