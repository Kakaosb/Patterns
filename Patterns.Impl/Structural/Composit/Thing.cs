using Patterns.Def.Structural.Composit;

namespace Patterns.Impl.Structural.Composit
{
    public class Thing : Component
    {
        public string Name { get; set; }

        public Thing(string name)
        {
            Name = name;
        }

        public override string Operation()
        {
            return Name;
        }

        public override bool IsBox()
        {
            return false;
        }
    }
}