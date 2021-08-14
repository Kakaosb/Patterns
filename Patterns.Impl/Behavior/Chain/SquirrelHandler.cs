using Patterns.Def.Behavior.Chain;

namespace Patterns.Impl.Behavior.Chain
{
    public class SquirrelHandler : AbstractHandler, IHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Nut")
            {
                return $"Squirrel: I'll eat the {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
