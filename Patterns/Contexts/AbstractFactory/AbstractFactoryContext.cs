using Patterns.Def.Creational;
using Patterns.Impl.Creational.AbstractFactory;
using System;

namespace Patterns.Contexts
{
    public class AbstractFactoryContext : IContext
    {
        public void Excecute()
        {
            Console.WriteLine("Client: Есть черная мебель");
            ClientMethod(new BlackFurnitureFactory());

            Console.WriteLine();

            Console.WriteLine("Client: Есть белая мебель");
            ClientMethod(new WhiteFurnitureFactory());

            Console.WriteLine();
        }

        private void ClientMethod(IAbstractFurnitureFactory factory)
        {
            var chair = factory.CreateChair();
            var sofa = factory.CreateSofa();

            sofa.BeSoft();
            chair.LookPretty();
            chair.StayTogether(sofa);
        }
    }
}
