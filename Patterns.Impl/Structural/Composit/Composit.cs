using Patterns.Def.Structural.Composit;
using System.Collections.Generic;

namespace Patterns.Impl.Structural.Composit
{
   public class Box : Component
    {
        protected List<Component> _entries = new List<Component>();

        public override void Add(Component component)
        {
            this._entries.Add(component);
        }

        public override void Remove(Component component)
        {
            this._entries.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = "Коробка(";

            foreach (Component component in this._entries)
            {
                result = $"{result}{component.Operation()}";

                //нужно ли в конце ставить знак +
                if (i != this._entries.Count - 1)
                {
                    result = $"{result} + "; 
                }

                i++;
            }

            return $"{result})";  
        }
    }
}