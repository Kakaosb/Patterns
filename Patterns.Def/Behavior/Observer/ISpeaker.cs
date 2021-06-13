using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Def.Behavior.Observer
{
    public interface ISpeaker
    {
        void Subscribe(IListener listener);

        void Unsubscribe(IListener listener);

        void Notify();
    }
}
