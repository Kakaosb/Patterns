using Patterns.Def.Creational;

namespace Patterns.Impl.Creational.AbstractFactory
{
    public class WhiteFurnitureFactory : IAbstractFurnitureFactory
    {
        public IAbstractChair CreateChair()
        {
            return new WhiteChair();
        }

        public IAbstractSofa CreateSofa()
        {
            return new WhiteSofa();
        }
    }
}
