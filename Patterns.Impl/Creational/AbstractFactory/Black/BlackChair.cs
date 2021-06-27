using Patterns.Def.Creational;
using System;

namespace Patterns.Impl.Creational.AbstractFactory
{
    public class BlackChair : IAbstractChair
    {
        public void LookPretty()
        {
            Console.WriteLine("Черный стул выглядит изящно!");
        }

        public void StayTogether(IAbstractSofa collaborator)
        {
            Console.WriteLine("Черная софа, постоишь со мной?");
            collaborator.Stay();
        }
    }
}
