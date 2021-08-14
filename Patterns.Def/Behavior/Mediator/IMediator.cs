namespace Patterns.Def.Behavior.Mediator
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
