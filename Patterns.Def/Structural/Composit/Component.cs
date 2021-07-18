using System;

namespace Patterns.Def.Structural.Composit
{
    public abstract class Component
    {
        public Component() { }

        public abstract string Operation();

        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsBox()
        {
            return true;
        }
    }
}