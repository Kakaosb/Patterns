using Patterns.Def.Creational;
using System;

namespace Patterns.Impl.Creational.AbstractFactory
{
    public class WhiteChair : IAbstractChair
    {
        public void LookPretty()
        {
            Console.WriteLine("Белый стул выглядит великолепно!");
        }

        public void StayTogether(IAbstractSofa collaborator)
        {
            Console.WriteLine("Белая софа, постоишь со мной?");
            collaborator.Stay();
        }
    }
}
