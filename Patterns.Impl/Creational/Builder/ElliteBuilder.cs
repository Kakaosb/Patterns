using Patterns.Def.Creational.Builder;

namespace Patterns.Impl.Creational.Builder
{
    public class ElliteBuilder : IBuilder
    {
        private House _house = new House();

        public ElliteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._house = new House();
        }

        public void BuildFloor()
        {
            this._house.Add("Build Floor");
        }

        public void BuildWall()
        {
            this._house.Add("Build Wall");
        }

        public void BuildRoof()
        {
            this._house.Add("Build Roof");
        }


        public House GetHouse()
        {
            House result = this._house;

            this.Reset();

            return result;
        }
    }
}
