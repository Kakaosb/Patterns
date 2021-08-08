using Patterns.Def.Creational.Builder;

namespace Patterns.Impl.Creational.Builder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalViableHouse()
        {
            this._builder.BuildFloor();
        }

        public void BuildFullFeaturedHouse()
        {
            this._builder.BuildFloor();
            this._builder.BuildWall();
            this._builder.BuildRoof();

        }
    }
}
