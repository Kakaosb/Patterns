using Patterns.Def.Behavior.Chain;

namespace Patterns.Impl.Behavior.Chain
{
    public class DogHandler : AbstractHandler, IHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "MeatBall")
            {
                return $"Dog: I'll eat the {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
