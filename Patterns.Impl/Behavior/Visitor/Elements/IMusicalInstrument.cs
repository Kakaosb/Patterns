namespace Patterns.Impl.Behavior.Visitor
{
    public interface IMusicalInstrument
    {
        void Accept(IVisitor visitor);
    }
}
