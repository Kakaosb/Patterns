using Patterns.Def.Behavior.Chain;

namespace Patterns.Impl.Behavior.Chain
{
    public class MonkeyHandler : AbstractHandler, IHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Banana")
            {
                return $"Monkey: I'll eat the {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
