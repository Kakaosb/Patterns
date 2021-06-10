namespace Patterns.Def.Behavior.Strategy
{
    public interface IRouteStrategy
    {
        void BuildRoute(string from, string to);
    }
}
