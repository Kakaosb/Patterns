namespace Patterns.Impl.Behavior.Visitor
{
    public class Drums : IMusicalInstrument
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitDrums(this);
        }

        public string ExclusiveMethodOfDrums()
        {
            return "Drums";
        }
    }
}
