using Patterns.Def.Creational;

namespace Patterns.Impl.Creational.AbstractFactory
{
    public class BlackFurnitureFactory : IAbstractFurnitureFactory
    {
        public IAbstractChair CreateChair()
        {
            return new BlackChair();
        }

        public IAbstractSofa CreateSofa()
        {
            return new BlackSofa();
        }
    }
}
