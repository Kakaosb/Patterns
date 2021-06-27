using Patterns.Def.Behavior.FactoryMethod;

namespace Patterns.Impl.Creational.FactoryMethod
{
    public class TetrisCreator : ToyCreator
    {
        public override IProduct FactoryMethod()
        {
            return new Tetris();
        }
    }
}
