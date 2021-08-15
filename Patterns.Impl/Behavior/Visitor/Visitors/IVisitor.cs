namespace Patterns.Impl.Behavior.Visitor
{
    public interface IVisitor
    {
        void VisitDrums(Drums element);

        void VisitPiano(Piano element);
    }
}
