namespace Patterns.Impl.Behavior.Visitor
{
    public class Piano : IMusicalInstrument
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitPiano(this);
        }

        public string SpecialMethodOfConcreteComponentB()
        {
            return "Piano";
        }
    }
}
