using Patterns.Def.Behavior.FactoryMethod;

namespace Patterns.Impl.Creational.FactoryMethod
{
    public class MyHeartCreator : ToyCreator
    {
        public override IProduct FactoryMethod()
        {
            return new MyHeart();
        }
    }
}
