using Patterns.Def.Behavior.FactoryMethod;

namespace Patterns.Impl.Creational.FactoryMethod
{
    public class DildoCreator: ToyCreator
    {
        public override IProduct FactoryMethod()
        {
            return new Dildo();
        }
    }
}