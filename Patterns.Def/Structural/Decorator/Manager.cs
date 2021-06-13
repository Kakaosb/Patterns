using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Def.Structural.Decorator
{
    public abstract class Manager : Notifier
    {
        protected Notifier _component;

        public Manager(Notifier component)
        {
            this._component = component;
        }

        public void SetComponent(Notifier component)
        {
            this._component = component;
        }

        public override void Send(Message message)
        {
            if (this._component != null)
            {
                 this._component.Send(message);
            }
        }
    }
}
