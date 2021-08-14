namespace Patterns.Def.Behavior.Chain
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }
}
