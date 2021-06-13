using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Def.Behavior.Observer
{
    public interface IListener
    {
        void Update(ISpeaker speaker);
    }
}
