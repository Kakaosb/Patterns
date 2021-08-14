using Patterns.Def.Behavior.Mediator;

namespace Patterns.Impl.Behavior.Mediator
{
    public class SomeFood
    {
        protected IMediator _mediator;

        public SomeFood(IMediator mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}
